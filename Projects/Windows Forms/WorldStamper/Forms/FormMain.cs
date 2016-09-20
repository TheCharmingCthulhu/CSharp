using ElegantUI.Controls;
using System;
using System.Windows.Forms;
using WorldStamper.Forms;
using WorldStamper.Forms.Dialogs;
using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Models;
using WorldStamper.Sources.Models.Editor.Configs;
using WorldStamper.Sources.Models.Editor.Modules;
using WorldStamper.Sources.Models.Entities;
using WorldStamper.Sources.Models.Maps;
using WorldStamper.Sources.Views;

namespace WorldStamper
{
    public partial class FormMain : Form
    {
        internal static MainView View = new MainView();

        public FormMain()
        {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView()
        {
            View.OnMapsChanged += _view_OnMapsChanged;

            toolStripStatusToolMode.Text = "Cursor";
        }

        private void _view_OnMapsChanged(Map map)
        {
            ShowMap(map);
            ShowTilesets(map);
        }

        #region <- GUI ->
        private void ShowTilesets(Map resource)
        {
            comboBoxTilesets.Items.Clear();

            (resource as Map).Tilesets.ForEach(t =>
            {
                comboBoxTilesets.Items.Add(t);
            });
        }

        private void ShowMap(Map resource)
        {
            var map = resource as Map;

            var tab = new TabPage(map.Name);
            tab.Tag = map;

            var grid = new Grid()
            {
                GridWidth = map.Width,
                GridHeight = map.Height,
                CellWidth = 32,
                CellHeight = 32
            };
            grid.Dock = DockStyle.Fill;
            grid.Parent = tab;
            grid.CellSelect += Grid_CellSelect;
            grid.CellHover += Grid_CellHover;

            foreach (var tile in map.Tiles)
                grid.SetTile(tile.X, tile.Y, tile.Sprite.Texture);

            tabsMaps.TabPages.Add(tab);
            tabsMaps.SelectedTab = tab;
        }

        private void ShowImages(Tileset tileset)
        {
            comboBoxImages.Items.Clear();

            tileset.Images.ForEach(i =>
            {
                comboBoxImages.Items.Add(i);
            });

            comboBoxImages.Enabled = comboBoxImages.Items.Count > 0;
        }

        private void ShowTiles(Image image)
        {
            imageBoxTiles.Clear();

            image.Sprites.ForEach(s =>
            {
                imageBoxTiles.AddImage(s.Texture, s);
            });

            imageBoxTiles.Enabled = imageBoxTiles.Count() > 0;
            imageBoxTiles.Refresh();
        }
        #endregion

        #region <- Grid ->
        private void Grid_CellSelect(object sender, Grid.GridArgs e)
        {
            var view = sender as Grid;
            var map = GetCurrentTabResource() as Map;
            var config = GetCurrentTabResourceConfig() as MapConfig;

            if (config != null)
            {
                switch (config.Tool.Mode)
                {
                    case Tool.DrawMode.Paint:
                        if (config.Tool.Sprite != null)
                        {
                            view.SetTile(e.X, e.Y, config.Tool.Sprite.Texture);

                            map.ReplaceTile(e.X, e.Y, new Tile()
                            {
                                X = e.X,
                                Y = e.Y,
                                Sprite = new Sprite()
                                {
                                    ID = config.Tool.Sprite.ID,
                                    X = config.Tool.Sprite.X,
                                    Y = config.Tool.Sprite.Y,
                                    Texture = config.Tool.Sprite.Texture,
                                    Frames = config.Tool.Sprite.Frames
                                }
                            });
                        }
                        break;
                    case Tool.DrawMode.Entity:
                        if (config.Tool.Image != null)
                        {
                            view.RemoveOverlays(config.Tool.Image.Tag);
                            view.SetOverlay(e.X, e.Y, config.Tool.Image, config.Tool.Image.Tag);

                            HandleCoreEntityPlacement(map, config, e);
                        }
                        break;
                }
            }
        }

        private void Grid_CellHover(object sender, Grid.GridArgs e)
        {
            toolStripStatusCellX.Text = e.X.ToString();
            toolStripStatusCellY.Text = e.Y.ToString();
        }
        #endregion

        #region <- Main Menu ->
        private void menuItemNew_Click(object sender, System.EventArgs e)
        {
            if (FormNewMap.Run() == DialogResult.OK)
                View.CreateMap(View.GetResourceID<Map>(), FormNewMap.MapName, FormNewMap.MapWidth, FormNewMap.MapHeight);
        }

        private void menuItemExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void menuItemLoad_Click(object sender, EventArgs e)
        {
            if (DialogMaps.Run() == DialogResult.OK)
            {
                tabControlToolkits.SelectedIndex = 0;

                tabsMaps_SelectedIndexChanged(tabsMaps, e);
            }
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            SaveMapFileDialog();
        }

        private void SaveMapFileDialog()
        {
            var map = GetCurrentTabResource() as Map;

            if (map == null) return;

            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Map Files|*.xml;*.json;*.bin;*.zip",
                InitialDirectory = "..\\assets",
            };

            if (sfd.ShowDialog() == DialogResult.OK)
                View.SaveMap(map, sfd.FileName);
        }

        private void menuItemCloseAll_Click(object sender, EventArgs e)
        {
            foreach (TabPage tabPage in tabsMaps.TabPages)
                CloseTabPage(tabPage);
        }

        private void menuItemClose_Click(object sender, EventArgs e)
        {
            CloseTabPage(tabsMaps.SelectedTab);
        }

        private void CloseTabPage(TabPage tabPage)
        {
            if (tabPage == null) return;

            ValidateResources();

            tabsMaps.TabPages.Remove(tabPage);
        }
        #endregion

        #region <- Toolkit Panel ->

        #region <- Tilesets ->
        private void buttonCursor_Click(object sender, EventArgs e)
        {
            (GetCurrentTabResourceConfig() as MapConfig).Tool.Mode = Tool.DrawMode.Cursor;

            comboBoxTilesets.Enabled = false;
            comboBoxImages.Enabled = false;
            imageBoxTiles.Enabled = false;

            GetCurrentTabResourceConfig().Clear();

            ToolkitResetTilesetsTab(false);

            UpdateTool();
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            (GetCurrentTabResourceConfig() as MapConfig).Tool.Mode = Tool.DrawMode.Paint;

            comboBoxTilesets.Enabled = true;
            comboBoxImages.Enabled = false;
            imageBoxTiles.Enabled = false;

            ToolkitResetTilesetsTab(false);

            UpdateTool();
        }

        private void comboBoxTilesets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = sender as ComboBox;
            if (view.SelectedItem != null)
                ShowImages(view.SelectedItem as Tileset);

            imageBoxTiles.Clear();

            (GetCurrentTabResourceConfig() as MapConfig).SelectedTileset = view.SelectedItem as Tileset;
        }

        private void comboBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = sender as ComboBox;
            if (view.SelectedItem != null)
                ShowTiles(view.SelectedItem as Image);

            (GetCurrentTabResourceConfig() as MapConfig).SelectedImage = view.SelectedItem as Image;
        }

        private void imageBoxTiles_ImageSelected(WorldStamperUI.UI.Toolkit.ImageBox.ImageBoxArgs e)
        {
            (GetCurrentTabResourceConfig() as MapConfig).Tool.Sprite = e.Item.Tag as Sprite;
        }

        private void ToolkitUpdate()
        {
            var map = GetCurrentTabResource() as Map;
            var config = GetCurrentTabResourceConfig() as MapConfig;

            if (map != null) ShowTilesets(map);

            if (config != null)
            {
                if (config.SelectedTileset != null)
                {
                    ShowImages(config.SelectedTileset);

                    comboBoxTilesets.SelectedItem = config.SelectedTileset;
                }

                if (config.SelectedImage != null)
                {
                    ShowTiles(config.SelectedImage);

                    comboBoxImages.SelectedItem = config.SelectedImage;
                }
            }
        }

        private void ToolkitResetTilesetsTab(bool clear = true)
        {
            buttonCursor.Enabled = GetCurrentTabResource() != null;
            buttonPaint.Enabled = GetCurrentTabResource() != null;

            if (clear) comboBoxTilesets.Items.Clear();
            else comboBoxTilesets.SelectedIndex = -1;
            comboBoxTilesets.Enabled = (GetCurrentTabResourceConfig() as MapConfig)?.Tool.Mode == Tool.DrawMode.Paint;

            if (clear) comboBoxImages.Items.Clear();
            else comboBoxImages.SelectedIndex = -1;
            comboBoxImages.Enabled = false;

            imageBoxTiles.Clear();
        }
        #endregion

        #region <- Entities ->
        private void HandleCoreEntityPlacement(Map map, MapConfig config, Grid.GridArgs e)
        {
            if (listViewCoreEntities.SelectedItems.Count > 0)
            {
                switch (listViewCoreEntities.SelectedItems[0].Text.ToLower())
                {
                    case "spawn":
                        map.Spawn = new System.Drawing.Point(e.X, e.Y);
                        break;
                }
            }
        }

        private void ToolkitResetEntitiesTab(bool clear = true)
        {
            if (clear) comboBoxObjects.Items.Clear();
            else comboBoxObjects.SelectedIndex = -1;
            comboBoxObjects.Enabled = GetCurrentTabResource() != null;

            if (clear) listViewObjects.Items.Clear();
            listViewObjects.Enabled = GetCurrentTabResource() != null;

            if (clear) comboBoxTemplates.Items.Clear();
            comboBoxTemplates.Enabled = GetCurrentTabResource() != null;

            if (clear) pictureBoxPreview.Image = null;
            pictureBoxPreview.Enabled = GetCurrentTabResource() != null;

            listViewCoreEntities.Enabled = GetCurrentTabResource() != null;
        }

        private void tabControlToolkits_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = sender as TabControl;
            var map = GetCurrentTabResource() as Map;
            var mapConfig = GetCurrentTabResourceConfig() as MapConfig;

            if (map != null && mapConfig != null)
            {
                if (view.SelectedIndex == 0)
                {
                    mapConfig.Tool.Mode = Tool.DrawMode.Cursor;
                }
                else if (view.SelectedIndex == 1)
                {
                    if (map != null)
                    {
                        comboBoxObjects.Items.Clear();

                        ToolkitResetEntitiesTab();

                        foreach (var entityCollection in map.EntityCollections)
                            comboBoxObjects.Items.Add(entityCollection);

                        mapConfig.Tool.Mode = Tool.DrawMode.Entity;
                    }
                }
            }

            UpdateTool();
        }

        private void comboBoxObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = sender as ComboBox;

            if (view.SelectedItem != null)
            {
                listViewObjects.Clear();

                var entityCollection = view.SelectedItem as EntityCollection;

                foreach(var entity in entityCollection.Entities)
                {
                    var listViewItem = new ListViewItem(entity.Name);
                    listViewItem.Tag = entity;
                    listViewObjects.Items.Add(listViewItem);
                }
            }
        }

        private void listViewObjects_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = sender as ListView;

            if (view.SelectedItems.Count > 0)
            {
                var entity = (view.SelectedItems[0].Tag as Entity);

                pictureBoxPreview.Image = entity.GetTemplateImage("default");

                comboBoxTemplates.Items.Clear();
                foreach (var template in entity.Templates)
                    comboBoxTemplates.Items.Add(template);

                comboBoxTemplates.SelectedIndex = 0;
            }
        }

        private IResource GetCurrentEntityResource()
        {
            return listViewObjects.SelectedItems.Count > 0 ? listViewObjects.SelectedItems[0].Tag as Entity : null;
        }

        private void comboBoxTemplates_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxTemplates.SelectedIndex != -1)
            {
                var entity = GetCurrentEntityResource() as Entity;

                pictureBoxPreview.Image = entity.GetTemplateImage((comboBoxTemplates.SelectedItem as Template).Name);
            }
        }

        private void listViewEntities_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = sender as ListView;
            var config = GetCurrentTabResourceConfig() as MapConfig;

            if (view.SelectedItems.Count > 0)
                config.Tool.Image = new System.Drawing.Bitmap(imageListCoreEntities.Images[view.SelectedItems[0].Index]) { Tag = view.SelectedItems[0].Text.ToLower() };
        }
        #endregion

        #endregion

        #region <- Statusbar & Buttons ->
        private void UpdateTool()
        {
            var config = (GetCurrentTabResourceConfig() as MapConfig);

            if (config != null)
            {
                toolStripStatusToolMode.Text = Enum.GetName(typeof(Tool.DrawMode), config.Tool.Mode);

                switch (config.Tool.Mode)
                {
                    case Tool.DrawMode.Cursor:
                        buttonCursor.Focus();
                        GetCurrentTabGrid().SetHighlightColor(Grid.DefaultColor);
                        break;
                    case Tool.DrawMode.Paint:
                        buttonPaint.Focus();
                        GetCurrentTabGrid().SetHighlightColor(Grid.DefaultColor);
                        break;
                    case Tool.DrawMode.Entity:
                        GetCurrentTabGrid().SetHighlightColor(System.Drawing.Color.SkyBlue);
                        break;
                }
            }
        }
        #endregion

        #region <- Paint ->
        #endregion

        #region <- Tabs Control ->
        private Grid GetCurrentTabGrid()
        {
            return tabsMaps.SelectedTab.Controls[0] as Grid;
        }

        private IConfig GetCurrentTabResourceConfig()
        {
            if (GetCurrentTabResource() != null)
                return View.GetConfig(GetCurrentTabResource());

            return null;
        }

        private IResource GetCurrentTabResource()
        {
            if (tabsMaps.TabPages.Count > 0)
                return tabsMaps.SelectedTab.Tag as IResource;

            return null;
        }

        private void tabsMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = (sender as Tabs);
            var map = GetCurrentTabResource();
            var config = GetCurrentTabResourceConfig() as MapConfig;

            ToolkitResetEntitiesTab();
            ToolkitResetTilesetsTab();
            ToolkitUpdate();

            tabControlToolkits.SelectedIndex = 0;

            UpdateTool();
        }

        private void tabsMaps_TabClosing(Tabs.TabsEventArgs e)
        {
            if (ValidateResource())
                SaveMapFileDialog();
        }
        #endregion

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ValidateResources())
                View.SaveResources();
        }

        private bool ValidateResource()
        {
            if (GetCurrentTabResource().HasChanges())
            {
                if (MessageBox.Show("Would you like to save your changes?", "Save changes", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    View.OverwriteChange(GetCurrentTabResource());

                    return true;
                }
            }

            return false;
        }

        private bool ValidateResources()
        {
            if (View.HasChanges())
                if (DialogResources.Run("Save file changes", "Would you like to save your changes?", View.GetModifiedResources<Map>().ToArray()) == DialogResult.OK)
                {
                    View.OverwriteChanges();

                    return true;
                }

            return false;
        }
    }
}

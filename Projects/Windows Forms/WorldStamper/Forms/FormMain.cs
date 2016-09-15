using ElegantUI.Controls;
using System;
using System.Windows.Forms;
using WorldStamper.Forms;
using WorldStamper.Forms.Dialogs;
using WorldStamper.Sources.Interfaces;
using WorldStamper.Sources.Models;
using WorldStamper.Sources.Models.Editor;
using WorldStamper.Sources.Models.MapModules;
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

            ToolkitResetTilesetsTab();

            ShowTilesets(map);
        }

        #region <- GUI ->
        private void ShowTilesets(Map map)
        {
            comboBoxTilesets.Items.Clear();

            map.Tilesets.ForEach(t =>
            {
                comboBoxTilesets.Items.Add(t);
            });
        }

        private void ShowMap(Map map)
        {
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
            grid.TileSelect += Grid_TileSelect;

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
        private void Grid_TileSelect(object sender, Grid.GridArgs e)
        {
            var view = sender as Grid;
            var map = GetCurrentTabResource();
            var config = GetCurrentTabMapConfig() as MapConfig;

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
            DialogMaps.Run();
        }

        private void menuItemSave_Click(object sender, EventArgs e)
        {
            SaveMapFileDialog();
        }

        private void SaveMapFileDialog()
        {
            if (GetCurrentTabResource() == null) return;

            SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Map Files|*.xml;*.json;*.bin;*.zip",
                InitialDirectory = "..\\assets",
            };

            if (sfd.ShowDialog() == DialogResult.OK)
                View.SaveMap(GetCurrentTabResource(), sfd.FileName);
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
        private void buttonCursor_Click(object sender, EventArgs e)
        {
            (GetCurrentTabMapConfig() as MapConfig).Tool.Mode = Tool.DrawMode.Cursor;

            comboBoxTilesets.Enabled = false;
            comboBoxImages.Enabled = false;
            imageBoxTiles.Enabled = false;

            GetCurrentTabMapConfig().Clear();

            ToolkitResetTilesetsTab(false);

            UpdateTool();
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            (GetCurrentTabMapConfig() as MapConfig).Tool.Mode = Tool.DrawMode.Paint;

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

            (GetCurrentTabMapConfig() as MapConfig).SelectedTileset = view.SelectedItem as Tileset;
        }

        private void comboBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = sender as ComboBox;
            if (view.SelectedItem != null)
                ShowTiles(view.SelectedItem as Image);

            (GetCurrentTabMapConfig() as MapConfig).SelectedImage = view.SelectedItem as Image;
        }

        private void imageBoxTiles_ImageSelected(WorldStamperUI.UI.Toolkit.ImageBox.ImageBoxArgs e)
        {
            (GetCurrentTabMapConfig() as MapConfig).Tool.Sprite = e.Item.Tag as Sprite;
        }

        private void tabControlMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabsMaps.SelectedTab != null)
            {
                var map = GetCurrentTabResource();

                ToolkitResetTilesetsTab();

                ShowTilesets(map);
            }
        }

        private void ToolkitUpdate(Map map, MapConfig config)
        {
            if (map != null)
            {
                ShowTilesets(map);
            }

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
            comboBoxTilesets.Enabled = (GetCurrentTabMapConfig() as MapConfig)?.Tool.Mode == Tool.DrawMode.Paint;

            if (clear) comboBoxImages.Items.Clear();
            else comboBoxImages.SelectedIndex = -1;
            comboBoxImages.Enabled = false;

            imageBoxTiles.Clear();
        }
        #endregion

        #region <- Statusbar & Buttons ->
        private void UpdateTool()
        {
            var config = (GetCurrentTabMapConfig() as MapConfig);

            if (config != null)
            {
                toolStripStatusToolMode.Text = Enum.GetName(typeof(Tool.DrawMode), config.Tool.Mode);

                switch (config.Tool.Mode)
                {
                    case Tool.DrawMode.Cursor:
                        buttonCursor.Focus();
                        break;
                    case Tool.DrawMode.Paint:
                        buttonPaint.Focus();
                        break;
                }
            }
        }
        #endregion

        #region <- Paint ->
        #endregion

        #region <- Tabs Control ->
        private IConfig GetCurrentTabMapConfig()
        {
            if (GetCurrentTabResource() != null)
                return View.GetConfig(GetCurrentTabResource());

            return null;
        }

        private Map GetCurrentTabResource()
        {
            if (tabsMaps.TabPages.Count > 0)
                return tabsMaps.SelectedTab.Tag as Map;

            return null;
        }

        private void tabsMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = (sender as Tabs);
            var map = GetCurrentTabResource();
            var config = GetCurrentTabMapConfig() as MapConfig;

            ToolkitResetTilesetsTab();

            ToolkitUpdate(map, config);

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

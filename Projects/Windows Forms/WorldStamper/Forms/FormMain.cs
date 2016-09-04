using ElegantUI.Controls;
using System;
using System.Windows.Forms;
using WorldStamper.Forms;
using WorldStamper.Sources.Models;
using WorldStamper.Sources.Views;

namespace WorldStamper
{
    public partial class Main : Form
    {
        const bool _DEBUG = true;

        MainView _view = new MainView();

        public Main()
        {
            InitializeComponent();
            InitializeView();
        }

        private void InitializeView()
        {
            _view.OnMapsChanged += _view_OnMapsChanged;

            toolStripStatusToolMode.Text = "Cursor";
        }

        private void _view_OnMapsChanged(Map map)
        {
            ToolkitResetTilesets();

            ShowMap(map);
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

        private void Grid_TileSelect(object sender, Grid.GridArgs e)
        {
            var view = sender as Grid;

            if (_view.Tool.Sprite != null)
                view.SetTile(e.X, e.Y, _view.Tool.Sprite.Texture);
        }

        #region <- Main Menu ->
        private void menuItemNew_Click(object sender, System.EventArgs e)
        {
            if (FormNewMap.Run() == DialogResult.OK)
                _view.CreateMap(_view.GetNewID(), FormNewMap.MapName, FormNewMap.MapWidth, FormNewMap.MapHeight);
        }

        private void menuItemExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void menuItemLoad_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Map Files|*.xml;*.json;*.bin;*.zip",
                InitialDirectory = "..\\assets",
                Multiselect = true
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (ofd.FileNames.Length > 0)
                    foreach (var file in ofd.FileNames)
                        _view.LoadMap(file);
            }
        }
        #endregion

        #region <- Toolkit Panel ->
        private void buttonCursor_Click(object sender, EventArgs e)
        {
            _view.Tool.Mode = Tool.ToolMode.Cursor;

            toolStripStatusToolMode.Text = "Cursor";

            comboBoxTilesets.Enabled = false;
            comboBoxImages.Enabled = false;
            imageBoxTiles.Enabled = false;
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            _view.Tool.Mode = Tool.ToolMode.Paint;

            toolStripStatusToolMode.Text = "Paint";

            comboBoxTilesets.Enabled = true;
            comboBoxImages.Enabled = false;
            imageBoxTiles.Enabled = false;
        }

        private void comboBoxTilesets_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = sender as ComboBox;
            if (view.SelectedItem != null)
                ShowImages(view.SelectedItem as Tileset);
        }

        private void comboBoxImages_SelectedIndexChanged(object sender, EventArgs e)
        {
            var view = sender as ComboBox;
            if (view.SelectedItem != null)
                ShowTiles(view.SelectedItem as Image);
        }

        private void imageBoxTiles_ImageSelected(WorldStamperUI.UI.Toolkit.ImageBox.ImageBoxArgs e)
        {
            _view.Tool.Sprite = e.Item.Tag as Sprite;
        }

        private void tabControlMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabsMaps.SelectedTab != null)
            {
                var map = tabsMaps.SelectedTab.Tag as Map;

                ToolkitResetTilesets();
                ShowTilesets(map);
            }
        }

        private void ToolkitResetTilesets()
        {
            comboBoxTilesets.Items.Clear();
            comboBoxTilesets.Enabled = false;
            comboBoxImages.Items.Clear();
            comboBoxImages.Enabled = false;
            imageBoxTiles.Clear();
        }
        #endregion

        #region <- Paint ->
        #endregion
    }
}

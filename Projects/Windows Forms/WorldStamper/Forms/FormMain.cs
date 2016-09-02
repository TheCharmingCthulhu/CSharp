using System;
using System.Windows.Forms;
using WorldStamper.Forms;
using WorldStamper.Sources.Models;
using WorldStamper.Sources.UI;
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

            comboBoxTilesets.Enabled = comboBoxTilesets.Items.Count > 0;
        }

        private void ShowMap(Map map)
        {
            var tab = new TabPage(map.Name);
            tab.Tag = map;

            var grid = new MapGrid()
            {
                GridWidth = map.Width,
                GridHeight = map.Height,
                CellWidth = 32,
                CellHeight = 32
            };
            grid.Dock = DockStyle.Fill;
            grid.Parent = tab;

            foreach (var tile in map.Tiles)
                grid.AddImage(tile.X, tile.Y, tile.Sprite.Texture);

            tabControlMaps.TabPages.Add(tab);
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
                imageBoxTiles.AddImage(s.Texture);
            });

            imageBoxTiles.Refresh();
        }
        #endregion

        #region <- Main Menu ->
        private void menuItemNew_Click(object sender, System.EventArgs e)
        {
            if (FormNewMap.Run() == DialogResult.OK)
            {
                tabControlMaps.TabPages.Clear();

                _view.AddMap(_view.GetNewID(), FormNewMap.MapName, FormNewMap.MapWidth, FormNewMap.MapHeight);
            }
        }

        private void menuItemExit_Click(object sender, System.EventArgs e)
        {
            Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog()
            {
                Filter = "Map Files (*.xml)|*.xml",
                InitialDirectory = "..\\assets"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                tabControlMaps.TabPages.Clear();

                _view.LoadMap(ofd.FileName);
            }
        }
        #endregion

        #region <- Toolkit Panel ->
        private void buttonCursor_Click(object sender, EventArgs e)
        {
            _view.ToolMode = MainView.MapToolMode.Cursor;

            toolStripStatusToolMode.Text = "Cursor";
        }

        private void buttonPaint_Click(object sender, EventArgs e)
        {
            _view.ToolMode = MainView.MapToolMode.Paint;

            toolStripStatusToolMode.Text = "Paint";
        }

        private void tabControlMaps_TabIndexChanged(object sender, EventArgs e)
        {
            var map = tabControlMaps.SelectedTab.Tag as Map;

            ShowTilesets(map);
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
        #endregion
    }
}

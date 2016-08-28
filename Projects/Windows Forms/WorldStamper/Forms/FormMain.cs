using System;
using System.Drawing;
using System.Windows.Forms;
using WorldStamper.Forms;
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
        }

        private void _view_OnMapsChanged(Sources.Models.Map map)
        {
            InitializeNewMapView(map);
        }

        private void InitializeNewMapView(Sources.Models.Map map)
        {
            var tab = new TabPage(map.Name);

            var grid = new MapGrid()
            {
                GridWidth = map.Width,
                GridHeight = map.Height,
                CellWidth = 32,
                CellHeight = 32
            };
            grid.Dock = DockStyle.Fill;
            grid.Parent = tab;

            foreach(var tile in map.Tiles)
                grid.AddImage(tile.X, tile.Y, tile.Sprite.Texture);

            tabControlMaps.TabPages.Add(tab);
        }

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

        #endregion
    }
}

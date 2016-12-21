using MetroFramework.Controls;
using System.Collections.Generic;
using System.Drawing;
using System;

namespace FinanciA.Controls
{
    public partial class TileExplorer : MetroUserControl
    {
        public class Page
        {
            public const int PAGE_ITEM_COUNT = 4;

            public int PageIndex { get; set; } = -1;

            public class PageItem
            {
                public string Caption { get; set; }
                public Bitmap Image { get; set; }
                public Action<PageItem> Method { get; set; }
            }

            PageItem[] _PageItems = new PageItem[PAGE_ITEM_COUNT];

            public Page(int index)
            {
                PageIndex = index;

                for (int i = 0; i < PAGE_ITEM_COUNT; i++)
                {
                    _PageItems[i] = new PageItem();
                    _PageItems[i].Caption = string.Format("Item #{0}", (PageIndex * PAGE_ITEM_COUNT) + (i + 1));
                }
            }

            public PageItem GetPageItem(int index)
            {
                if (_PageItems.Length > index) return _PageItems[index];
                else return null;
            }
        }

        int _Index = 0;

        public List<Page> Pages { get; } = new List<Page>();

        public TileExplorer()
        {
            InitializeComponent();
            InitializeTiles();
        }

        private void InitializeTiles()
        {
            metroTileTopLeft.Click += TileControl_Click;
            metroTileTopRight.Click += TileControl_Click;
            metroTileBottomLeft.Click += TileControl_Click;
            metroTileBottomRight.Click += TileControl_Click;
        }

        public void InsertPage()
        {
            Pages.Add(new Page(Pages.Count));

            UpdateView();
        }

        public void DeletePage(int index)
        {
            if (Pages.Count > index) Pages.RemoveAt(index);
        }

        private void metroLinkNext_Click(object sender, System.EventArgs e)
        {
            if (Pages.Count > _Index + 1) _Index++;

            metroLabelPageIndex.Text = string.Format("Page.: {0}", _Index + 1);

            UpdateView();
        }

        private void metroLinkPrevious_Click(object sender, System.EventArgs e)
        {
            if (-1 < _Index - 1) _Index--;

            metroLabelPageIndex.Text = string.Format("Page.: {0}", _Index + 1);

            UpdateView();
        }

        public void UpdateView()
        {
            var page = Pages[_Index];
            if (page != null)
            {
                for (int i = 0; i < Page.PAGE_ITEM_COUNT; i++)
                {
                    var pageItem = page.GetPageItem(i);
                    var tileControl = tableLayoutPanelItems.Controls[i].Controls[0];

                    tileControl.Text = pageItem.Caption;
                    tileControl.Tag = pageItem;
                }
            }
        }

        private void TileControl_Click(object sender, EventArgs e)
        {
            var view = sender as MetroTile;
            if (view != null && view.Tag != null)
            {
                var pageItem = view.Tag as Page.PageItem;
                if (pageItem.Method != null) pageItem.Method(pageItem);
            }
        }
    }
}

using CarManager0323.DB;
using CarManager0323.Handler;
using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarManager0323
{
    partial class DealView : MaterialForm
    {
        private DaoOracle Oracle;
        private DealHandler dHandler;
        public DealView()
        {
            InitializeComponent();
        }

        public DealView(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.Oracle = oracle;
            this.dHandler = dHandler;
        }

        private void DealView_Load(object sender, EventArgs e)
        {
            /*initDealView();*/
        }

        private void custDetailbtn_Click(object sender, EventArgs e)
        {
            new CustDetailView().ShowDialog();
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void initListView()
        {
            string[] data = { "1", "홍길동", "그랜저", "40,000,000", "전우치", "21/3/21" };
            dealList.Items.Add(new ListViewItem(data));
            for (int i = 0; i < 50; i++)
            {
                dealList.Items.Add(new ListViewItem(
                    new string[]
                    {
                       (i+2).ToString(), "홍길동", "010-2929-3939", "조선 한양 홍대감댁", "hong@naver.com"
                    }
                    ));
            }
        }

        private void setRowColor(ListView list, Color color1, Color color2)
        {
            foreach (ListViewItem item in list.Items)
            {
                if ((item.Index % 2) == 0)
                {
                    item.BackColor = color1;
                }
                else
                {
                    item.BackColor = color2;
                }
            }
        }

        public void initDealView()
        {
            List<DealResult> list = oracle.selectDeal();
            /*string[] data = { "1", "홍길동", "그랜저", "40000000", "전우치", "21/3/31"};
            dealList.Items.Add(new ListViewItem(data));*/
            for (int i = 0; i < list.Count; i++)
            {
                dealList.Items.Add(new ListViewItem(
                    new string[]
                    {
                       list[i].Count.ToString(), list[i].CustName, list[i].Model, list[i].Price,
                        list[i].Seller, list[i].Day
                    }
                    ));
            }
            setRowColor(dealList, Color.White, Color.LightGray);
            int index = dealList.Items.Count - 1;
            dealList.Items[index].Focused = true;
            dealList.EnsureVisible(index);

        }
    }
}

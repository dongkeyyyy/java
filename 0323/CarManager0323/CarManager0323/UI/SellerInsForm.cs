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

namespace CarManager0323.UI
{
    partial class SellerInsForm : MaterialForm
    {
        private DealHandler dHandler;
        private DaoOracle oracle;

        public SellerInsForm()
        {
            InitializeComponent();
        }

        public SellerInsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public SellerInsForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void SellerInsForm_Load(object sender, EventArgs e)
        {

        }

        private void sellerOk_Click(object sender, EventArgs e)
        {
            if (sellerName.Text == "" || sellerTel.Text == "" ||
                sellerAddr.Text == "" || sellerEmail.Text == "" ||
                sellerOffice_name.Text == "")
            {
                MessageBox.Show("정보를 올바르게 입력해주세요");
                return;
            }

            List<Deal> list = dHandler.getDealList();
            try
            {
                Seller sell = new Seller(
                sellerName.Text,
                sellerTel.Text,
                sellerAddr.Text,
                sellerEmail.Text,
                sellerOffice_name.Text);
                list[0].Seller = sell;
                oracle.insertSeller(sell);
                Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("객체 정보를 확인하세요.");
            }
        }
    }
}

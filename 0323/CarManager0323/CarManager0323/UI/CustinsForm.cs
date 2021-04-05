using CarManager0323.DB;
using CarManager0323.Handler;
using CarManager0323.NewFolder1;
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
    partial class CustinsForm : MaterialForm
    {
        private DaoOracle oracle;
        private DealHandler dHandler;

        public CustinsForm()
        {
            InitializeComponent();
        }

        public CustinsForm(DaoOracle oracle)
        {
            InitializeComponent();
            this.oracle = oracle;
        }

        public CustinsForm(DaoOracle oracle, DealHandler dHandler)
        {
            InitializeComponent();
            this.oracle = oracle;
            this.dHandler = dHandler;
        }

        private void CustinsForm_Load(object sender, EventArgs e)
        {

        }

        private void custOk_Click(object sender, EventArgs e)
        {
            if (custName.Text == "" || custTel.Text == "" ||
                custAddr.Text == "" || custEmail.Text == "" )
            {
                MessageBox.Show("정보를 올바르게 입력해주세요");
                return;
            }

            List<Deal> list = dHandler.getDealList();

            try
            {
                Customer cust = new Customer(
                custName.Text,
                custTel.Text,
                custAddr.Text,
                custEmail.Text);
                list[0].Customer = cust;
                oracle.insertCustomer(cust);
                Close();
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("객체 정보를 확인하세요.");
            }
        }

        private void custExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

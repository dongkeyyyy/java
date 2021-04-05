using CarManager0323.DB;
using CarManager0323.Handler;
using CarManager0323.UI;
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

namespace CarManager0323
{
    public partial class MainForm : MaterialForm
    {
        DaoOracle ora = new DaoOracle();
        DealHandler dHandler = new DealHandler();

        public MainForm()
        {
            
            InitializeComponent();
        }

        MainForm(DaoOracle oracle)
        {

            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // ora.dbConnect();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // ora.dbClose();
        }

        private void createTB_Click(object sender, EventArgs e)
        {
            ora.createAllTB();
        }

        private void dropTB_Click(object sender, EventArgs e)
        {
            ora.dropAllTB();
        }

        private void uiImageButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void InsertAll_Click(object sender, EventArgs e)
        {
            ora.insertCar();
            ora.insertCustomer();
            ora.insertSeller();
            ora.insertDeal();
        }

        private void InsertCar_Click(object sender, EventArgs e)
        {
            new CarinsForm(ora, dHandler).ShowDialog();
        }

        private void InsertCustomer_Click(object sender, EventArgs e)
        {
            List<Deal> list = dHandler.getDealList();
            if (list[0].Customer != null)
            {
                MessageBox.Show("고객 정보가 이미 저장되었습니다.");
                return;
            }
            new CustinsForm(ora, dHandler).ShowDialog();
        }

        private void InsertSeller_Click(object sender, EventArgs e)
        {
            List<Deal> list = dHandler.getDealList();
            if (list[0].Seller != null)
            {
                MessageBox.Show("판매자 정보가 이미 저장되었습니다.");
                return;
            }
            new SellerInsForm(ora, dHandler).ShowDialog();
        }   

        private void InsertDeal_Click(object sender, EventArgs e)
        {
            List<Deal> list = dHandler.getDealList();
            if (list[0].Car==null || list[0].Customer==null ||
                list[0].Seller == null)
            {
                MessageBox.Show("구매 내역 정보가 누락되었습니다.");
            }
            /*ora.insertDeal(list[0]);*/
            ora.insertDeal(list[0].Customer, list[0].Car, list[0].Seller);
            

            dHandler.dealListClear();
        }

        private void appExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void selectDeal_click(object sender, EventArgs e)
        {
            new DealView().ShowDialog();
        }
    }
}

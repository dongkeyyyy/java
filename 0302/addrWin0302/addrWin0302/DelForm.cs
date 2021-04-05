using MaterialSkin.Controls;
using adressTest0218.control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using adressTest0218;

namespace addrWin0302
{
    partial class DelForm : MaterialForm
    {
        public DelForm()
        {
            InitializeComponent();
        }

        StudentHandler sc;

        public DelForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }


        private void DelForm_Load(object sender, EventArgs e)
        {

        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void uiRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void uiRichTextBox1_TextChanged_1(object sender, EventArgs e)
        {
           
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            List<Student> addrList = sc.getList();
            for (int i = 0; i < addrList.Count; i++)
            {
                if (addrList[i].Name.Equals(delTextBox.Text))
                {
                    addrList.RemoveAt(i--);
                }
            }
            Close();

        }
    }
}

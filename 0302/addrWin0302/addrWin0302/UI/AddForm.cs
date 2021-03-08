using adressTest0218;
using adressTest0218.control;
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

namespace addrWin0302.UI
{
    //public partial class AddForm : MaterialForm
    partial class AddForm : MaterialForm
    {
        StudentHandler sc;

        public AddForm()
        {
            InitializeComponent();
        }
        
        public AddForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void AddForm_Load(object sender, EventArgs e)
        {

        }

        private void uiTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiSymbolLabel2_Click(object sender, EventArgs e)
        {

        }

        private void uiTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {

        }

        private void addCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addOk_Click(object sender, EventArgs e)
        {
            if (addName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요.");
            }
            else if (addTel.Text == "")
            {
                MessageBox.Show("전화번호를 입력하세요.");
            }
            else if (addAddr.Text == "")
            {
                MessageBox.Show("주소를 입력하세요.");
            }
            else if (addEmail.Text == "")
            {
                MessageBox.Show("이메일을 입력하세요.");
            }

            // string name = addName.Text;
            Random r = new Random();
            StudentHandler.getInst().getList().Add(
                new Student(StudentHandler.getInst().getId(),
                addName.Text, addTel.Text, addAddr.Text , addEmail.Text));
            MessageBox.Show("정상적으로 데이터가 입력되었습니다.");
            Close();
        }
    }
}

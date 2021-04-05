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

namespace addrWin0302
{
    partial class UpdateForm : MaterialForm
    {
        public UpdateForm()
        {
            InitializeComponent();
        }

        StudentHandler sc;

        public UpdateForm(StudentHandler sc)
        {
            InitializeComponent();
            this.sc = sc;
        }

        private void showList()
        {
            int cnt = sc.getList().Count;
            for (int i = 0; i < cnt; i++)
            {
                List<Student> addrList = sc.getList();
                uplist.Items.Add(new ListViewItem(
                    new string[]
                    {
                        (i+1).ToString(),
                        addrList[i].Name,
                        addrList[i].Tel,
                        addrList[i].Address,
                        addrList[i].Email,
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

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            showList();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void uiLabel2_Click(object sender, EventArgs e)
        {

        }

        private void upCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uplist_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uplist.SelectedItems.Count != 0)
            {
                int n = uplist.SelectedItems[0].Index;
                string name = uplist.Items[n].SubItems[1].Text;
                string tel = uplist.Items[n].SubItems[2].Text;
                string addr = uplist.Items[n].SubItems[3].Text;
                string email = uplist.Items[n].SubItems[4].Text;
                Console.WriteLine("이름 : {0}", name);
                Console.WriteLine("전화 : {0}", tel);
                Console.WriteLine("주소 : {0}", addr);
                Console.WriteLine("이메일 : {0}", email);
                Console.WriteLine("-----------------------");
                upName.Text = name;
                upTel.Text = tel;
                upAddr.Text = addr;
                upEmail.Text = email;

                if (upName.Text != "")
                {
                    name = upName.Text;
                }
                else if (upTel.Text != "")
                {
                    tel = upTel.Text;
                }
                else if (upAddr.Text != "")
                {
                    addr = upAddr.Text;
                }
                else if (upEmail.Text != "")
                {
                    email = upEmail.Text;
                }
            }
        }

        private void upOk_Click(object sender, EventArgs e)
        {
            if (upName.Text == "")
            {
                MessageBox.Show("이름을 입력하세요.");
            }
            else if (upTel.Text == "")
            {
                MessageBox.Show("전화번호를 입력하세요.");
            }
            else if (upAddr.Text == "")
            {
                MessageBox.Show("주소를 입력하세요.");
            }
            else if (upEmail.Text == "")
            {
                MessageBox.Show("이메일을 입력하세요.");
            }

            // string name = addName.Text;
            sc.getList().Add(
                new Student(sc.getId(),
                upName.Text, upTel.Text, upAddr.Text, upEmail.Text));
            MessageBox.Show("정상적으로 데이터가 입력되었습니다.");
            Close();
        }

        private void upName_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}

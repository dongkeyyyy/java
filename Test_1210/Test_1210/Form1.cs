using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test_1210
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string message = $"{textBox1.Text}, {textBox2.Text}";  
            String message = "Hello World"; // 헬로우 월드라는 메세지박스가 뜬다

            //1
            string one = "string" + 123 + "  " + 456;
            MessageBox.Show(message);

            int a = 123;
            int b = 456;

            string ex = $"첫번째 숫자는{a}이고 두번째 숫자는 {b}이다" ;
        }
    }
}

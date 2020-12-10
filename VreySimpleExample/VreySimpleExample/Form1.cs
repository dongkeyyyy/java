using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VreySimpleExample
{
    public partial class Form1 : Form
    {
        int countTime = 0;
        int cTime = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("안녕하세요");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string message = textBox_message.Text;
            MessageBox.Show($"내가 빈 칸에 적은 말은 {message}이다.");
            
            // snake 표기법
            // 닩어 사이에 밑줄이 들어감
            // int dj_money_acount = 0;
            // 카멜리안표기법(낙타표기법)
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label_nowTime.Text = $"{DateTime.Now.Year}년 {DateTime.Now.Month}월" +
             $" {DateTime.Now.Day}일 {DateTime.Now.Hour}시" +
             $" {DateTime.Now.Minute}분 {DateTime.Now.Second}초";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //내가 지정한 interval에 한번씩 동작
            //여기에선 1000ms(1초) 에 한번 동작
            label_second.Text = countTime.ToString();
            countTime++;
        }

        private void label_second_Click(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            //1초에 한번씩 label_s의 Text의 값을 바꾸는 것
            label_s.Text = cTime.ToString();
            cTime++;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.naver.com");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.kbs.co.kr");

        }
    }
}


namespace CarManager0323.UI
{
    partial class CustinsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.custExit = new Sunny.UI.UISymbolButton();
            this.custOk = new Sunny.UI.UISymbolButton();
            this.custTel = new Sunny.UI.UITextBox();
            this.custAddr = new Sunny.UI.UITextBox();
            this.custEmail = new Sunny.UI.UITextBox();
            this.custName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.SuspendLayout();
            // 
            // custExit
            // 
            this.custExit.BackColor = System.Drawing.Color.Transparent;
            this.custExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custExit.FillColor = System.Drawing.Color.Red;
            this.custExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custExit.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.custExit.IsCircle = true;
            this.custExit.Location = new System.Drawing.Point(413, 381);
            this.custExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.custExit.Name = "custExit";
            this.custExit.Size = new System.Drawing.Size(100, 35);
            this.custExit.Style = Sunny.UI.UIStyle.Custom;
            this.custExit.Symbol = 61453;
            this.custExit.TabIndex = 5;
            this.custExit.Click += new System.EventHandler(this.custExit_Click);
            // 
            // custOk
            // 
            this.custOk.BackColor = System.Drawing.Color.Transparent;
            this.custOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.custOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custOk.IsCircle = true;
            this.custOk.Location = new System.Drawing.Point(187, 381);
            this.custOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.custOk.Name = "custOk";
            this.custOk.Size = new System.Drawing.Size(100, 35);
            this.custOk.Style = Sunny.UI.UIStyle.Custom;
            this.custOk.TabIndex = 19;
            this.custOk.Click += new System.EventHandler(this.custOk_Click);
            // 
            // custTel
            // 
            this.custTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custTel.FillColor = System.Drawing.Color.White;
            this.custTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custTel.Location = new System.Drawing.Point(413, 169);
            this.custTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custTel.Maximum = 2147483647D;
            this.custTel.Minimum = -2147483648D;
            this.custTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.custTel.Name = "custTel";
            this.custTel.Padding = new System.Windows.Forms.Padding(5);
            this.custTel.Size = new System.Drawing.Size(150, 29);
            this.custTel.TabIndex = 2;
            // 
            // custAddr
            // 
            this.custAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custAddr.FillColor = System.Drawing.Color.White;
            this.custAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custAddr.Location = new System.Drawing.Point(413, 227);
            this.custAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custAddr.Maximum = 2147483647D;
            this.custAddr.Minimum = -2147483648D;
            this.custAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.custAddr.Name = "custAddr";
            this.custAddr.Padding = new System.Windows.Forms.Padding(5);
            this.custAddr.Size = new System.Drawing.Size(150, 29);
            this.custAddr.TabIndex = 3;
            // 
            // custEmail
            // 
            this.custEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custEmail.FillColor = System.Drawing.Color.White;
            this.custEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custEmail.Location = new System.Drawing.Point(413, 285);
            this.custEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custEmail.Maximum = 2147483647D;
            this.custEmail.Minimum = -2147483648D;
            this.custEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.custEmail.Name = "custEmail";
            this.custEmail.Padding = new System.Windows.Forms.Padding(5);
            this.custEmail.Size = new System.Drawing.Size(150, 29);
            this.custEmail.TabIndex = 4;
            // 
            // custName
            // 
            this.custName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.custName.FillColor = System.Drawing.Color.White;
            this.custName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custName.Location = new System.Drawing.Point(413, 111);
            this.custName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.custName.Maximum = 2147483647D;
            this.custName.Minimum = -2147483648D;
            this.custName.MinimumSize = new System.Drawing.Size(1, 1);
            this.custName.Name = "custName";
            this.custName.Padding = new System.Windows.Forms.Padding(5);
            this.custName.Size = new System.Drawing.Size(150, 29);
            this.custName.TabIndex = 1;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(152, 285);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(150, 29);
            this.uiSymbolLabel4.TabIndex = 12;
            this.uiSymbolLabel4.Text = "이메일";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(152, 227);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(150, 29);
            this.uiSymbolLabel3.TabIndex = 11;
            this.uiSymbolLabel3.Text = "주소";
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(152, 169);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(150, 29);
            this.uiSymbolLabel2.TabIndex = 10;
            this.uiSymbolLabel2.Text = "전화";
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(152, 111);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(150, 29);
            this.uiSymbolLabel1.TabIndex = 9;
            this.uiSymbolLabel1.Text = "이름";
            // 
            // CustinsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 581);
            this.Controls.Add(this.custExit);
            this.Controls.Add(this.custOk);
            this.Controls.Add(this.custTel);
            this.Controls.Add(this.custAddr);
            this.Controls.Add(this.custEmail);
            this.Controls.Add(this.custName);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "CustinsForm";
            this.Text = "고객 추가 정보";
            this.Load += new System.EventHandler(this.CustinsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton custExit;
        private Sunny.UI.UISymbolButton custOk;
        private Sunny.UI.UITextBox custTel;
        private Sunny.UI.UITextBox custAddr;
        private Sunny.UI.UITextBox custEmail;
        private Sunny.UI.UITextBox custName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
    }
}
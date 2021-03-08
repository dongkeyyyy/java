
namespace addrWin0302.UI
{
    partial class AddForm
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
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.addName = new Sunny.UI.UITextBox();
            this.addTel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.addAddr = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.addEmail = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.addOk = new Sunny.UI.UISymbolButton();
            this.addCancel = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(137, 119);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel1.Symbol = 62144;
            this.uiSymbolLabel1.TabIndex = 0;
            this.uiSymbolLabel1.Text = "이름";
            // 
            // addName
            // 
            this.addName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addName.FillColor = System.Drawing.Color.White;
            this.addName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addName.Location = new System.Drawing.Point(352, 119);
            this.addName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addName.Maximum = 2147483647D;
            this.addName.Minimum = -2147483648D;
            this.addName.MinimumSize = new System.Drawing.Size(1, 1);
            this.addName.Name = "addName";
            this.addName.Padding = new System.Windows.Forms.Padding(5);
            this.addName.Size = new System.Drawing.Size(145, 29);
            this.addName.TabIndex = 1;
            this.addName.TextChanged += new System.EventHandler(this.uiTextBox1_TextChanged);
            // 
            // addTel
            // 
            this.addTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addTel.FillColor = System.Drawing.Color.White;
            this.addTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addTel.Location = new System.Drawing.Point(352, 183);
            this.addTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTel.Maximum = 2147483647D;
            this.addTel.Minimum = -2147483648D;
            this.addTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addTel.Name = "addTel";
            this.addTel.Padding = new System.Windows.Forms.Padding(5);
            this.addTel.Size = new System.Drawing.Size(145, 29);
            this.addTel.TabIndex = 3;
            this.addTel.TextChanged += new System.EventHandler(this.uiTextBox2_TextChanged);
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(137, 183);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel2.Symbol = 57488;
            this.uiSymbolLabel2.TabIndex = 2;
            this.uiSymbolLabel2.Text = "전화";
            this.uiSymbolLabel2.Click += new System.EventHandler(this.uiSymbolLabel2_Click);
            // 
            // addAddr
            // 
            this.addAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addAddr.FillColor = System.Drawing.Color.White;
            this.addAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addAddr.Location = new System.Drawing.Point(352, 246);
            this.addAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addAddr.Maximum = 2147483647D;
            this.addAddr.Minimum = -2147483648D;
            this.addAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.addAddr.Name = "addAddr";
            this.addAddr.Padding = new System.Windows.Forms.Padding(5);
            this.addAddr.Size = new System.Drawing.Size(145, 29);
            this.addAddr.TabIndex = 3;
            this.addAddr.Text = " ";
            this.addAddr.TextChanged += new System.EventHandler(this.uiTextBox3_TextChanged);
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(137, 246);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel3.Symbol = 98;
            this.uiSymbolLabel3.TabIndex = 2;
            this.uiSymbolLabel3.Text = "주소";
            // 
            // addEmail
            // 
            this.addEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.addEmail.FillColor = System.Drawing.Color.White;
            this.addEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addEmail.Location = new System.Drawing.Point(352, 302);
            this.addEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addEmail.Maximum = 2147483647D;
            this.addEmail.Minimum = -2147483648D;
            this.addEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.addEmail.Name = "addEmail";
            this.addEmail.Padding = new System.Windows.Forms.Padding(5);
            this.addEmail.Size = new System.Drawing.Size(145, 29);
            this.addEmail.TabIndex = 3;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(137, 302);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel4.Symbol = 61664;
            this.uiSymbolLabel4.TabIndex = 2;
            this.uiSymbolLabel4.Text = "메일";
            // 
            // addOk
            // 
            this.addOk.BackColor = System.Drawing.Color.Transparent;
            this.addOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addOk.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addOk.ForeDisableColor = System.Drawing.Color.White;
            this.addOk.IsCircle = true;
            this.addOk.Location = new System.Drawing.Point(187, 390);
            this.addOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.addOk.Name = "addOk";
            this.addOk.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addOk.RectDisableColor = System.Drawing.Color.White;
            this.addOk.Size = new System.Drawing.Size(120, 60);
            this.addOk.Style = Sunny.UI.UIStyle.Custom;
            this.addOk.TabIndex = 4;
            this.addOk.Click += new System.EventHandler(this.addOk_Click);
            // 
            // addCancel
            // 
            this.addCancel.BackColor = System.Drawing.Color.Transparent;
            this.addCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addCancel.FillColor = System.Drawing.Color.Red;
            this.addCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.addCancel.IsCircle = true;
            this.addCancel.Location = new System.Drawing.Point(352, 390);
            this.addCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.addCancel.Name = "addCancel";
            this.addCancel.RectColor = System.Drawing.Color.Red;
            this.addCancel.Size = new System.Drawing.Size(120, 60);
            this.addCancel.Style = Sunny.UI.UIStyle.Custom;
            this.addCancel.Symbol = 61453;
            this.addCancel.TabIndex = 5;
            this.addCancel.Click += new System.EventHandler(this.addCancel_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 584);
            this.Controls.Add(this.addCancel);
            this.Controls.Add(this.addOk);
            this.Controls.Add(this.addEmail);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.addAddr);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.addTel);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.addName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "AddForm";
            this.Text = "주소록 데이터 추가";
            this.Load += new System.EventHandler(this.AddForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private Sunny.UI.UITextBox addName;
        private Sunny.UI.UITextBox addTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox addAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox addEmail;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UISymbolButton addOk;
        private Sunny.UI.UISymbolButton addCancel;
    }
}
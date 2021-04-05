
namespace addrWin0302
{
    partial class UpdateForm
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
            this.upCancel = new Sunny.UI.UISymbolButton();
            this.upOk = new Sunny.UI.UISymbolButton();
            this.upEmail = new Sunny.UI.UITextBox();
            this.uiSymbolLabel4 = new Sunny.UI.UISymbolLabel();
            this.upAddr = new Sunny.UI.UITextBox();
            this.uiSymbolLabel3 = new Sunny.UI.UISymbolLabel();
            this.upTel = new Sunny.UI.UITextBox();
            this.uiSymbolLabel2 = new Sunny.UI.UISymbolLabel();
            this.upName = new Sunny.UI.UITextBox();
            this.uiSymbolLabel1 = new Sunny.UI.UISymbolLabel();
            this.uplist = new System.Windows.Forms.ListView();
            this.list_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_tel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_addr = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.list_email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // upCancel
            // 
            this.upCancel.BackColor = System.Drawing.Color.Transparent;
            this.upCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upCancel.FillColor = System.Drawing.Color.Red;
            this.upCancel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upCancel.IsCircle = true;
            this.upCancel.Location = new System.Drawing.Point(366, 494);
            this.upCancel.MinimumSize = new System.Drawing.Size(1, 1);
            this.upCancel.Name = "upCancel";
            this.upCancel.RectColor = System.Drawing.Color.Red;
            this.upCancel.Size = new System.Drawing.Size(120, 60);
            this.upCancel.Style = Sunny.UI.UIStyle.Custom;
            this.upCancel.Symbol = 61453;
            this.upCancel.TabIndex = 15;
            this.upCancel.Click += new System.EventHandler(this.upCancel_Click);
            // 
            // upOk
            // 
            this.upOk.BackColor = System.Drawing.Color.Transparent;
            this.upOk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.upOk.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.upOk.FillSelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.upOk.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upOk.ForeDisableColor = System.Drawing.Color.White;
            this.upOk.IsCircle = true;
            this.upOk.Location = new System.Drawing.Point(139, 494);
            this.upOk.MinimumSize = new System.Drawing.Size(1, 1);
            this.upOk.Name = "upOk";
            this.upOk.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.upOk.RectDisableColor = System.Drawing.Color.White;
            this.upOk.Size = new System.Drawing.Size(120, 60);
            this.upOk.Style = Sunny.UI.UIStyle.Custom;
            this.upOk.TabIndex = 14;
            this.upOk.Click += new System.EventHandler(this.upOk_Click);
            // 
            // upEmail
            // 
            this.upEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upEmail.FillColor = System.Drawing.Color.White;
            this.upEmail.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upEmail.Location = new System.Drawing.Point(328, 438);
            this.upEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upEmail.Maximum = 2147483647D;
            this.upEmail.Minimum = -2147483648D;
            this.upEmail.MinimumSize = new System.Drawing.Size(1, 1);
            this.upEmail.Name = "upEmail";
            this.upEmail.Padding = new System.Windows.Forms.Padding(5);
            this.upEmail.Size = new System.Drawing.Size(189, 29);
            this.upEmail.TabIndex = 11;
            // 
            // uiSymbolLabel4
            // 
            this.uiSymbolLabel4.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel4.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel4.Location = new System.Drawing.Point(113, 438);
            this.uiSymbolLabel4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel4.Name = "uiSymbolLabel4";
            this.uiSymbolLabel4.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel4.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel4.Symbol = 61664;
            this.uiSymbolLabel4.TabIndex = 8;
            this.uiSymbolLabel4.Text = "메일";
            // 
            // upAddr
            // 
            this.upAddr.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upAddr.FillColor = System.Drawing.Color.White;
            this.upAddr.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upAddr.Location = new System.Drawing.Point(328, 384);
            this.upAddr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upAddr.Maximum = 2147483647D;
            this.upAddr.Minimum = -2147483648D;
            this.upAddr.MinimumSize = new System.Drawing.Size(1, 1);
            this.upAddr.Name = "upAddr";
            this.upAddr.Padding = new System.Windows.Forms.Padding(5);
            this.upAddr.Size = new System.Drawing.Size(189, 29);
            this.upAddr.TabIndex = 12;
            this.upAddr.Text = " ";
            // 
            // uiSymbolLabel3
            // 
            this.uiSymbolLabel3.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel3.Location = new System.Drawing.Point(113, 384);
            this.uiSymbolLabel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel3.Name = "uiSymbolLabel3";
            this.uiSymbolLabel3.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel3.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel3.Symbol = 98;
            this.uiSymbolLabel3.TabIndex = 9;
            this.uiSymbolLabel3.Text = "주소";
            // 
            // upTel
            // 
            this.upTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upTel.FillColor = System.Drawing.Color.White;
            this.upTel.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upTel.Location = new System.Drawing.Point(328, 328);
            this.upTel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upTel.Maximum = 2147483647D;
            this.upTel.Minimum = -2147483648D;
            this.upTel.MinimumSize = new System.Drawing.Size(1, 1);
            this.upTel.Name = "upTel";
            this.upTel.Padding = new System.Windows.Forms.Padding(5);
            this.upTel.Size = new System.Drawing.Size(189, 29);
            this.upTel.TabIndex = 13;
            // 
            // uiSymbolLabel2
            // 
            this.uiSymbolLabel2.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel2.Location = new System.Drawing.Point(113, 328);
            this.uiSymbolLabel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel2.Name = "uiSymbolLabel2";
            this.uiSymbolLabel2.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel2.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel2.Symbol = 57488;
            this.uiSymbolLabel2.TabIndex = 10;
            this.uiSymbolLabel2.Text = "전화";
            // 
            // upName
            // 
            this.upName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.upName.FillColor = System.Drawing.Color.White;
            this.upName.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.upName.Location = new System.Drawing.Point(328, 273);
            this.upName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.upName.Maximum = 2147483647D;
            this.upName.Minimum = -2147483648D;
            this.upName.MinimumSize = new System.Drawing.Size(1, 1);
            this.upName.Name = "upName";
            this.upName.Padding = new System.Windows.Forms.Padding(5);
            this.upName.Size = new System.Drawing.Size(189, 29);
            this.upName.TabIndex = 7;
            this.upName.TextChanged += new System.EventHandler(this.upName_TextChanged);
            // 
            // uiSymbolLabel1
            // 
            this.uiSymbolLabel1.BackColor = System.Drawing.Color.Transparent;
            this.uiSymbolLabel1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolLabel1.Location = new System.Drawing.Point(113, 273);
            this.uiSymbolLabel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolLabel1.Name = "uiSymbolLabel1";
            this.uiSymbolLabel1.Padding = new System.Windows.Forms.Padding(28, 0, 0, 0);
            this.uiSymbolLabel1.Size = new System.Drawing.Size(170, 35);
            this.uiSymbolLabel1.Symbol = 62144;
            this.uiSymbolLabel1.TabIndex = 6;
            this.uiSymbolLabel1.Text = "이름";
            // 
            // uplist
            // 
            this.uplist.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.list_count,
            this.list_name,
            this.list_tel,
            this.list_addr,
            this.list_email});
            this.uplist.FullRowSelect = true;
            this.uplist.GridLines = true;
            this.uplist.HideSelection = false;
            this.uplist.Location = new System.Drawing.Point(17, 81);
            this.uplist.Name = "uplist";
            this.uplist.Size = new System.Drawing.Size(630, 168);
            this.uplist.TabIndex = 16;
            this.uplist.UseCompatibleStateImageBehavior = false;
            this.uplist.View = System.Windows.Forms.View.Details;
            this.uplist.SelectedIndexChanged += new System.EventHandler(this.uplist_SelectedIndexChanged);
            // 
            // list_count
            // 
            this.list_count.Text = "번 호";
            // 
            // list_name
            // 
            this.list_name.Text = "이 름";
            this.list_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // list_tel
            // 
            this.list_tel.Text = "전 화";
            this.list_tel.Width = 140;
            // 
            // list_addr
            // 
            this.list_addr.Text = "주 소";
            this.list_addr.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // list_email
            // 
            this.list_email.Text = "이메일";
            this.list_email.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 584);
            this.Controls.Add(this.uplist);
            this.Controls.Add(this.upCancel);
            this.Controls.Add(this.upOk);
            this.Controls.Add(this.upEmail);
            this.Controls.Add(this.uiSymbolLabel4);
            this.Controls.Add(this.upAddr);
            this.Controls.Add(this.uiSymbolLabel3);
            this.Controls.Add(this.upTel);
            this.Controls.Add(this.uiSymbolLabel2);
            this.Controls.Add(this.upName);
            this.Controls.Add(this.uiSymbolLabel1);
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "주소록 수정";
            this.Load += new System.EventHandler(this.UpdateForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UISymbolButton upCancel;
        private Sunny.UI.UISymbolButton upOk;
        private Sunny.UI.UITextBox upEmail;
        private Sunny.UI.UISymbolLabel uiSymbolLabel4;
        private Sunny.UI.UITextBox upAddr;
        private Sunny.UI.UISymbolLabel uiSymbolLabel3;
        private Sunny.UI.UITextBox upTel;
        private Sunny.UI.UISymbolLabel uiSymbolLabel2;
        private Sunny.UI.UITextBox upName;
        private Sunny.UI.UISymbolLabel uiSymbolLabel1;
        private System.Windows.Forms.ListView uplist;
        private System.Windows.Forms.ColumnHeader list_count;
        private System.Windows.Forms.ColumnHeader list_name;
        private System.Windows.Forms.ColumnHeader list_tel;
        private System.Windows.Forms.ColumnHeader list_addr;
        private System.Windows.Forms.ColumnHeader list_email;
    }
}
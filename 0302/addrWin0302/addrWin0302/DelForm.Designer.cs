
namespace addrWin0302
{
    partial class DelForm
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
            this.uiSymbolButton1 = new Sunny.UI.UISymbolButton();
            this.delTextBox = new Sunny.UI.UIRichTextBox();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton3 = new Sunny.UI.UISymbolButton();
            this.SuspendLayout();
            // 
            // uiSymbolButton1
            // 
            this.uiSymbolButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton1.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton1.Location = new System.Drawing.Point(111, 187);
            this.uiSymbolButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton1.Name = "uiSymbolButton1";
            this.uiSymbolButton1.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton1.TabIndex = 1;
            this.uiSymbolButton1.Text = "이름";
            this.uiSymbolButton1.Click += new System.EventHandler(this.uiSymbolButton1_Click);
            // 
            // delTextBox
            // 
            this.delTextBox.AutoWordSelection = true;
            this.delTextBox.FillColor = System.Drawing.Color.White;
            this.delTextBox.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.delTextBox.Location = new System.Drawing.Point(259, 188);
            this.delTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.delTextBox.MinimumSize = new System.Drawing.Size(1, 1);
            this.delTextBox.Name = "delTextBox";
            this.delTextBox.Padding = new System.Windows.Forms.Padding(2);
            this.delTextBox.Size = new System.Drawing.Size(295, 34);
            this.delTextBox.Style = Sunny.UI.UIStyle.Custom;
            this.delTextBox.TabIndex = 2;
            this.delTextBox.TextChanged += new System.EventHandler(this.uiRichTextBox1_TextChanged_1);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(292, 277);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton2.TabIndex = 3;
            this.uiSymbolButton2.Text = "삭제";
            this.uiSymbolButton2.Click += new System.EventHandler(this.uiSymbolButton2_Click);
            // 
            // uiSymbolButton3
            // 
            this.uiSymbolButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton3.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton3.Location = new System.Drawing.Point(454, 277);
            this.uiSymbolButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton3.Name = "uiSymbolButton3";
            this.uiSymbolButton3.Size = new System.Drawing.Size(100, 35);
            this.uiSymbolButton3.TabIndex = 4;
            this.uiSymbolButton3.Text = "종료";
            this.uiSymbolButton3.Click += new System.EventHandler(this.uiSymbolButton3_Click);
            // 
            // DelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.uiSymbolButton3);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.delTextBox);
            this.Controls.Add(this.uiSymbolButton1);
            this.Name = "DelForm";
            this.Text = "DelForm";
            this.Load += new System.EventHandler(this.DelForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UISymbolButton uiSymbolButton1;
        private Sunny.UI.UIRichTextBox delTextBox;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
        private Sunny.UI.UISymbolButton uiSymbolButton3;
    }
}

namespace CarManager0323
{
    partial class DealView
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
            this.dealList = new System.Windows.Forms.ListView();
            this.deal_count = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_model = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.deal_seller = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.custDetailbtn = new Sunny.UI.UISymbolButton();
            this.dealViewClose = new Sunny.UI.UISymbolButton();
            this.deal_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // dealList
            // 
            this.dealList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.deal_count,
            this.deal_name,
            this.deal_model,
            this.deal_price,
            this.deal_seller,
            this.deal_date});
            this.dealList.FullRowSelect = true;
            this.dealList.GridLines = true;
            this.dealList.HideSelection = false;
            this.dealList.Location = new System.Drawing.Point(9, 72);
            this.dealList.Name = "dealList";
            this.dealList.Size = new System.Drawing.Size(772, 308);
            this.dealList.TabIndex = 1;
            this.dealList.UseCompatibleStateImageBehavior = false;
            this.dealList.View = System.Windows.Forms.View.Details;
            this.dealList.SelectedIndexChanged += new System.EventHandler(this.listView_SelectedIndexChanged);
            // 
            // deal_count
            // 
            this.deal_count.Text = "번 호";
            // 
            // deal_name
            // 
            this.deal_name.Text = "고객 이름";
            this.deal_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_name.Width = 160;
            // 
            // deal_model
            // 
            this.deal_model.Text = "구매차량";
            this.deal_model.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_model.Width = 120;
            // 
            // deal_price
            // 
            this.deal_price.Text = "구매 가격";
            this.deal_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_price.Width = 137;
            // 
            // deal_seller
            // 
            this.deal_seller.Text = "판매자";
            this.deal_seller.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_seller.Width = 171;
            // 
            // custDetailbtn
            // 
            this.custDetailbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.custDetailbtn.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.custDetailbtn.Location = new System.Drawing.Point(803, 110);
            this.custDetailbtn.MinimumSize = new System.Drawing.Size(1, 1);
            this.custDetailbtn.Name = "custDetailbtn";
            this.custDetailbtn.Size = new System.Drawing.Size(177, 35);
            this.custDetailbtn.TabIndex = 2;
            this.custDetailbtn.Text = "고객 상세 정보";
            this.custDetailbtn.Click += new System.EventHandler(this.custDetailbtn_Click);
            // 
            // dealViewClose
            // 
            this.dealViewClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dealViewClose.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dealViewClose.Location = new System.Drawing.Point(803, 168);
            this.dealViewClose.MinimumSize = new System.Drawing.Size(1, 1);
            this.dealViewClose.Name = "dealViewClose";
            this.dealViewClose.Size = new System.Drawing.Size(177, 35);
            this.dealViewClose.TabIndex = 3;
            this.dealViewClose.Text = "닫 기";
            // 
            // deal_date
            // 
            this.deal_date.Text = "거래 날짜";
            this.deal_date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.deal_date.Width = 120;
            // 
            // DealView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 587);
            this.Controls.Add(this.dealViewClose);
            this.Controls.Add(this.custDetailbtn);
            this.Controls.Add(this.dealList);
            this.Name = "DealView";
            this.Text = "거래 내역 보기";
            this.Load += new System.EventHandler(this.DealView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView dealList;
        private System.Windows.Forms.ColumnHeader deal_count;
        private System.Windows.Forms.ColumnHeader deal_name;
        private System.Windows.Forms.ColumnHeader deal_model;
        private System.Windows.Forms.ColumnHeader deal_price;
        private System.Windows.Forms.ColumnHeader deal_seller;
        private Sunny.UI.UISymbolButton custDetailbtn;
        private Sunny.UI.UISymbolButton dealViewClose;
        private System.Windows.Forms.ColumnHeader deal_date;
    }
}
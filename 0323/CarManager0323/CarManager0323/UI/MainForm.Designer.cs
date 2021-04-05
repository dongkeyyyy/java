
namespace CarManager0323
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.createTB = new Sunny.UI.UIButton();
            this.dropTB = new Sunny.UI.UIButton();
            this.InsertAll = new Sunny.UI.UISymbolButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.InsertCar = new Sunny.UI.UISymbolButton();
            this.InsertCustomer = new Sunny.UI.UISymbolButton();
            this.InsertSeller = new Sunny.UI.UISymbolButton();
            this.InsertDeal = new Sunny.UI.UISymbolButton();
            this.appExit = new Sunny.UI.UISymbolButton();
            this.selectDeal = new Sunny.UI.UISymbolButton();
            this.uiSymbolButton2 = new Sunny.UI.UISymbolButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // createTB
            // 
            this.createTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.createTB.Location = new System.Drawing.Point(615, 27);
            this.createTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.createTB.Name = "createTB";
            this.createTB.Size = new System.Drawing.Size(100, 35);
            this.createTB.TabIndex = 0;
            this.createTB.Text = "테이블 생성";
            this.createTB.Click += new System.EventHandler(this.createTB_Click);
            // 
            // dropTB
            // 
            this.dropTB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dropTB.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.dropTB.Location = new System.Drawing.Point(756, 27);
            this.dropTB.MinimumSize = new System.Drawing.Size(1, 1);
            this.dropTB.Name = "dropTB";
            this.dropTB.Size = new System.Drawing.Size(100, 35);
            this.dropTB.TabIndex = 1;
            this.dropTB.Text = "테이블 삭제";
            this.dropTB.Click += new System.EventHandler(this.dropTB_Click);
            // 
            // InsertAll
            // 
            this.InsertAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertAll.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.InsertAll.Location = new System.Drawing.Point(486, 95);
            this.InsertAll.MinimumSize = new System.Drawing.Size(1, 1);
            this.InsertAll.Name = "InsertAll";
            this.InsertAll.Size = new System.Drawing.Size(193, 44);
            this.InsertAll.TabIndex = 3;
            this.InsertAll.Text = "데이터 추가 All";
            this.InsertAll.Click += new System.EventHandler(this.InsertAll_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(463, 604);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // InsertCar
            // 
            this.InsertCar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertCar.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.InsertCar.Location = new System.Drawing.Point(486, 159);
            this.InsertCar.MinimumSize = new System.Drawing.Size(1, 1);
            this.InsertCar.Name = "InsertCar";
            this.InsertCar.Size = new System.Drawing.Size(193, 44);
            this.InsertCar.Symbol = 61881;
            this.InsertCar.TabIndex = 5;
            this.InsertCar.Text = "차량 정보 추가";
            this.InsertCar.Click += new System.EventHandler(this.InsertCar_Click);
            // 
            // InsertCustomer
            // 
            this.InsertCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertCustomer.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.InsertCustomer.Location = new System.Drawing.Point(486, 224);
            this.InsertCustomer.MinimumSize = new System.Drawing.Size(1, 1);
            this.InsertCustomer.Name = "InsertCustomer";
            this.InsertCustomer.Size = new System.Drawing.Size(193, 44);
            this.InsertCustomer.Symbol = 61447;
            this.InsertCustomer.TabIndex = 6;
            this.InsertCustomer.Text = "고객 정보 추가";
            this.InsertCustomer.Click += new System.EventHandler(this.InsertCustomer_Click);
            // 
            // InsertSeller
            // 
            this.InsertSeller.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertSeller.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.InsertSeller.Location = new System.Drawing.Point(486, 292);
            this.InsertSeller.MinimumSize = new System.Drawing.Size(1, 1);
            this.InsertSeller.Name = "InsertSeller";
            this.InsertSeller.Size = new System.Drawing.Size(193, 44);
            this.InsertSeller.Symbol = 62142;
            this.InsertSeller.TabIndex = 7;
            this.InsertSeller.Text = "판매자 정보 추가";
            this.InsertSeller.Click += new System.EventHandler(this.InsertSeller_Click);
            // 
            // InsertDeal
            // 
            this.InsertDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.InsertDeal.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.InsertDeal.Location = new System.Drawing.Point(486, 361);
            this.InsertDeal.MinimumSize = new System.Drawing.Size(1, 1);
            this.InsertDeal.Name = "InsertDeal";
            this.InsertDeal.Size = new System.Drawing.Size(193, 44);
            this.InsertDeal.Symbol = 61686;
            this.InsertDeal.TabIndex = 8;
            this.InsertDeal.Text = "거래 정보 추가";
            this.InsertDeal.Click += new System.EventHandler(this.InsertDeal_Click);
            // 
            // appExit
            // 
            this.appExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appExit.FillColor = System.Drawing.Color.Red;
            this.appExit.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.appExit.Location = new System.Drawing.Point(486, 575);
            this.appExit.MinimumSize = new System.Drawing.Size(1, 1);
            this.appExit.Name = "appExit";
            this.appExit.Size = new System.Drawing.Size(193, 44);
            this.appExit.Style = Sunny.UI.UIStyle.Custom;
            this.appExit.Symbol = 61453;
            this.appExit.TabIndex = 9;
            this.appExit.Text = "프로그램 종료";
            this.appExit.Click += new System.EventHandler(this.appExit_Click);
            // 
            // selectDeal
            // 
            this.selectDeal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectDeal.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.selectDeal.Location = new System.Drawing.Point(486, 437);
            this.selectDeal.MinimumSize = new System.Drawing.Size(1, 1);
            this.selectDeal.Name = "selectDeal";
            this.selectDeal.Size = new System.Drawing.Size(193, 44);
            this.selectDeal.Symbol = 62140;
            this.selectDeal.TabIndex = 10;
            this.selectDeal.Text = "거래 내역 보기 보기";
            this.selectDeal.Click += new System.EventHandler(this.selectDeal_click);
            // 
            // uiSymbolButton2
            // 
            this.uiSymbolButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiSymbolButton2.Font = new System.Drawing.Font("Microsoft YaHei", 12F);
            this.uiSymbolButton2.Location = new System.Drawing.Point(486, 506);
            this.uiSymbolButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiSymbolButton2.Name = "uiSymbolButton2";
            this.uiSymbolButton2.Size = new System.Drawing.Size(193, 44);
            this.uiSymbolButton2.Symbol = 61736;
            this.uiSymbolButton2.TabIndex = 11;
            this.uiSymbolButton2.Text = "도움말";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 666);
            this.Controls.Add(this.uiSymbolButton2);
            this.Controls.Add(this.selectDeal);
            this.Controls.Add(this.appExit);
            this.Controls.Add(this.InsertDeal);
            this.Controls.Add(this.InsertSeller);
            this.Controls.Add(this.InsertCustomer);
            this.Controls.Add(this.InsertCar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.InsertAll);
            this.Controls.Add(this.dropTB);
            this.Controls.Add(this.createTB);
            this.Name = "MainForm";
            this.Text = "차량 고객 관리 프로그램 v1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Sunny.UI.UIButton createTB;
        private Sunny.UI.UIButton dropTB;
        private Sunny.UI.UISymbolButton InsertAll;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Sunny.UI.UISymbolButton InsertCar;
        private Sunny.UI.UISymbolButton InsertCustomer;
        private Sunny.UI.UISymbolButton InsertSeller;
        private Sunny.UI.UISymbolButton InsertDeal;
        private Sunny.UI.UISymbolButton appExit;
        private Sunny.UI.UISymbolButton selectDeal;
        private Sunny.UI.UISymbolButton uiSymbolButton2;
    }
}


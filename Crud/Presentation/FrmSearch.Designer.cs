namespace Crud.Presentation
{
    partial class FrmSearch
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.searchBtn = new System.Windows.Forms.Button();
            this.detailbtn = new System.Windows.Forms.Button();
            this.bottunAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.tBoxCarName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBoxCClass = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tBoxNumber = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cBoxUsed = new System.Windows.Forms.ComboBox();
            this.tBoxColor = new System.Windows.Forms.TextBox();
            this.labelColor = new System.Windows.Forms.Label();
            this.cBoxStartYear = new System.Windows.Forms.ComboBox();
            this.cBoxStartMonth = new System.Windows.Forms.ComboBox();
            this.cBoxStartDay = new System.Windows.Forms.ComboBox();
            this.cBoxLastYear = new System.Windows.Forms.ComboBox();
            this.cBoxLastMonth = new System.Windows.Forms.ComboBox();
            this.cBoxLastDay = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tBoxCapacity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.tBoxNumClass = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(24, 264);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.Size = new System.Drawing.Size(1528, 542);
            this.dataGridView1.TabIndex = 0;
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(822, 207);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(163, 46);
            this.searchBtn.TabIndex = 1;
            this.searchBtn.Text = "検索";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // detailbtn
            // 
            this.detailbtn.Location = new System.Drawing.Point(999, 206);
            this.detailbtn.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.detailbtn.Name = "detailbtn";
            this.detailbtn.Size = new System.Drawing.Size(163, 46);
            this.detailbtn.TabIndex = 2;
            this.detailbtn.Text = "明細";
            this.detailbtn.UseVisualStyleBackColor = true;
            this.detailbtn.Click += new System.EventHandler(this.detailbtn_Click);
            // 
            // bottunAdd
            // 
            this.bottunAdd.Location = new System.Drawing.Point(1176, 207);
            this.bottunAdd.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.bottunAdd.Name = "bottunAdd";
            this.bottunAdd.Size = new System.Drawing.Size(163, 46);
            this.bottunAdd.TabIndex = 3;
            this.bottunAdd.Text = "追加";
            this.bottunAdd.UseVisualStyleBackColor = true;
            this.bottunAdd.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1353, 207);
            this.buttonDelete.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(163, 46);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "削除";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // tBoxCarName
            // 
            this.tBoxCarName.Location = new System.Drawing.Point(215, 12);
            this.tBoxCarName.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tBoxCarName.Name = "tBoxCarName";
            this.tBoxCarName.Size = new System.Drawing.Size(258, 31);
            this.tBoxCarName.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "自動車名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 68);
            this.label2.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "車種区分";
            // 
            // cBoxCClass
            // 
            this.cBoxCClass.DisplayMember = "普通車";
            this.cBoxCClass.FormattingEnabled = true;
            this.cBoxCClass.Items.AddRange(new object[] {
            "",
            "普通車",
            "軽自動車"});
            this.cBoxCClass.Location = new System.Drawing.Point(215, 62);
            this.cBoxCClass.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cBoxCClass.Name = "cBoxCClass";
            this.cBoxCClass.Size = new System.Drawing.Size(258, 32);
            this.cBoxCClass.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 170);
            this.label3.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 25);
            this.label3.TabIndex = 9;
            this.label3.Text = "ナンバープレート";
            // 
            // tBoxNumber
            // 
            this.tBoxNumber.Location = new System.Drawing.Point(215, 164);
            this.tBoxNumber.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tBoxNumber.Name = "tBoxNumber";
            this.tBoxNumber.Size = new System.Drawing.Size(258, 31);
            this.tBoxNumber.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(548, 18);
            this.label4.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "車検日";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1062, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 25);
            this.label5.TabIndex = 13;
            this.label5.Text = "から";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(522, 120);
            this.label6.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "使用状況";
            // 
            // cBoxUsed
            // 
            this.cBoxUsed.FormattingEnabled = true;
            this.cBoxUsed.Items.AddRange(new object[] {
            "",
            "未使用",
            "使用中"});
            this.cBoxUsed.Location = new System.Drawing.Point(644, 112);
            this.cBoxUsed.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cBoxUsed.Name = "cBoxUsed";
            this.cBoxUsed.Size = new System.Drawing.Size(242, 32);
            this.cBoxUsed.TabIndex = 16;
            // 
            // tBoxColor
            // 
            this.tBoxColor.Location = new System.Drawing.Point(215, 214);
            this.tBoxColor.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tBoxColor.Name = "tBoxColor";
            this.tBoxColor.Size = new System.Drawing.Size(258, 31);
            this.tBoxColor.TabIndex = 17;
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(165, 228);
            this.labelColor.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(37, 25);
            this.labelColor.TabIndex = 18;
            this.labelColor.Text = "色";
            // 
            // cBoxStartYear
            // 
            this.cBoxStartYear.FormattingEnabled = true;
            this.cBoxStartYear.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.cBoxStartYear.Items.AddRange(new object[] {
            "",
            "平成27年",
            "平成28年",
            "平成29年",
            "平成30年",
            "平成31年",
            "平成32年"});
            this.cBoxStartYear.Location = new System.Drawing.Point(644, 12);
            this.cBoxStartYear.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cBoxStartYear.Name = "cBoxStartYear";
            this.cBoxStartYear.Size = new System.Drawing.Size(112, 32);
            this.cBoxStartYear.TabIndex = 19;
            // 
            // cBoxStartMonth
            // 
            this.cBoxStartMonth.FormattingEnabled = true;
            this.cBoxStartMonth.Items.AddRange(new object[] {
            "",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cBoxStartMonth.Location = new System.Drawing.Point(802, 12);
            this.cBoxStartMonth.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cBoxStartMonth.Name = "cBoxStartMonth";
            this.cBoxStartMonth.Size = new System.Drawing.Size(84, 32);
            this.cBoxStartMonth.TabIndex = 20;
            // 
            // cBoxStartDay
            // 
            this.cBoxStartDay.FormattingEnabled = true;
            this.cBoxStartDay.Items.AddRange(new object[] {
            "",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cBoxStartDay.Location = new System.Drawing.Point(936, 12);
            this.cBoxStartDay.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cBoxStartDay.Name = "cBoxStartDay";
            this.cBoxStartDay.Size = new System.Drawing.Size(76, 32);
            this.cBoxStartDay.TabIndex = 21;
            // 
            // cBoxLastYear
            // 
            this.cBoxLastYear.FormattingEnabled = true;
            this.cBoxLastYear.Items.AddRange(new object[] {
            "",
            "平成27年",
            "平成28年",
            "平成29年",
            "平成30年",
            "平成31年",
            "平成32年"});
            this.cBoxLastYear.Location = new System.Drawing.Point(1116, 10);
            this.cBoxLastYear.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cBoxLastYear.Name = "cBoxLastYear";
            this.cBoxLastYear.Size = new System.Drawing.Size(117, 32);
            this.cBoxLastYear.TabIndex = 22;
            // 
            // cBoxLastMonth
            // 
            this.cBoxLastMonth.FormattingEnabled = true;
            this.cBoxLastMonth.Items.AddRange(new object[] {
            "",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cBoxLastMonth.Location = new System.Drawing.Point(1278, 10);
            this.cBoxLastMonth.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cBoxLastMonth.Name = "cBoxLastMonth";
            this.cBoxLastMonth.Size = new System.Drawing.Size(89, 32);
            this.cBoxLastMonth.TabIndex = 23;
            // 
            // cBoxLastDay
            // 
            this.cBoxLastDay.FormattingEnabled = true;
            this.cBoxLastDay.Items.AddRange(new object[] {
            "",
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cBoxLastDay.Location = new System.Drawing.Point(1419, 12);
            this.cBoxLastDay.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.cBoxLastDay.Name = "cBoxLastDay";
            this.cBoxLastDay.Size = new System.Drawing.Size(78, 32);
            this.cBoxLastDay.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(763, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 25);
            this.label7.TabIndex = 25;
            this.label7.Text = "年";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(893, 20);
            this.label8.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(37, 25);
            this.label8.TabIndex = 26;
            this.label8.Text = "月";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(1029, 20);
            this.label9.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 25);
            this.label9.TabIndex = 27;
            this.label9.Text = "日";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(1239, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 25);
            this.label10.TabIndex = 28;
            this.label10.Text = "年";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1376, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(37, 25);
            this.label11.TabIndex = 29;
            this.label11.Text = "月";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(1515, 18);
            this.label12.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(37, 25);
            this.label12.TabIndex = 30;
            this.label12.Text = "日";
            // 
            // tBoxCapacity
            // 
            this.tBoxCapacity.Location = new System.Drawing.Point(644, 62);
            this.tBoxCapacity.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tBoxCapacity.Name = "tBoxCapacity";
            this.tBoxCapacity.Size = new System.Drawing.Size(242, 31);
            this.tBoxCapacity.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(568, 68);
            this.label13.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 25);
            this.label13.TabIndex = 32;
            this.label13.Text = "定員";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(87, 120);
            this.label14.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 25);
            this.label14.TabIndex = 33;
            this.label14.Text = "分類番号";
            // 
            // tBoxNumClass
            // 
            this.tBoxNumClass.Location = new System.Drawing.Point(215, 114);
            this.tBoxNumClass.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.tBoxNumClass.Name = "tBoxNumClass";
            this.tBoxNumClass.Size = new System.Drawing.Size(258, 31);
            this.tBoxNumClass.TabIndex = 34;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 830);
            this.Controls.Add(this.tBoxNumClass);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tBoxCapacity);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cBoxLastDay);
            this.Controls.Add(this.cBoxLastMonth);
            this.Controls.Add(this.cBoxLastYear);
            this.Controls.Add(this.cBoxStartDay);
            this.Controls.Add(this.cBoxStartMonth);
            this.Controls.Add(this.cBoxStartYear);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.tBoxColor);
            this.Controls.Add(this.cBoxUsed);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tBoxNumber);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBoxCClass);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxCarName);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.bottunAdd);
            this.Controls.Add(this.detailbtn);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FrmSearch";
            this.Text = "検索画面";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button detailbtn;
        private System.Windows.Forms.Button bottunAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox tBoxCarName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cBoxCClass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tBoxNumber;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cBoxUsed;
        private System.Windows.Forms.TextBox tBoxColor;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ComboBox cBoxStartYear;
        private System.Windows.Forms.ComboBox cBoxStartMonth;
        private System.Windows.Forms.ComboBox cBoxStartDay;
        private System.Windows.Forms.ComboBox cBoxLastYear;
        private System.Windows.Forms.ComboBox cBoxLastMonth;
        private System.Windows.Forms.ComboBox cBoxLastDay;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBoxCapacity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tBoxNumClass;
    }
}


namespace Crud.Presentation
{
    partial class FrmDetail
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
            this.tBoxDetailCar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dGView = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.buttonRenewal = new System.Windows.Forms.Button();
            this.buttonRequest = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tBoxNumber = new System.Windows.Forms.TextBox();
            this.cBoxVClass = new System.Windows.Forms.ComboBox();
            this.tBoxColor = new System.Windows.Forms.TextBox();
            this.tBoxCapacity = new System.Windows.Forms.TextBox();
            this.tBoxDisplacement = new System.Windows.Forms.TextBox();
            this.tBoxVInspection = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tBoxNumClass = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.labelVTax = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.labelFuelEfficiency = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.checkBoxUsed = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).BeginInit();
            this.SuspendLayout();
            // 
            // tBoxDetailCar
            // 
            this.tBoxDetailCar.Location = new System.Drawing.Point(83, 12);
            this.tBoxDetailCar.Name = "tBoxDetailCar";
            this.tBoxDetailCar.Size = new System.Drawing.Size(100, 19);
            this.tBoxDetailCar.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "自動車名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "車種区分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "色";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(237, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 4;
            this.label4.Text = "定員";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "ナンバープレート";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(385, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 6;
            this.label6.Text = "排気量";
            // 
            // dGView
            // 
            this.dGView.AllowUserToDeleteRows = false;
            this.dGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dGView.Location = new System.Drawing.Point(51, 177);
            this.dGView.Name = "dGView";
            this.dGView.ReadOnly = true;
            this.dGView.RowTemplate.Height = 21;
            this.dGView.Size = new System.Drawing.Size(596, 169);
            this.dGView.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(385, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 10;
            this.label9.Text = "車検日";
            // 
            // buttonRenewal
            // 
            this.buttonRenewal.Location = new System.Drawing.Point(126, 483);
            this.buttonRenewal.Name = "buttonRenewal";
            this.buttonRenewal.Size = new System.Drawing.Size(75, 23);
            this.buttonRenewal.TabIndex = 12;
            this.buttonRenewal.Text = "保存";
            this.buttonRenewal.UseVisualStyleBackColor = true;
            this.buttonRenewal.Click += new System.EventHandler(this.buttonRenewal_Click);
            // 
            // buttonRequest
            // 
            this.buttonRequest.Location = new System.Drawing.Point(309, 483);
            this.buttonRequest.Name = "buttonRequest";
            this.buttonRequest.Size = new System.Drawing.Size(75, 23);
            this.buttonRequest.TabIndex = 13;
            this.buttonRequest.Text = "申請";
            this.buttonRequest.UseVisualStyleBackColor = true;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(522, 483);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "戻る";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // tBoxNumber
            // 
            this.tBoxNumber.Location = new System.Drawing.Point(272, 12);
            this.tBoxNumber.Name = "tBoxNumber";
            this.tBoxNumber.Size = new System.Drawing.Size(100, 19);
            this.tBoxNumber.TabIndex = 15;
            // 
            // cBoxVClass
            // 
            this.cBoxVClass.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cBoxVClass.FormattingEnabled = true;
            this.cBoxVClass.Location = new System.Drawing.Point(83, 37);
            this.cBoxVClass.Name = "cBoxVClass";
            this.cBoxVClass.Size = new System.Drawing.Size(100, 20);
            this.cBoxVClass.TabIndex = 16;
            this.cBoxVClass.UseWaitCursor = true;
            // 
            // tBoxColor
            // 
            this.tBoxColor.Location = new System.Drawing.Point(272, 38);
            this.tBoxColor.Name = "tBoxColor";
            this.tBoxColor.Size = new System.Drawing.Size(100, 19);
            this.tBoxColor.TabIndex = 17;
            // 
            // tBoxCapacity
            // 
            this.tBoxCapacity.Location = new System.Drawing.Point(272, 63);
            this.tBoxCapacity.Name = "tBoxCapacity";
            this.tBoxCapacity.ReadOnly = true;
            this.tBoxCapacity.Size = new System.Drawing.Size(100, 19);
            this.tBoxCapacity.TabIndex = 18;
            // 
            // tBoxDisplacement
            // 
            this.tBoxDisplacement.Location = new System.Drawing.Point(432, 12);
            this.tBoxDisplacement.Name = "tBoxDisplacement";
            this.tBoxDisplacement.ReadOnly = true;
            this.tBoxDisplacement.Size = new System.Drawing.Size(100, 19);
            this.tBoxDisplacement.TabIndex = 19;
            // 
            // tBoxVInspection
            // 
            this.tBoxVInspection.Location = new System.Drawing.Point(432, 38);
            this.tBoxVInspection.Name = "tBoxVInspection";
            this.tBoxVInspection.Size = new System.Drawing.Size(100, 19);
            this.tBoxVInspection.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Location = new System.Drawing.Point(26, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 22;
            this.label8.Text = "分類番号";
            // 
            // tBoxNumClass
            // 
            this.tBoxNumClass.Location = new System.Drawing.Point(83, 63);
            this.tBoxNumClass.Name = "tBoxNumClass";
            this.tBoxNumClass.Size = new System.Drawing.Size(100, 19);
            this.tBoxNumClass.TabIndex = 23;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(229, 353);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 24;
            this.button5.Text = "前のページ";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(398, 353);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 25;
            this.button6.Text = "次のページ";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 395);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "自動車税は";
            // 
            // labelVTax
            // 
            this.labelVTax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVTax.AutoSize = true;
            this.labelVTax.Location = new System.Drawing.Point(126, 395);
            this.labelVTax.Name = "labelVTax";
            this.labelVTax.Size = new System.Drawing.Size(41, 12);
            this.labelVTax.TabIndex = 27;
            this.labelVTax.Text = "label11";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(184, 394);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 12);
            this.label12.TabIndex = 28;
            this.label12.Text = "円です。";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(53, 433);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 12);
            this.label13.TabIndex = 29;
            this.label13.Text = "今回の燃費は";
            // 
            // labelFuelEfficiency
            // 
            this.labelFuelEfficiency.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelFuelEfficiency.AutoSize = true;
            this.labelFuelEfficiency.Location = new System.Drawing.Point(133, 432);
            this.labelFuelEfficiency.Name = "labelFuelEfficiency";
            this.labelFuelEfficiency.Size = new System.Drawing.Size(41, 12);
            this.labelFuelEfficiency.TabIndex = 30;
            this.labelFuelEfficiency.Text = "label14";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(186, 432);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 12);
            this.label15.TabIndex = 31;
            this.label15.Text = "km/Lです。";
            // 
            // checkBoxUsed
            // 
            this.checkBoxUsed.AutoSize = true;
            this.checkBoxUsed.Location = new System.Drawing.Point(387, 69);
            this.checkBoxUsed.Name = "checkBoxUsed";
            this.checkBoxUsed.Size = new System.Drawing.Size(72, 16);
            this.checkBoxUsed.TabIndex = 32;
            this.checkBoxUsed.Text = "使用状況";
            this.checkBoxUsed.UseVisualStyleBackColor = true;
            // 
            // Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(719, 545);
            this.Controls.Add(this.checkBoxUsed);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.labelFuelEfficiency);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.labelVTax);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.tBoxNumClass);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBoxVInspection);
            this.Controls.Add(this.tBoxDisplacement);
            this.Controls.Add(this.tBoxCapacity);
            this.Controls.Add(this.tBoxColor);
            this.Controls.Add(this.cBoxVClass);
            this.Controls.Add(this.tBoxNumber);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRequest);
            this.Controls.Add(this.buttonRenewal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dGView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBoxDetailCar);
            this.Name = "Detail";
            this.Text = "明細画面";
            this.Load += new System.EventHandler(this.formDetail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxDetailCar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dGView;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button buttonRenewal;
        private System.Windows.Forms.Button buttonRequest;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox tBoxNumber;
        private System.Windows.Forms.ComboBox cBoxVClass;
        private System.Windows.Forms.TextBox tBoxColor;
        private System.Windows.Forms.TextBox tBoxCapacity;
        private System.Windows.Forms.TextBox tBoxDisplacement;
        private System.Windows.Forms.TextBox tBoxVInspection;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tBoxNumClass;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label labelVTax;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelFuelEfficiency;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox checkBoxUsed;
    }
}
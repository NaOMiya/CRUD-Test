namespace Crud.Presentation
{
    partial class FrmRegister
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.tBoxCar = new System.Windows.Forms.TextBox();
            this.tBoxCapacity = new System.Windows.Forms.TextBox();
            this.tBoxNumClass = new System.Windows.Forms.TextBox();
            this.tBoxNumber = new System.Windows.Forms.TextBox();
            this.tBoxColor = new System.Windows.Forms.TextBox();
            this.cBoxCarClass = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tBoxInspection = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tBoxDisplacement = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.tBoxRunTime = new System.Windows.Forms.TextBox();
            this.tBoxRunDistance = new System.Windows.Forms.TextBox();
            this.tBoxFuel = new System.Windows.Forms.TextBox();
            this.tBoxMoney = new System.Windows.Forms.TextBox();
            this.checkBoxUsed = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(388, 235);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(75, 23);
            this.buttonRegister.TabIndex = 0;
            this.buttonRegister.Text = "登録";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(469, 235);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 1;
            this.buttonBack.Text = "戻る";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // tBoxCar
            // 
            this.tBoxCar.Location = new System.Drawing.Point(79, 36);
            this.tBoxCar.Name = "tBoxCar";
            this.tBoxCar.Size = new System.Drawing.Size(100, 19);
            this.tBoxCar.TabIndex = 2;
            // 
            // tBoxCapacity
            // 
            this.tBoxCapacity.Location = new System.Drawing.Point(256, 116);
            this.tBoxCapacity.Name = "tBoxCapacity";
            this.tBoxCapacity.Size = new System.Drawing.Size(100, 19);
            this.tBoxCapacity.TabIndex = 3;
            // 
            // tBoxNumClass
            // 
            this.tBoxNumClass.Location = new System.Drawing.Point(79, 116);
            this.tBoxNumClass.Name = "tBoxNumClass";
            this.tBoxNumClass.Size = new System.Drawing.Size(100, 19);
            this.tBoxNumClass.TabIndex = 4;
            // 
            // tBoxNumber
            // 
            this.tBoxNumber.Location = new System.Drawing.Point(256, 33);
            this.tBoxNumber.Name = "tBoxNumber";
            this.tBoxNumber.Size = new System.Drawing.Size(100, 19);
            this.tBoxNumber.TabIndex = 5;
            // 
            // tBoxColor
            // 
            this.tBoxColor.Location = new System.Drawing.Point(256, 75);
            this.tBoxColor.Name = "tBoxColor";
            this.tBoxColor.Size = new System.Drawing.Size(100, 19);
            this.tBoxColor.TabIndex = 6;
            // 
            // cBoxCarClass
            // 
            this.cBoxCarClass.FormattingEnabled = true;
            this.cBoxCarClass.Items.AddRange(new object[] {
            "普通車",
            "軽自動車"});
            this.cBoxCarClass.Location = new System.Drawing.Point(79, 76);
            this.cBoxCarClass.Name = "cBoxCarClass";
            this.cBoxCarClass.Size = new System.Drawing.Size(100, 20);
            this.cBoxCarClass.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "自動車名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "車種区分";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "分類番号";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "ナンバー";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 12);
            this.label5.TabIndex = 13;
            this.label5.Text = "色";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "定員";
            // 
            // tBoxInspection
            // 
            this.tBoxInspection.Location = new System.Drawing.Point(444, 33);
            this.tBoxInspection.Name = "tBoxInspection";
            this.tBoxInspection.Size = new System.Drawing.Size(100, 19);
            this.tBoxInspection.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Red;
            this.label7.Location = new System.Drawing.Point(386, 36);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "車検日";
            // 
            // tBoxDisplacement
            // 
            this.tBoxDisplacement.Location = new System.Drawing.Point(444, 72);
            this.tBoxDisplacement.Name = "tBoxDisplacement";
            this.tBoxDisplacement.Size = new System.Drawing.Size(100, 19);
            this.tBoxDisplacement.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(386, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 18;
            this.label8.Text = "排気量";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(185, 175);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 19;
            this.label9.Text = "総走行距離";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 20;
            this.label10.Text = "走行日時";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(386, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 21;
            this.label11.Text = "給油量";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(39, 209);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(29, 12);
            this.label12.TabIndex = 22;
            this.label12.Text = "経費";
            // 
            // tBoxRunTime
            // 
            this.tBoxRunTime.Location = new System.Drawing.Point(79, 168);
            this.tBoxRunTime.Name = "tBoxRunTime";
            this.tBoxRunTime.Size = new System.Drawing.Size(100, 19);
            this.tBoxRunTime.TabIndex = 23;
            // 
            // tBoxRunDistance
            // 
            this.tBoxRunDistance.Location = new System.Drawing.Point(256, 168);
            this.tBoxRunDistance.Name = "tBoxRunDistance";
            this.tBoxRunDistance.Size = new System.Drawing.Size(100, 19);
            this.tBoxRunDistance.TabIndex = 24;
            // 
            // tBoxFuel
            // 
            this.tBoxFuel.Location = new System.Drawing.Point(444, 168);
            this.tBoxFuel.Name = "tBoxFuel";
            this.tBoxFuel.Size = new System.Drawing.Size(100, 19);
            this.tBoxFuel.TabIndex = 25;
            // 
            // tBoxMoney
            // 
            this.tBoxMoney.Location = new System.Drawing.Point(79, 201);
            this.tBoxMoney.Name = "tBoxMoney";
            this.tBoxMoney.Size = new System.Drawing.Size(100, 19);
            this.tBoxMoney.TabIndex = 26;
            // 
            // checkBoxUsed
            // 
            this.checkBoxUsed.AutoSize = true;
            this.checkBoxUsed.Location = new System.Drawing.Point(388, 119);
            this.checkBoxUsed.Name = "checkBoxUsed";
            this.checkBoxUsed.Size = new System.Drawing.Size(72, 16);
            this.checkBoxUsed.TabIndex = 27;
            this.checkBoxUsed.Text = "使用状況";
            this.checkBoxUsed.UseVisualStyleBackColor = true;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 271);
            this.Controls.Add(this.checkBoxUsed);
            this.Controls.Add(this.tBoxMoney);
            this.Controls.Add(this.tBoxFuel);
            this.Controls.Add(this.tBoxRunDistance);
            this.Controls.Add(this.tBoxRunTime);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tBoxDisplacement);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tBoxInspection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cBoxCarClass);
            this.Controls.Add(this.tBoxColor);
            this.Controls.Add(this.tBoxNumber);
            this.Controls.Add(this.tBoxNumClass);
            this.Controls.Add(this.tBoxCapacity);
            this.Controls.Add(this.tBoxCar);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonRegister);
            this.Name = "Register";
            this.Text = "登録画面";
            this.Load += new System.EventHandler(this.Register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.TextBox tBoxCar;
        private System.Windows.Forms.TextBox tBoxCapacity;
        private System.Windows.Forms.TextBox tBoxNumClass;
        private System.Windows.Forms.TextBox tBoxNumber;
        private System.Windows.Forms.TextBox tBoxColor;
        private System.Windows.Forms.ComboBox cBoxCarClass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tBoxInspection;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tBoxDisplacement;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tBoxRunTime;
        private System.Windows.Forms.TextBox tBoxRunDistance;
        private System.Windows.Forms.TextBox tBoxFuel;
        private System.Windows.Forms.TextBox tBoxMoney;
        private System.Windows.Forms.CheckBox checkBoxUsed;
    }
}
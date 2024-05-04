namespace Thema28_3_генератор_случайных_чисел
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.tbFrom = new System.Windows.Forms.TextBox();
            this.tbUntil = new System.Windows.Forms.TextBox();
            this.btGenerate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lbRes = new System.Windows.Forms.Label();
            this.cbxTemp = new System.Windows.Forms.ComboBox();
            this.cbxPress = new System.Windows.Forms.ComboBox();
            this.сbxLong = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Случайное число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "От:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(124, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "До:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(6, 75);
            this.tbResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(218, 36);
            this.tbResult.TabIndex = 3;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(6, 169);
            this.tbFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(100, 36);
            this.tbFrom.TabIndex = 4;
            this.tbFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbUntil
            // 
            this.tbUntil.Location = new System.Drawing.Point(124, 169);
            this.tbUntil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUntil.Name = "tbUntil";
            this.tbUntil.Size = new System.Drawing.Size(100, 36);
            this.tbUntil.TabIndex = 5;
            this.tbUntil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(6, 230);
            this.btGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(218, 50);
            this.btGenerate.TabIndex = 6;
            this.btGenerate.Text = "Сгенерировать";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btGenerate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.tbUntil);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbFrom);
            this.groupBox1.Controls.Add(this.tbResult);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 291);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "№ 1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbRes);
            this.groupBox2.Controls.Add(this.cbxTemp);
            this.groupBox2.Controls.Add(this.cbxPress);
            this.groupBox2.Controls.Add(this.сbxLong);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.tbNum);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(269, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(534, 347);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "№ 2";
            // 
            // lbRes
            // 
            this.lbRes.Location = new System.Drawing.Point(6, 207);
            this.lbRes.Name = "lbRes";
            this.lbRes.Size = new System.Drawing.Size(522, 128);
            this.lbRes.TabIndex = 11;
            this.lbRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxTemp
            // 
            this.cbxTemp.FormattingEnabled = true;
            this.cbxTemp.Items.AddRange(new object[] {
            "*К",
            "*F"});
            this.cbxTemp.Location = new System.Drawing.Point(183, 155);
            this.cbxTemp.Name = "cbxTemp";
            this.cbxTemp.Size = new System.Drawing.Size(162, 38);
            this.cbxTemp.TabIndex = 9;
            // 
            // cbxPress
            // 
            this.cbxPress.FormattingEnabled = true;
            this.cbxPress.Items.AddRange(new object[] {
            "мм рт. ст.",
            "бар",
            "атм",
            "кгс"});
            this.cbxPress.Location = new System.Drawing.Point(351, 155);
            this.cbxPress.Name = "cbxPress";
            this.cbxPress.Size = new System.Drawing.Size(177, 38);
            this.cbxPress.TabIndex = 10;
            // 
            // сbxLong
            // 
            this.сbxLong.FormattingEnabled = true;
            this.сbxLong.Items.AddRange(new object[] {
            "см",
            "дм",
            "м",
            "км"});
            this.сbxLong.Location = new System.Drawing.Point(6, 155);
            this.сbxLong.Name = "сbxLong";
            this.сbxLong.Size = new System.Drawing.Size(171, 38);
            this.сbxLong.TabIndex = 5;
            this.сbxLong.SelectedIndexChanged += new System.EventHandler(this.сbxLong_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(351, 119);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 30);
            this.label7.TabIndex = 4;
            this.label7.Text = "Из Па в";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 30);
            this.label6.TabIndex = 3;
            this.label6.Text = "Из *С в";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 30);
            this.label5.TabIndex = 2;
            this.label5.Text = "Из мм в";
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(6, 65);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(522, 36);
            this.tbNum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Введите число:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(842, 371);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Практика 28 (2)";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbResult;
        private TextBox tbFrom;
        private TextBox tbUntil;
        private Button btGenerate;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lbRes;
        private ComboBox cbxTemp;
        private ComboBox cbxPress;
        private ComboBox сbxLong;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox tbNum;
        private Label label4;
    }
}
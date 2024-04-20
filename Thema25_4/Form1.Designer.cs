namespace Thema25_4
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb9x13 = new System.Windows.Forms.TextBox();
            this.tb10x15 = new System.Windows.Forms.TextBox();
            this.tb15x20 = new System.Windows.Forms.TextBox();
            this.rb9x13 = new System.Windows.Forms.RadioButton();
            this.rb10x15 = new System.Windows.Forms.RadioButton();
            this.rb15x20 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCount = new System.Windows.Forms.TextBox();
            this.btOK = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tb9x13);
            this.groupBox1.Controls.Add(this.tb10x15);
            this.groupBox1.Controls.Add(this.tb15x20);
            this.groupBox1.Controls.Add(this.rb9x13);
            this.groupBox1.Controls.Add(this.rb10x15);
            this.groupBox1.Controls.Add(this.rb15x20);
            this.groupBox1.Location = new System.Drawing.Point(17, 18);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(272, 147);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Размеры и цены";
            // 
            // tb9x13
            // 
            this.tb9x13.Enabled = false;
            this.tb9x13.Location = new System.Drawing.Point(102, 102);
            this.tb9x13.Name = "tb9x13";
            this.tb9x13.Size = new System.Drawing.Size(163, 30);
            this.tb9x13.TabIndex = 5;
            this.tb9x13.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb9x13_KeyPress);
            // 
            // tb10x15
            // 
            this.tb10x15.Enabled = false;
            this.tb10x15.Location = new System.Drawing.Point(102, 66);
            this.tb10x15.Name = "tb10x15";
            this.tb10x15.Size = new System.Drawing.Size(163, 30);
            this.tb10x15.TabIndex = 4;
            this.tb10x15.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb10x15_KeyPress);
            // 
            // tb15x20
            // 
            this.tb15x20.Enabled = false;
            this.tb15x20.Location = new System.Drawing.Point(102, 30);
            this.tb15x20.Name = "tb15x20";
            this.tb15x20.Size = new System.Drawing.Size(163, 30);
            this.tb15x20.TabIndex = 3;
            this.tb15x20.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb15x20_KeyPress);
            // 
            // rb9x13
            // 
            this.rb9x13.AutoSize = true;
            this.rb9x13.Location = new System.Drawing.Point(7, 102);
            this.rb9x13.Name = "rb9x13";
            this.rb9x13.Size = new System.Drawing.Size(79, 27);
            this.rb9x13.TabIndex = 2;
            this.rb9x13.TabStop = true;
            this.rb9x13.Text = "9 x 13";
            this.rb9x13.UseVisualStyleBackColor = true;
            this.rb9x13.CheckedChanged += new System.EventHandler(this.rb9x13_CheckedChanged);
            // 
            // rb10x15
            // 
            this.rb10x15.AutoSize = true;
            this.rb10x15.Location = new System.Drawing.Point(7, 66);
            this.rb10x15.Name = "rb10x15";
            this.rb10x15.Size = new System.Drawing.Size(89, 27);
            this.rb10x15.TabIndex = 1;
            this.rb10x15.TabStop = true;
            this.rb10x15.Text = "10 x 15";
            this.rb10x15.UseVisualStyleBackColor = true;
            this.rb10x15.CheckedChanged += new System.EventHandler(this.rb10x15_CheckedChanged);
            // 
            // rb15x20
            // 
            this.rb15x20.AutoSize = true;
            this.rb15x20.Location = new System.Drawing.Point(7, 30);
            this.rb15x20.Name = "rb15x20";
            this.rb15x20.Size = new System.Drawing.Size(89, 27);
            this.rb15x20.TabIndex = 0;
            this.rb15x20.TabStop = true;
            this.rb15x20.Text = "15 x 20";
            this.rb15x20.UseVisualStyleBackColor = true;
            this.rb15x20.CheckedChanged += new System.EventHandler(this.rb15x20_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Количество";
            // 
            // tbCount
            // 
            this.tbCount.Location = new System.Drawing.Point(134, 170);
            this.tbCount.Name = "tbCount";
            this.tbCount.Size = new System.Drawing.Size(148, 30);
            this.tbCount.TabIndex = 2;
            this.tbCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCount_KeyPress);
            // 
            // btOK
            // 
            this.btOK.Location = new System.Drawing.Point(17, 206);
            this.btOK.Name = "btOK";
            this.btOK.Size = new System.Drawing.Size(272, 45);
            this.btOK.TabIndex = 3;
            this.btOK.Text = "Рассчитать";
            this.btOK.UseVisualStyleBackColor = true;
            this.btOK.Click += new System.EventHandler(this.btOK_Click);
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResult.Location = new System.Drawing.Point(17, 257);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(272, 89);
            this.lbResult.TabIndex = 4;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 371);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btOK);
            this.Controls.Add(this.tbCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Фотоателье";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton rb9x13;
        private RadioButton rb10x15;
        private RadioButton rb15x20;
        private TextBox tb9x13;
        private TextBox tb10x15;
        private TextBox tb15x20;
        private Label label1;
        private TextBox tbCount;
        private Button btOK;
        private Label lbResult;
    }
}
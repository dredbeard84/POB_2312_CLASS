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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Случайное число:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "От:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "До:";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 42);
            this.tbResult.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbResult.Name = "tbResult";
            this.tbResult.ReadOnly = true;
            this.tbResult.Size = new System.Drawing.Size(218, 36);
            this.tbResult.TabIndex = 3;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbFrom
            // 
            this.tbFrom.Location = new System.Drawing.Point(12, 136);
            this.tbFrom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbFrom.Name = "tbFrom";
            this.tbFrom.Size = new System.Drawing.Size(100, 36);
            this.tbFrom.TabIndex = 4;
            this.tbFrom.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbUntil
            // 
            this.tbUntil.Location = new System.Drawing.Point(130, 136);
            this.tbUntil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbUntil.Name = "tbUntil";
            this.tbUntil.Size = new System.Drawing.Size(100, 36);
            this.tbUntil.TabIndex = 5;
            this.tbUntil.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btGenerate
            // 
            this.btGenerate.Location = new System.Drawing.Point(12, 197);
            this.btGenerate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btGenerate.Name = "btGenerate";
            this.btGenerate.Size = new System.Drawing.Size(218, 50);
            this.btGenerate.TabIndex = 6;
            this.btGenerate.Text = "Сгенерировать";
            this.btGenerate.UseVisualStyleBackColor = true;
            this.btGenerate.Click += new System.EventHandler(this.btGenerate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 261);
            this.Controls.Add(this.btGenerate);
            this.Controls.Add(this.tbUntil);
            this.Controls.Add(this.tbFrom);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.Text = "Генератор случайных чисел";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox tbResult;
        private TextBox tbFrom;
        private TextBox tbUntil;
        private Button btGenerate;
    }
}
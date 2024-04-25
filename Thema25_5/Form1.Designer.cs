namespace Thema25_5
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.lbxMaterial = new System.Windows.Forms.ListBox();
            this.pbxMaterial = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaterial)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ширина";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Высота";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(110, 7);
            this.textBox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 32);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(110, 62);
            this.textBox2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(154, 32);
            this.textBox2.TabIndex = 3;
            // 
            // lbxMaterial
            // 
            this.lbxMaterial.FormattingEnabled = true;
            this.lbxMaterial.ItemHeight = 25;
            this.lbxMaterial.Items.AddRange(new object[] {
            "Алюминий",
            "Пластик",
            "Дерево",
            "Бамбук"});
            this.lbxMaterial.Location = new System.Drawing.Point(16, 120);
            this.lbxMaterial.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.lbxMaterial.Name = "lbxMaterial";
            this.lbxMaterial.Size = new System.Drawing.Size(248, 254);
            this.lbxMaterial.TabIndex = 4;
            // 
            // pbxMaterial
            // 
            this.pbxMaterial.Location = new System.Drawing.Point(275, 7);
            this.pbxMaterial.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.pbxMaterial.Name = "pbxMaterial";
            this.pbxMaterial.Size = new System.Drawing.Size(403, 368);
            this.pbxMaterial.TabIndex = 5;
            this.pbxMaterial.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 399);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(249, 130);
            this.button1.TabIndex = 6;
            this.button1.Text = "Подсчитать";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // lbResult
            // 
            this.lbResult.Location = new System.Drawing.Point(275, 399);
            this.lbResult.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(403, 130);
            this.lbResult.TabIndex = 7;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 552);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pbxMaterial);
            this.Controls.Add(this.lbxMaterial);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "Form1";
            this.Text = "Жалюзи";
            ((System.ComponentModel.ISupportInitialize)(this.pbxMaterial)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private ListBox lbxMaterial;
        private PictureBox pbxMaterial;
        private Button button1;
        private Label lbResult;
    }
}
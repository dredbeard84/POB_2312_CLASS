namespace Thema25_3
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
            this.lbMark = new System.Windows.Forms.Label();
            this.tbMark = new System.Windows.Forms.TextBox();
            this.chbMark = new System.Windows.Forms.CheckBox();
            this.btMark = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMark
            // 
            this.lbMark.AutoSize = true;
            this.lbMark.Location = new System.Drawing.Point(12, 9);
            this.lbMark.Name = "lbMark";
            this.lbMark.Size = new System.Drawing.Size(46, 19);
            this.lbMark.TabIndex = 0;
            this.lbMark.Text = "мили";
            // 
            // tbMark
            // 
            this.tbMark.Location = new System.Drawing.Point(66, 9);
            this.tbMark.Name = "tbMark";
            this.tbMark.Size = new System.Drawing.Size(263, 27);
            this.tbMark.TabIndex = 1;
            this.tbMark.TextChanged += new System.EventHandler(this.tbMark_TextChanged);
            this.tbMark.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbMark_KeyPress);
            // 
            // chbMark
            // 
            this.chbMark.AutoSize = true;
            this.chbMark.Location = new System.Drawing.Point(66, 39);
            this.chbMark.Name = "chbMark";
            this.chbMark.Size = new System.Drawing.Size(99, 23);
            this.chbMark.TabIndex = 2;
            this.chbMark.Text = "мили / км";
            this.chbMark.UseVisualStyleBackColor = true;
            this.chbMark.CheckedChanged += new System.EventHandler(this.chbMark_CheckedChanged);
            // 
            // btMark
            // 
            this.btMark.Location = new System.Drawing.Point(66, 68);
            this.btMark.Name = "btMark";
            this.btMark.Size = new System.Drawing.Size(100, 40);
            this.btMark.TabIndex = 3;
            this.btMark.Text = "Перевести";
            this.btMark.UseVisualStyleBackColor = true;
            this.btMark.Click += new System.EventHandler(this.btMark_Click);
            // 
            // lbResult
            // 
            this.lbResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbResult.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbResult.Location = new System.Drawing.Point(0, 138);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(600, 177);
            this.lbResult.TabIndex = 4;
            this.lbResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 315);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btMark);
            this.Controls.Add(this.chbMark);
            this.Controls.Add(this.tbMark);
            this.Controls.Add(this.lbMark);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Мили - Километры";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbMark;
        private TextBox tbMark;
        private CheckBox chbMark;
        private Button btMark;
        private Label lbResult;
    }
}
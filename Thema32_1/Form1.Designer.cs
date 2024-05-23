namespace Thema32_1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.buttonChoise = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(776, 465);
            this.treeView1.TabIndex = 0;
            // 
            // buttonChoise
            // 
            this.buttonChoise.Location = new System.Drawing.Point(12, 483);
            this.buttonChoise.Name = "buttonChoise";
            this.buttonChoise.Size = new System.Drawing.Size(776, 57);
            this.buttonChoise.TabIndex = 1;
            this.buttonChoise.Text = "Выбрать";
            this.buttonChoise.UseVisualStyleBackColor = true;
            this.buttonChoise.Click += new System.EventHandler(this.buttonChoise_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 552);
            this.Controls.Add(this.buttonChoise);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Дерево";
            this.ResumeLayout(false);

        }

        #endregion

        private TreeView treeView1;
        private Button buttonChoise;
        private OpenFileDialog openFileDialog1;
    }
}
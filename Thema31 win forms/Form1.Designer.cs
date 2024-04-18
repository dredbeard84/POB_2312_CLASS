namespace Thema31_win_forms
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
            this.lbFirst = new System.Windows.Forms.Label();
            this.tbFirst = new System.Windows.Forms.TextBox();
            this.lbSecond = new System.Windows.Forms.Label();
            this.tbSecond = new System.Windows.Forms.TextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.btSub = new System.Windows.Forms.Button();
            this.btMult = new System.Windows.Forms.Button();
            this.btDiv = new System.Windows.Forms.Button();
            this.lbResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbFirst
            // 
            this.lbFirst.AutoSize = true;
            this.lbFirst.Location = new System.Drawing.Point(12, 9);
            this.lbFirst.Name = "lbFirst";
            this.lbFirst.Size = new System.Drawing.Size(107, 15);
            this.lbFirst.TabIndex = 0;
            this.lbFirst.Text = "Введите 1-е число";
            // 
            // tbFirst
            // 
            this.tbFirst.Location = new System.Drawing.Point(12, 27);
            this.tbFirst.Name = "tbFirst";
            this.tbFirst.Size = new System.Drawing.Size(107, 23);
            this.tbFirst.TabIndex = 1;
            // 
            // lbSecond
            // 
            this.lbSecond.AutoSize = true;
            this.lbSecond.Location = new System.Drawing.Point(12, 66);
            this.lbSecond.Name = "lbSecond";
            this.lbSecond.Size = new System.Drawing.Size(107, 15);
            this.lbSecond.TabIndex = 2;
            this.lbSecond.Text = "Введите 2-е число";
            // 
            // tbSecond
            // 
            this.tbSecond.Location = new System.Drawing.Point(12, 84);
            this.tbSecond.Name = "tbSecond";
            this.tbSecond.Size = new System.Drawing.Size(107, 23);
            this.tbSecond.TabIndex = 3;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(12, 127);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(50, 50);
            this.btAdd.TabIndex = 4;
            this.btAdd.Text = "+";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btSub
            // 
            this.btSub.Location = new System.Drawing.Point(69, 127);
            this.btSub.Name = "btSub";
            this.btSub.Size = new System.Drawing.Size(50, 50);
            this.btSub.TabIndex = 5;
            this.btSub.Text = "-";
            this.btSub.UseVisualStyleBackColor = true;
            this.btSub.Click += new System.EventHandler(this.btSub_Click);
            // 
            // btMult
            // 
            this.btMult.Location = new System.Drawing.Point(12, 183);
            this.btMult.Name = "btMult";
            this.btMult.Size = new System.Drawing.Size(50, 50);
            this.btMult.TabIndex = 6;
            this.btMult.Text = "*";
            this.btMult.UseVisualStyleBackColor = true;
            this.btMult.Click += new System.EventHandler(this.btMult_Click);
            // 
            // btDiv
            // 
            this.btDiv.Location = new System.Drawing.Point(69, 183);
            this.btDiv.Name = "btDiv";
            this.btDiv.Size = new System.Drawing.Size(50, 50);
            this.btDiv.TabIndex = 7;
            this.btDiv.Text = "/";
            this.btDiv.UseVisualStyleBackColor = true;
            this.btDiv.Click += new System.EventHandler(this.btDiv_Click);
            // 
            // lbResult
            // 
            this.lbResult.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbResult.Location = new System.Drawing.Point(144, 27);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(406, 206);
            this.lbResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(592, 455);
            this.Controls.Add(this.lbResult);
            this.Controls.Add(this.btDiv);
            this.Controls.Add(this.btMult);
            this.Controls.Add(this.btSub);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.tbSecond);
            this.Controls.Add(this.lbSecond);
            this.Controls.Add(this.tbFirst);
            this.Controls.Add(this.lbFirst);
            this.Name = "Form1";
            this.Text = "My first programm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbFirst;
        private TextBox tbFirst;
        private Label lbSecond;
        private TextBox tbSecond;
        private Button btAdd;
        private Button btSub;
        private Button btMult;
        private Button btDiv;
        private Label lbResult;
    }
}
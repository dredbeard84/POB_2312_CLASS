namespace Thema28_4_планировщик_задач
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
            this.btEdit = new System.Windows.Forms.Button();
            this.btDel = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbxTask = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpTaskDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxPriority = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxTaskPriority = new System.Windows.Forms.ListBox();
            this.lbxTaskDate = new System.Windows.Forms.ListBox();
            this.lbxTask = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btEdit);
            this.groupBox1.Controls.Add(this.btDel);
            this.groupBox1.Controls.Add(this.btAdd);
            this.groupBox1.Controls.Add(this.tbxTask);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dtpTaskDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lbxPriority);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbxTaskPriority);
            this.groupBox1.Controls.Add(this.lbxTaskDate);
            this.groupBox1.Controls.Add(this.lbxTask);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(841, 458);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Планировщик задач";
            // 
            // btEdit
            // 
            this.btEdit.Location = new System.Drawing.Point(625, 378);
            this.btEdit.Name = "btEdit";
            this.btEdit.Size = new System.Drawing.Size(200, 60);
            this.btEdit.TabIndex = 14;
            this.btEdit.Text = "Перезаписать";
            this.btEdit.UseVisualStyleBackColor = true;
            this.btEdit.Click += new System.EventHandler(this.btEdit_Click);
            // 
            // btDel
            // 
            this.btDel.Location = new System.Drawing.Point(625, 312);
            this.btDel.Name = "btDel";
            this.btDel.Size = new System.Drawing.Size(200, 60);
            this.btDel.TabIndex = 13;
            this.btDel.Text = "Удалить";
            this.btDel.UseVisualStyleBackColor = true;
            this.btDel.Click += new System.EventHandler(this.btDel_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(625, 246);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(200, 60);
            this.btAdd.TabIndex = 12;
            this.btAdd.Text = "Добавить";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // tbxTask
            // 
            this.tbxTask.Location = new System.Drawing.Point(7, 409);
            this.tbxTask.Name = "tbxTask";
            this.tbxTask.Size = new System.Drawing.Size(612, 29);
            this.tbxTask.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(166, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Укажите текст задачи";
            // 
            // dtpTaskDate
            // 
            this.dtpTaskDate.Location = new System.Drawing.Point(625, 199);
            this.dtpTaskDate.Name = "dtpTaskDate";
            this.dtpTaskDate.Size = new System.Drawing.Size(200, 29);
            this.dtpTaskDate.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(625, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "Укажите дату и время";
            // 
            // lbxPriority
            // 
            this.lbxPriority.FormattingEnabled = true;
            this.lbxPriority.ItemHeight = 21;
            this.lbxPriority.Items.AddRange(new object[] {
            "низкий",
            "средний",
            "высокий"});
            this.lbxPriority.Location = new System.Drawing.Point(625, 69);
            this.lbxPriority.Name = "lbxPriority";
            this.lbxPriority.Size = new System.Drawing.Size(200, 88);
            this.lbxPriority.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(625, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Укажите приоритет";
            // 
            // lbxTaskPriority
            // 
            this.lbxTaskPriority.FormattingEnabled = true;
            this.lbxTaskPriority.ItemHeight = 21;
            this.lbxTaskPriority.Location = new System.Drawing.Point(419, 69);
            this.lbxTaskPriority.Name = "lbxTaskPriority";
            this.lbxTaskPriority.Size = new System.Drawing.Size(200, 298);
            this.lbxTaskPriority.TabIndex = 5;
            // 
            // lbxTaskDate
            // 
            this.lbxTaskDate.FormattingEnabled = true;
            this.lbxTaskDate.ItemHeight = 21;
            this.lbxTaskDate.Location = new System.Drawing.Point(213, 69);
            this.lbxTaskDate.Name = "lbxTaskDate";
            this.lbxTaskDate.Size = new System.Drawing.Size(200, 298);
            this.lbxTaskDate.TabIndex = 4;
            // 
            // lbxTask
            // 
            this.lbxTask.FormattingEnabled = true;
            this.lbxTask.ItemHeight = 21;
            this.lbxTask.Location = new System.Drawing.Point(7, 69);
            this.lbxTask.Name = "lbxTask";
            this.lbxTask.Size = new System.Drawing.Size(200, 298);
            this.lbxTask.TabIndex = 3;
            this.lbxTask.SelectedIndexChanged += new System.EventHandler(this.lbxTask_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Приоритет";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата и время";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Задача";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 487);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Урок 36";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btEdit;
        private Button btDel;
        private Button btAdd;
        private TextBox tbxTask;
        private Label label6;
        private DateTimePicker dtpTaskDate;
        private Label label5;
        private ListBox lbxPriority;
        private Label label4;
        private ListBox lbxTaskPriority;
        private ListBox lbxTaskDate;
        private ListBox lbxTask;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
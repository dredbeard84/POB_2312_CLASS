namespace Thema31_2
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
            this.components = new System.ComponentModel.Container();
            this.listBoxTitle = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listBoxAuthor = new System.Windows.Forms.ListBox();
            this.listBoxYear = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TextBoxTitle = new System.Windows.Forms.TextBox();
            this.textBoxAuthor = new System.Windows.Forms.TextBox();
            this.textBoxYear = new System.Windows.Forms.TextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonList = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCountBook = new System.Windows.Forms.ToolStripStatusLabel();
            this.TextBoxFiltr = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxTitle
            // 
            this.listBoxTitle.ContextMenuStrip = this.contextMenuStrip1;
            this.listBoxTitle.FormattingEnabled = true;
            this.listBoxTitle.ItemHeight = 21;
            this.listBoxTitle.Location = new System.Drawing.Point(12, 54);
            this.listBoxTitle.Name = "listBoxTitle";
            this.listBoxTitle.Size = new System.Drawing.Size(200, 256);
            this.listBoxTitle.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.удалитьToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            this.удалитьToolStripMenuItem.Click += new System.EventHandler(this.удалитьToolStripMenuItem_Click);
            // 
            // listBoxAuthor
            // 
            this.listBoxAuthor.FormattingEnabled = true;
            this.listBoxAuthor.ItemHeight = 21;
            this.listBoxAuthor.Location = new System.Drawing.Point(218, 54);
            this.listBoxAuthor.Name = "listBoxAuthor";
            this.listBoxAuthor.Size = new System.Drawing.Size(200, 256);
            this.listBoxAuthor.TabIndex = 1;
            // 
            // listBoxYear
            // 
            this.listBoxYear.FormattingEnabled = true;
            this.listBoxYear.ItemHeight = 21;
            this.listBoxYear.Location = new System.Drawing.Point(424, 54);
            this.listBoxYear.Name = "listBoxYear";
            this.listBoxYear.Size = new System.Drawing.Size(200, 256);
            this.listBoxYear.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(630, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(630, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 21);
            this.label2.TabIndex = 4;
            this.label2.Text = "Автор";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(630, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 21);
            this.label3.TabIndex = 5;
            this.label3.Text = "Год издания";
            // 
            // TextBoxTitle
            // 
            this.TextBoxTitle.Location = new System.Drawing.Point(630, 33);
            this.TextBoxTitle.Name = "TextBoxTitle";
            this.TextBoxTitle.Size = new System.Drawing.Size(200, 29);
            this.TextBoxTitle.TabIndex = 6;
            // 
            // textBoxAuthor
            // 
            this.textBoxAuthor.Location = new System.Drawing.Point(630, 89);
            this.textBoxAuthor.Name = "textBoxAuthor";
            this.textBoxAuthor.Size = new System.Drawing.Size(200, 29);
            this.textBoxAuthor.TabIndex = 7;
            // 
            // textBoxYear
            // 
            this.textBoxYear.Location = new System.Drawing.Point(630, 145);
            this.textBoxYear.Name = "textBoxYear";
            this.textBoxYear.Size = new System.Drawing.Size(200, 29);
            this.textBoxYear.TabIndex = 8;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(680, 204);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(150, 50);
            this.buttonAdd.TabIndex = 9;
            this.buttonAdd.Text = "Добавить книгу";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(680, 260);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(150, 50);
            this.buttonList.TabIndex = 10;
            this.buttonList.Text = "Выгрузить список";
            this.buttonList.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelCountBook});
            this.statusStrip1.Location = new System.Drawing.Point(0, 320);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(839, 22);
            this.statusStrip1.TabIndex = 11;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabelCountBook
            // 
            this.toolStripStatusLabelCountBook.Name = "toolStripStatusLabelCountBook";
            this.toolStripStatusLabelCountBook.Size = new System.Drawing.Size(103, 17);
            this.toolStripStatusLabelCountBook.Text = "Количество книг:";
            // 
            // TextBoxFiltr
            // 
            this.TextBoxFiltr.Location = new System.Drawing.Point(12, 12);
            this.TextBoxFiltr.Name = "TextBoxFiltr";
            this.TextBoxFiltr.Size = new System.Drawing.Size(612, 29);
            this.TextBoxFiltr.TabIndex = 12;
            this.TextBoxFiltr.TextChanged += new System.EventHandler(this.TextBoxFiltr_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 342);
            this.Controls.Add(this.TextBoxFiltr);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxYear);
            this.Controls.Add(this.textBoxAuthor);
            this.Controls.Add(this.TextBoxTitle);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxYear);
            this.Controls.Add(this.listBoxAuthor);
            this.Controls.Add(this.listBoxTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учёт библиотечных книг";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBoxTitle;
        private ListBox listBoxAuthor;
        private ListBox listBoxYear;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox TextBoxTitle;
        private TextBox textBoxAuthor;
        private TextBox textBoxYear;
        private Button buttonAdd;
        private Button buttonList;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabelCountBook;
        private TextBox TextBoxFiltr;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
    }
}
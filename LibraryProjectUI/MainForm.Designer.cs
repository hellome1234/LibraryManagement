namespace LibraryProjectUI
{
    partial class MainForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnIssueBook = new System.Windows.Forms.Button();
            this.btnManageCards = new System.Windows.Forms.Button();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.btnManageStudent = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.picClose = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.manageStudent1 = new LibraryProjectUI.ManageStudent();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(40)))));
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.SidePanel);
            this.panel1.Controls.Add(this.btnReturnBook);
            this.panel1.Controls.Add(this.btnIssueBook);
            this.panel1.Controls.Add(this.btnManageCards);
            this.panel1.Controls.Add(this.btnManageBooks);
            this.panel1.Controls.Add(this.btnManageStudent);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 560);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::LibraryProjectUI.Properties.Resources.settings_24px;
            this.pictureBox5.Location = new System.Drawing.Point(41, 524);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(24, 24);
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::LibraryProjectUI.Properties.Resources.logout_rounded_up_filled_24px;
            this.pictureBox4.Location = new System.Drawing.Point(11, 524);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(24, 24);
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.SidePanel.Location = new System.Drawing.Point(0, 136);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 48);
            this.SidePanel.TabIndex = 3;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.FlatAppearance.BorderSize = 0;
            this.btnReturnBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReturnBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturnBook.ForeColor = System.Drawing.Color.White;
            this.btnReturnBook.Image = global::LibraryProjectUI.Properties.Resources.left3_filled_24px;
            this.btnReturnBook.Location = new System.Drawing.Point(15, 356);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(215, 48);
            this.btnReturnBook.TabIndex = 9;
            this.btnReturnBook.Text = "  Return Book";
            this.btnReturnBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.BtnReturnBook_Click);
            // 
            // btnIssueBook
            // 
            this.btnIssueBook.FlatAppearance.BorderSize = 0;
            this.btnIssueBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIssueBook.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIssueBook.ForeColor = System.Drawing.Color.White;
            this.btnIssueBook.Image = global::LibraryProjectUI.Properties.Resources.reading_ebook_24px;
            this.btnIssueBook.Location = new System.Drawing.Point(15, 301);
            this.btnIssueBook.Name = "btnIssueBook";
            this.btnIssueBook.Size = new System.Drawing.Size(215, 48);
            this.btnIssueBook.TabIndex = 8;
            this.btnIssueBook.Text = "  Issue Book";
            this.btnIssueBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnIssueBook.UseVisualStyleBackColor = true;
            this.btnIssueBook.Click += new System.EventHandler(this.BtnIssueBook_Click);
            // 
            // btnManageCards
            // 
            this.btnManageCards.FlatAppearance.BorderSize = 0;
            this.btnManageCards.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageCards.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageCards.ForeColor = System.Drawing.Color.White;
            this.btnManageCards.Image = global::LibraryProjectUI.Properties.Resources.card_in_use_24px;
            this.btnManageCards.Location = new System.Drawing.Point(15, 246);
            this.btnManageCards.Name = "btnManageCards";
            this.btnManageCards.Size = new System.Drawing.Size(215, 48);
            this.btnManageCards.TabIndex = 7;
            this.btnManageCards.Text = "  Manage Cards ";
            this.btnManageCards.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageCards.UseVisualStyleBackColor = true;
            this.btnManageCards.Click += new System.EventHandler(this.BtnManageCards_Click);
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.FlatAppearance.BorderSize = 0;
            this.btnManageBooks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageBooks.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageBooks.ForeColor = System.Drawing.Color.White;
            this.btnManageBooks.Image = global::LibraryProjectUI.Properties.Resources.books_24px;
            this.btnManageBooks.Location = new System.Drawing.Point(15, 191);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(215, 48);
            this.btnManageBooks.TabIndex = 6;
            this.btnManageBooks.Text = "  Manage Books";
            this.btnManageBooks.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageBooks.UseVisualStyleBackColor = true;
            this.btnManageBooks.Click += new System.EventHandler(this.BtnManageBooks_Click);
            // 
            // btnManageStudent
            // 
            this.btnManageStudent.FlatAppearance.BorderSize = 0;
            this.btnManageStudent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageStudent.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageStudent.ForeColor = System.Drawing.Color.White;
            this.btnManageStudent.Image = global::LibraryProjectUI.Properties.Resources.student_24px;
            this.btnManageStudent.Location = new System.Drawing.Point(15, 136);
            this.btnManageStudent.Name = "btnManageStudent";
            this.btnManageStudent.Size = new System.Drawing.Size(215, 48);
            this.btnManageStudent.TabIndex = 5;
            this.btnManageStudent.Text = "  Manage student";
            this.btnManageStudent.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnManageStudent.UseVisualStyleBackColor = true;
            this.btnManageStudent.Click += new System.EventHandler(this.BtnManageStudent_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::LibraryProjectUI.Properties.Resources.list_24px;
            this.pictureBox2.Location = new System.Drawing.Point(196, 16);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 35);
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LibraryProjectUI.Properties.Resources.book;
            this.pictureBox1.Location = new System.Drawing.Point(12, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.picClose);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1200, 40);
            this.panel2.TabIndex = 2;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::LibraryProjectUI.Properties.Resources.minimize_window_25px;
            this.pictureBox6.Location = new System.Drawing.Point(1123, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(34, 35);
            this.pictureBox6.TabIndex = 6;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.PictureBox6_Click);
            // 
            // picClose
            // 
            this.picClose.Image = global::LibraryProjectUI.Properties.Resources.delete_sign_24px;
            this.picClose.Location = new System.Drawing.Point(1163, 5);
            this.picClose.Name = "picClose";
            this.picClose.Size = new System.Drawing.Size(34, 35);
            this.picClose.TabIndex = 5;
            this.picClose.TabStop = false;
            this.picClose.Click += new System.EventHandler(this.PicClose_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::LibraryProjectUI.Properties.Resources.book_24px;
            this.pictureBox3.Location = new System.Drawing.Point(15, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(216)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(41, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Library Management";
            // 
            // manageStudent1
            // 
            this.manageStudent1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.manageStudent1.Location = new System.Drawing.Point(236, 43);
            this.manageStudent1.Name = "manageStudent1";
            this.manageStudent1.Size = new System.Drawing.Size(958, 548);
            this.manageStudent1.TabIndex = 3;
            this.manageStudent1.Load += new System.EventHandler(this.ManageStudent1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(1200, 600);
            this.Controls.Add(this.manageStudent1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox picClose;
        private System.Windows.Forms.Button btnManageStudent;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnIssueBook;
        private System.Windows.Forms.Button btnManageCards;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private ManageStudent manageStudent1;
    }
}
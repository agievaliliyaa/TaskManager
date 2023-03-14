namespace TaskManager
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listBoxTasks = new System.Windows.Forms.ListBox();
            this.TodayBtn = new System.Windows.Forms.Button();
            this.GeneralBtn = new System.Windows.Forms.Button();
            this.PersonalBtn = new System.Windows.Forms.Button();
            this.UpcomingBtn = new System.Windows.Forms.Button();
            this.ArchiveBtn = new System.Windows.Forms.Button();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.homeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.photoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.labelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AccountPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // listBoxTasks
            // 
            this.listBoxTasks.BackColor = System.Drawing.Color.Violet;
            this.listBoxTasks.FormattingEnabled = true;
            this.listBoxTasks.ItemHeight = 20;
            this.listBoxTasks.Location = new System.Drawing.Point(309, 72);
            this.listBoxTasks.Name = "listBoxTasks";
            this.listBoxTasks.Size = new System.Drawing.Size(670, 524);
            this.listBoxTasks.TabIndex = 1;
            // 
            // TodayBtn
            // 
            this.TodayBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TodayBtn.Location = new System.Drawing.Point(12, 91);
            this.TodayBtn.Name = "TodayBtn";
            this.TodayBtn.Size = new System.Drawing.Size(270, 31);
            this.TodayBtn.TabIndex = 2;
            this.TodayBtn.Text = "Сегодня";
            this.TodayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TodayBtn.UseVisualStyleBackColor = true;
            // 
            // GeneralBtn
            // 
            this.GeneralBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GeneralBtn.Location = new System.Drawing.Point(95, 128);
            this.GeneralBtn.Name = "GeneralBtn";
            this.GeneralBtn.Size = new System.Drawing.Size(187, 31);
            this.GeneralBtn.TabIndex = 3;
            this.GeneralBtn.Text = "Общие";
            this.GeneralBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GeneralBtn.UseVisualStyleBackColor = true;
            this.GeneralBtn.Click += new System.EventHandler(this.GeneralBtn_Click);
            // 
            // PersonalBtn
            // 
            this.PersonalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PersonalBtn.Location = new System.Drawing.Point(95, 165);
            this.PersonalBtn.Name = "PersonalBtn";
            this.PersonalBtn.Size = new System.Drawing.Size(187, 31);
            this.PersonalBtn.TabIndex = 4;
            this.PersonalBtn.Text = "Личные";
            this.PersonalBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PersonalBtn.UseVisualStyleBackColor = true;
            // 
            // UpcomingBtn
            // 
            this.UpcomingBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UpcomingBtn.Location = new System.Drawing.Point(12, 217);
            this.UpcomingBtn.Name = "UpcomingBtn";
            this.UpcomingBtn.Size = new System.Drawing.Size(270, 31);
            this.UpcomingBtn.TabIndex = 5;
            this.UpcomingBtn.Text = "Предстоящие";
            this.UpcomingBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UpcomingBtn.UseVisualStyleBackColor = true;
            // 
            // ArchiveBtn
            // 
            this.ArchiveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ArchiveBtn.Location = new System.Drawing.Point(12, 265);
            this.ArchiveBtn.Name = "ArchiveBtn";
            this.ArchiveBtn.Size = new System.Drawing.Size(270, 31);
            this.ArchiveBtn.TabIndex = 6;
            this.ArchiveBtn.Text = "Архив";
            this.ArchiveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ArchiveBtn.UseVisualStyleBackColor = true;
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.AutoSize = false;
            this.menuToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("menuToolStripMenuItem.Image")));
            this.menuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(65, 65);
            // 
            // homeToolStripMenuItem
            // 
            this.homeToolStripMenuItem.AutoSize = false;
            this.homeToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.homeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("homeToolStripMenuItem.Image")));
            this.homeToolStripMenuItem.Name = "homeToolStripMenuItem";
            this.homeToolStripMenuItem.Size = new System.Drawing.Size(65, 65);
            // 
            // plusToolStripMenuItem
            // 
            this.plusToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.plusToolStripMenuItem.AutoSize = false;
            this.plusToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("plusToolStripMenuItem.Image")));
            this.plusToolStripMenuItem.Name = "plusToolStripMenuItem";
            this.plusToolStripMenuItem.Size = new System.Drawing.Size(65, 65);
            // 
            // doneToolStripMenuItem
            // 
            this.doneToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.doneToolStripMenuItem.AutoSize = false;
            this.doneToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("doneToolStripMenuItem.Image")));
            this.doneToolStripMenuItem.Name = "doneToolStripMenuItem";
            this.doneToolStripMenuItem.Size = new System.Drawing.Size(65, 65);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.RosyBrown;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem,
            this.homeToolStripMenuItem,
            this.photoToolStripMenuItem,
            this.labelToolStripMenuItem,
            this.plusToolStripMenuItem,
            this.doneToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(979, 69);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // photoToolStripMenuItem
            // 
            this.photoToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.photoToolStripMenuItem.AutoSize = false;
            this.photoToolStripMenuItem.Name = "photoToolStripMenuItem";
            this.photoToolStripMenuItem.Size = new System.Drawing.Size(65, 65);
            this.photoToolStripMenuItem.Text = "p";
            // 
            // labelToolStripMenuItem
            // 
            this.labelToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.labelToolStripMenuItem.AutoSize = false;
            this.labelToolStripMenuItem.Name = "labelToolStripMenuItem";
            this.labelToolStripMenuItem.Size = new System.Drawing.Size(65, 63);
            this.labelToolStripMenuItem.Text = "la";
            // 
            // AccountPicture
            // 
            this.AccountPicture.Location = new System.Drawing.Point(917, 5);
            this.AccountPicture.Name = "AccountPicture";
            this.AccountPicture.Size = new System.Drawing.Size(62, 60);
            this.AccountPicture.TabIndex = 7;
            this.AccountPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(845, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 60);
            this.label1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(979, 597);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AccountPicture);
            this.Controls.Add(this.ArchiveBtn);
            this.Controls.Add(this.UpcomingBtn);
            this.Controls.Add(this.PersonalBtn);
            this.Controls.Add(this.GeneralBtn);
            this.Controls.Add(this.TodayBtn);
            this.Controls.Add(this.listBoxTasks);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "MainForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AccountPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxTasks;
        private System.Windows.Forms.Button TodayBtn;
        private System.Windows.Forms.Button GeneralBtn;
        private System.Windows.Forms.Button PersonalBtn;
        private System.Windows.Forms.Button UpcomingBtn;
        private System.Windows.Forms.Button ArchiveBtn;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem homeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doneToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem photoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem labelToolStripMenuItem;
        private System.Windows.Forms.PictureBox AccountPicture;
        private System.Windows.Forms.Label label1;
    }
}


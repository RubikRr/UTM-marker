namespace UTM_marker
{
    partial class Links
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
            this.CreateCourse = new System.Windows.Forms.Button();
            this.SitesList = new System.Windows.Forms.ListBox();
            this.WebsitesWithURL = new System.Windows.Forms.TableLayoutPanel();
            this.listboxContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.SuspendLayout();
            // 
            // CreateCourse
            // 
            this.CreateCourse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateCourse.Location = new System.Drawing.Point(498, 489);
            this.CreateCourse.Name = "CreateCourse";
            this.CreateCourse.Size = new System.Drawing.Size(151, 44);
            this.CreateCourse.TabIndex = 0;
            this.CreateCourse.Text = "Создать ссылки";
            this.CreateCourse.UseVisualStyleBackColor = true;
            this.CreateCourse.Click += new System.EventHandler(this.CreateCourse_Click);
            // 
            // SitesList
            // 
            this.SitesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.SitesList.BackColor = System.Drawing.SystemColors.Control;
            this.SitesList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SitesList.FormattingEnabled = true;
            this.SitesList.HorizontalScrollbar = true;
            this.SitesList.ItemHeight = 21;
            this.SitesList.Location = new System.Drawing.Point(12, 30);
            this.SitesList.Name = "SitesList";
            this.SitesList.Size = new System.Drawing.Size(260, 466);
            this.SitesList.TabIndex = 1;
            this.SitesList.SelectedIndexChanged += new System.EventHandler(this.SitesList_SelectedIndexChanged);
            // 
            // WebsitesWithURL
            // 
            this.WebsitesWithURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebsitesWithURL.ColumnCount = 3;
            this.WebsitesWithURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.WebsitesWithURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WebsitesWithURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.WebsitesWithURL.Location = new System.Drawing.Point(278, 30);
            this.WebsitesWithURL.Name = "WebsitesWithURL";
            this.WebsitesWithURL.RowCount = 1;
            this.WebsitesWithURL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WebsitesWithURL.Size = new System.Drawing.Size(694, 453);
            this.WebsitesWithURL.TabIndex = 2;
            // 
            // listboxContextMenu
            // 
            this.listboxContextMenu.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.listboxContextMenu.Name = "listboxContextMenu";
            this.listboxContextMenu.Size = new System.Drawing.Size(61, 4);
            this.listboxContextMenu.Text = "listboxContextMenu";
            // 
            // menuStrip
            // 
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(984, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip1";
            // 
            // Links
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 545);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.WebsitesWithURL);
            this.Controls.Add(this.SitesList);
            this.Controls.Add(this.CreateCourse);
            this.MainMenuStrip = this.menuStrip;
            this.MinimumSize = new System.Drawing.Size(1000, 530);
            this.Name = "Links";
            this.Text = "Ссылки";
            this.Load += new System.EventHandler(this.Courses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CreateCourse;
        private System.Windows.Forms.ListBox SitesList;
        private System.Windows.Forms.TableLayoutPanel WebsitesWithURL;
        private System.Windows.Forms.ContextMenuStrip listboxContextMenu;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}

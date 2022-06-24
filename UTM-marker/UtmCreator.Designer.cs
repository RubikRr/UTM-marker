namespace UTM_marker
{
    partial class UtmCreator
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
            this.LinkLabel = new System.Windows.Forms.Label();
            this.Link = new System.Windows.Forms.TextBox();
            this.Site = new System.Windows.Forms.TextBox();
            this.CreateUtmLinks = new System.Windows.Forms.Button();
            this.SiteLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinkLabel.Location = new System.Drawing.Point(3, 191);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(239, 30);
            this.LinkLabel.TabIndex = 3;
            this.LinkLabel.Text = "Адрес вашей страницы";
            // 
            // Link
            // 
            this.Link.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Link.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Link.Location = new System.Drawing.Point(3, 249);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(670, 35);
            this.Link.TabIndex = 1;
            // 
            // Site
            // 
            this.Site.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Site.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Site.Location = new System.Drawing.Point(3, 127);
            this.Site.Name = "Site";
            this.Site.Size = new System.Drawing.Size(670, 35);
            this.Site.TabIndex = 0;
            // 
            // CreateUtmLinks
            // 
            this.CreateUtmLinks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateUtmLinks.Location = new System.Drawing.Point(257, 329);
            this.CreateUtmLinks.MaximumSize = new System.Drawing.Size(150, 40);
            this.CreateUtmLinks.Name = "CreateUtmLinks";
            this.CreateUtmLinks.Size = new System.Drawing.Size(150, 40);
            this.CreateUtmLinks.TabIndex = 4;
            this.CreateUtmLinks.Text = "Создать";
            this.CreateUtmLinks.UseVisualStyleBackColor = true;
            this.CreateUtmLinks.Click += new System.EventHandler(this.CreateUtmLinks_Click);
            // 
            // SiteLabel
            // 
            this.SiteLabel.AutoSize = true;
            this.SiteLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SiteLabel.Location = new System.Drawing.Point(3, 68);
            this.SiteLabel.Name = "SiteLabel";
            this.SiteLabel.Size = new System.Drawing.Size(164, 30);
            this.SiteLabel.TabIndex = 2;
            this.SiteLabel.Text = "Название сайта";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Site);
            this.panel1.Controls.Add(this.SiteLabel);
            this.panel1.Controls.Add(this.LinkLabel);
            this.panel1.Controls.Add(this.CreateUtmLinks);
            this.panel1.Controls.Add(this.Link);
            this.panel1.Location = new System.Drawing.Point(12, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 420);
            this.panel1.TabIndex = 5;
            // 
            // UtmCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 436);
            this.Controls.Add(this.panel1);
            this.MinimumSize = new System.Drawing.Size(730, 475);
            this.Name = "UtmCreator";
            this.Text = "Utm";
            this.Load += new System.EventHandler(this.UtmCreator_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.TextBox Link;
        private System.Windows.Forms.TextBox Site;
        private System.Windows.Forms.Button CreateUtmLinks;
        private System.Windows.Forms.Label SiteLabel;
        private System.Windows.Forms.Panel panel1;
    }
}
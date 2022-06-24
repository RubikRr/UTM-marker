namespace UTM_marker
{
    partial class ShortLinkCreator
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
            this.Link = new System.Windows.Forms.TextBox();
            this.SiteLinkLabel = new System.Windows.Forms.Label();
            this.ShortSiteLinkLabel = new System.Windows.Forms.Label();
            this.CreateUtmLinks = new System.Windows.Forms.Button();
            this.ShortLink = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Link
            // 
            this.Link.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Link.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Link.Location = new System.Drawing.Point(22, 127);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(670, 35);
            this.Link.TabIndex = 5;
            // 
            // SiteLinkLabel
            // 
            this.SiteLinkLabel.AutoSize = true;
            this.SiteLinkLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SiteLinkLabel.Location = new System.Drawing.Point(22, 68);
            this.SiteLinkLabel.Name = "SiteLinkLabel";
            this.SiteLinkLabel.Size = new System.Drawing.Size(239, 30);
            this.SiteLinkLabel.TabIndex = 7;
            this.SiteLinkLabel.Text = "Адрес вашей страницы";
            // 
            // ShortSiteLinkLabel
            // 
            this.ShortSiteLinkLabel.AutoSize = true;
            this.ShortSiteLinkLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShortSiteLinkLabel.Location = new System.Drawing.Point(22, 191);
            this.ShortSiteLinkLabel.Name = "ShortSiteLinkLabel";
            this.ShortSiteLinkLabel.Size = new System.Drawing.Size(374, 30);
            this.ShortSiteLinkLabel.TabIndex = 8;
            this.ShortSiteLinkLabel.Text = "Укороченный адрес вашей страницы";
            // 
            // CreateUtmLinks
            // 
            this.CreateUtmLinks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateUtmLinks.Location = new System.Drawing.Point(276, 329);
            this.CreateUtmLinks.MaximumSize = new System.Drawing.Size(150, 40);
            this.CreateUtmLinks.Name = "CreateUtmLinks";
            this.CreateUtmLinks.Size = new System.Drawing.Size(150, 40);
            this.CreateUtmLinks.TabIndex = 9;
            this.CreateUtmLinks.Text = "Create";
            this.CreateUtmLinks.UseVisualStyleBackColor = true;
            this.CreateUtmLinks.Click += new System.EventHandler(this.CreateUtmLinks_Click);
            // 
            // ShortLink
            // 
            this.ShortLink.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShortLink.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ShortLink.Location = new System.Drawing.Point(22, 249);
            this.ShortLink.Name = "ShortLink";
            this.ShortLink.Size = new System.Drawing.Size(670, 35);
            this.ShortLink.TabIndex = 6;
            // 
            // ShortLinkCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 436);
            this.Controls.Add(this.Link);
            this.Controls.Add(this.SiteLinkLabel);
            this.Controls.Add(this.ShortSiteLinkLabel);
            this.Controls.Add(this.CreateUtmLinks);
            this.Controls.Add(this.ShortLink);
            this.MinimumSize = new System.Drawing.Size(730, 475);
            this.Name = "ShortLinkCreator";
            this.Text = "Short link creator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Link;
        private System.Windows.Forms.Label SiteLinkLabel;
        private System.Windows.Forms.Label ShortSiteLinkLabel;
        private System.Windows.Forms.Button CreateUtmLinks;
        private System.Windows.Forms.TextBox ShortLink;
    }
}
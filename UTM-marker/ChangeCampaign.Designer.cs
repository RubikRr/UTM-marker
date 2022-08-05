namespace UTM_marker
{
    partial class ChangeCampaign
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
            this.Change = new System.Windows.Forms.Button();
            this.Campaign = new System.Windows.Forms.TextBox();
            this.ChangeCampaignLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Change
            // 
            this.Change.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.Change.Location = new System.Drawing.Point(263, 329);
            this.Change.Name = "Change";
            this.Change.Size = new System.Drawing.Size(150, 40);
            this.Change.TabIndex = 0;
            this.Change.Text = "Изменить";
            this.Change.UseVisualStyleBackColor = true;
            this.Change.Click += new System.EventHandler(this.Change_Click);
            // 
            // Campaign
            // 
            this.Campaign.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Campaign.Location = new System.Drawing.Point(12, 193);
            this.Campaign.Name = "Campaign";
            this.Campaign.Size = new System.Drawing.Size(690, 35);
            this.Campaign.TabIndex = 1;
            // 
            // ChangeCampaignLabel
            // 
            this.ChangeCampaignLabel.AutoSize = true;
            this.ChangeCampaignLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ChangeCampaignLabel.Location = new System.Drawing.Point(12, 117);
            this.ChangeCampaignLabel.Name = "ChangeCampaignLabel";
            this.ChangeCampaignLabel.Size = new System.Drawing.Size(214, 30);
            this.ChangeCampaignLabel.TabIndex = 2;
            this.ChangeCampaignLabel.Text = "Изменить кампанию";
            // 
            // ChangeCampaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 436);
            this.Controls.Add(this.ChangeCampaignLabel);
            this.Controls.Add(this.Campaign);
            this.Controls.Add(this.Change);
            this.MinimumSize = new System.Drawing.Size(730, 475);
            this.Name = "ChangeCampaign";
            this.Text = "ChangeCampaign";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Change;
        private System.Windows.Forms.TextBox Campaign;
        private System.Windows.Forms.Label ChangeCampaignLabel;
    }
}
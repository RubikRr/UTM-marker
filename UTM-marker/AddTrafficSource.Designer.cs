namespace UTM_marker
{
    partial class AddTrafficSource
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
            this.SourceLabel = new System.Windows.Forms.Label();
            this.MediumLabel = new System.Windows.Forms.Label();
            this.AddSource = new System.Windows.Forms.Button();
            this.Source = new System.Windows.Forms.TextBox();
            this.Medium = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SourceLabel
            // 
            this.SourceLabel.AutoSize = true;
            this.SourceLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SourceLabel.Location = new System.Drawing.Point(3, 68);
            this.SourceLabel.Name = "SourceLabel";
            this.SourceLabel.Size = new System.Drawing.Size(208, 30);
            this.SourceLabel.TabIndex = 0;
            this.SourceLabel.Text = "Источник компании";
            // 
            // MediumLabel
            // 
            this.MediumLabel.AutoSize = true;
            this.MediumLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MediumLabel.Location = new System.Drawing.Point(3, 191);
            this.MediumLabel.Name = "MediumLabel";
            this.MediumLabel.Size = new System.Drawing.Size(133, 30);
            this.MediumLabel.TabIndex = 1;
            this.MediumLabel.Text = "Тип трафика";
            // 
            // AddSource
            // 
            this.AddSource.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.AddSource.Location = new System.Drawing.Point(257, 329);
            this.AddSource.Name = "AddSource";
            this.AddSource.Size = new System.Drawing.Size(150, 40);
            this.AddSource.TabIndex = 2;
            this.AddSource.Text = "Добавить";
            this.AddSource.UseVisualStyleBackColor = true;
            this.AddSource.Click += new System.EventHandler(this.AddSource_Click);
            // 
            // Source
            // 
            this.Source.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Source.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Source.Location = new System.Drawing.Point(3, 127);
            this.Source.Name = "Source";
            this.Source.Size = new System.Drawing.Size(690, 35);
            this.Source.TabIndex = 3;
            // 
            // Medium
            // 
            this.Medium.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Medium.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Medium.Location = new System.Drawing.Point(3, 249);
            this.Medium.Name = "Medium";
            this.Medium.Size = new System.Drawing.Size(690, 35);
            this.Medium.TabIndex = 4;
            // 
            // AddTrafficSource
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 436);
            this.Controls.Add(this.Medium);
            this.Controls.Add(this.Source);
            this.Controls.Add(this.AddSource);
            this.Controls.Add(this.MediumLabel);
            this.Controls.Add(this.SourceLabel);
            this.MinimumSize = new System.Drawing.Size(730, 475);
            this.Name = "AddTrafficSource";
            this.Text = "Добавить источник трафика";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AddTrafficSource_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SourceLabel;
        private System.Windows.Forms.Label MediumLabel;
        private System.Windows.Forms.Button AddSource;
        private System.Windows.Forms.TextBox Source;
        private System.Windows.Forms.TextBox Medium;
    }
}
namespace UTM_marker
{
    partial class UtmEditor
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
            this.Course = new System.Windows.Forms.TextBox();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.LinkLabel = new System.Windows.Forms.Label();
            this.ChangeUtmLinks = new System.Windows.Forms.Button();
            this.Link = new System.Windows.Forms.TextBox();
            this.CreateUtmLinks = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.Course);
            this.panel1.Controls.Add(this.CourseLabel);
            this.panel1.Controls.Add(this.LinkLabel);
            this.panel1.Controls.Add(this.ChangeUtmLinks);
            this.panel1.Controls.Add(this.Link);
            this.panel1.Controls.Add(this.CreateUtmLinks);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 420);
            this.panel1.TabIndex = 6;
            // 
            // Course
            // 
            this.Course.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Course.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Course.Location = new System.Drawing.Point(6, 118);
            this.Course.Name = "Course";
            this.Course.Size = new System.Drawing.Size(670, 35);
            this.Course.TabIndex = 5;
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CourseLabel.Location = new System.Drawing.Point(6, 59);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(164, 30);
            this.CourseLabel.TabIndex = 7;
            this.CourseLabel.Text = "Название курса";
            // 
            // LinkLabel
            // 
            this.LinkLabel.AutoSize = true;
            this.LinkLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinkLabel.Location = new System.Drawing.Point(6, 182);
            this.LinkLabel.Name = "LinkLabel";
            this.LinkLabel.Size = new System.Drawing.Size(239, 30);
            this.LinkLabel.TabIndex = 8;
            this.LinkLabel.Text = "Адрес вашей страницы";
            // 
            // ChangeUtmLinks
            // 
            this.ChangeUtmLinks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ChangeUtmLinks.Location = new System.Drawing.Point(260, 320);
            this.ChangeUtmLinks.MaximumSize = new System.Drawing.Size(150, 40);
            this.ChangeUtmLinks.Name = "ChangeUtmLinks";
            this.ChangeUtmLinks.Size = new System.Drawing.Size(150, 40);
            this.ChangeUtmLinks.TabIndex = 9;
            this.ChangeUtmLinks.Text = "Change";
            this.ChangeUtmLinks.UseVisualStyleBackColor = true;
            this.ChangeUtmLinks.Click += new System.EventHandler(this.ChangeUtmLinks_Click);
            // 
            // Link
            // 
            this.Link.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Link.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Link.Location = new System.Drawing.Point(6, 240);
            this.Link.Name = "Link";
            this.Link.Size = new System.Drawing.Size(670, 35);
            this.Link.TabIndex = 6;
            // 
            // CreateUtmLinks
            // 
            this.CreateUtmLinks.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateUtmLinks.Location = new System.Drawing.Point(502, 649);
            this.CreateUtmLinks.MaximumSize = new System.Drawing.Size(150, 40);
            this.CreateUtmLinks.Name = "CreateUtmLinks";
            this.CreateUtmLinks.Size = new System.Drawing.Size(150, 40);
            this.CreateUtmLinks.TabIndex = 4;
            this.CreateUtmLinks.Text = "Create";
            this.CreateUtmLinks.UseVisualStyleBackColor = true;
            // 
            // UtmEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 436);
            this.Controls.Add(this.panel1);
            this.Name = "UtmEditor";
            this.Text = "Utm";
            this.Load += new System.EventHandler(this.UtmEditor_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CreateUtmLinks;
        private System.Windows.Forms.TextBox Course;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Label LinkLabel;
        private System.Windows.Forms.Button ChangeUtmLinks;
        private System.Windows.Forms.TextBox Link;
    }
}
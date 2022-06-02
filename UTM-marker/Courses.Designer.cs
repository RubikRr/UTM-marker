namespace UTM_marker
{
    partial class Courses
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
            this.CreateCourse = new System.Windows.Forms.Button();
            this.CoursesList = new System.Windows.Forms.ListBox();
            this.VkUrl = new System.Windows.Forms.TextBox();
            this.VkLabel = new System.Windows.Forms.Label();
            this.WebsitesWithURL = new System.Windows.Forms.TableLayoutPanel();
            this.TgLabel = new System.Windows.Forms.Label();
            this.TgUrl = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.TaplinkLabel = new System.Windows.Forms.Label();
            this.InstUrl = new System.Windows.Forms.TextBox();
            this.TaplinkUrl = new System.Windows.Forms.TextBox();
            this.EmailUrl = new System.Windows.Forms.TextBox();
            this.InstLabel = new System.Windows.Forms.Label();
            this.WebsitesWithURL.SuspendLayout();
            this.SuspendLayout();
            // 
            // CreateCourse
            // 
            this.CreateCourse.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.CreateCourse.Location = new System.Drawing.Point(304, 362);
            this.CreateCourse.Name = "CreateCourse";
            this.CreateCourse.Size = new System.Drawing.Size(151, 44);
            this.CreateCourse.TabIndex = 0;
            this.CreateCourse.Text = "Create course";
            this.CreateCourse.UseVisualStyleBackColor = true;
            this.CreateCourse.Click += new System.EventHandler(this.CreateCourse_Click);
            // 
            // CoursesList
            // 
            this.CoursesList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.CoursesList.BackColor = System.Drawing.SystemColors.Control;
            this.CoursesList.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CoursesList.FormattingEnabled = true;
            this.CoursesList.ItemHeight = 21;
            this.CoursesList.Location = new System.Drawing.Point(12, 30);
            this.CoursesList.Name = "CoursesList";
            this.CoursesList.Size = new System.Drawing.Size(154, 403);
            this.CoursesList.TabIndex = 1;
            this.CoursesList.SelectedIndexChanged += new System.EventHandler(this.CoursesList_SelectedIndexChanged);
            // 
            // VkUrl
            // 
            this.VkUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VkUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VkUrl.Location = new System.Drawing.Point(103, 3);
            this.VkUrl.Name = "VkUrl";
            this.VkUrl.Size = new System.Drawing.Size(441, 29);
            this.VkUrl.TabIndex = 1;
            // 
            // VkLabel
            // 
            this.VkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.VkLabel.AutoSize = true;
            this.VkLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VkLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VkLabel.Location = new System.Drawing.Point(3, 3);
            this.VkLabel.Name = "VkLabel";
            this.VkLabel.Size = new System.Drawing.Size(94, 30);
            this.VkLabel.TabIndex = 0;
            this.VkLabel.Text = "Vk";
            // 
            // WebsitesWithURL
            // 
            this.WebsitesWithURL.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WebsitesWithURL.ColumnCount = 3;
            this.WebsitesWithURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.WebsitesWithURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.WebsitesWithURL.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.WebsitesWithURL.Controls.Add(this.VkLabel, 0, 0);
            this.WebsitesWithURL.Controls.Add(this.VkUrl, 1, 0);
            this.WebsitesWithURL.Controls.Add(this.TgLabel, 0, 1);
            this.WebsitesWithURL.Controls.Add(this.TgUrl, 1, 1);
            this.WebsitesWithURL.Controls.Add(this.EmailLabel, 0, 4);
            this.WebsitesWithURL.Controls.Add(this.TaplinkLabel, 0, 3);
            this.WebsitesWithURL.Controls.Add(this.InstUrl, 1, 2);
            this.WebsitesWithURL.Controls.Add(this.TaplinkUrl, 1, 3);
            this.WebsitesWithURL.Controls.Add(this.EmailUrl, 1, 4);
            this.WebsitesWithURL.Controls.Add(this.InstLabel, 0, 2);
            this.WebsitesWithURL.Location = new System.Drawing.Point(187, 30);
            this.WebsitesWithURL.Name = "WebsitesWithURL";
            this.WebsitesWithURL.RowCount = 5;
            this.WebsitesWithURL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.WebsitesWithURL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.WebsitesWithURL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.WebsitesWithURL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.WebsitesWithURL.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.WebsitesWithURL.Size = new System.Drawing.Size(587, 180);
            this.WebsitesWithURL.TabIndex = 2;
            // 
            // TgLabel
            // 
            this.TgLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TgLabel.AutoSize = true;
            this.TgLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TgLabel.Location = new System.Drawing.Point(3, 39);
            this.TgLabel.Name = "TgLabel";
            this.TgLabel.Size = new System.Drawing.Size(94, 30);
            this.TgLabel.TabIndex = 2;
            this.TgLabel.Text = "Tg";
            // 
            // TgUrl
            // 
            this.TgUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TgUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TgUrl.Location = new System.Drawing.Point(103, 39);
            this.TgUrl.Name = "TgUrl";
            this.TgUrl.Size = new System.Drawing.Size(441, 29);
            this.TgUrl.TabIndex = 3;
            // 
            // EmailLabel
            // 
            this.EmailLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.Location = new System.Drawing.Point(3, 147);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(94, 30);
            this.EmailLabel.TabIndex = 6;
            this.EmailLabel.Text = "Email";
            // 
            // TaplinkLabel
            // 
            this.TaplinkLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TaplinkLabel.AutoSize = true;
            this.TaplinkLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaplinkLabel.Location = new System.Drawing.Point(3, 111);
            this.TaplinkLabel.Name = "TaplinkLabel";
            this.TaplinkLabel.Size = new System.Drawing.Size(94, 30);
            this.TaplinkLabel.TabIndex = 5;
            this.TaplinkLabel.Text = "Taplink";
            // 
            // InstUrl
            // 
            this.InstUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InstUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstUrl.Location = new System.Drawing.Point(103, 75);
            this.InstUrl.Name = "InstUrl";
            this.InstUrl.Size = new System.Drawing.Size(441, 29);
            this.InstUrl.TabIndex = 7;
            // 
            // TaplinkUrl
            // 
            this.TaplinkUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TaplinkUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TaplinkUrl.Location = new System.Drawing.Point(103, 111);
            this.TaplinkUrl.Name = "TaplinkUrl";
            this.TaplinkUrl.Size = new System.Drawing.Size(441, 29);
            this.TaplinkUrl.TabIndex = 8;
            // 
            // EmailUrl
            // 
            this.EmailUrl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.EmailUrl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailUrl.Location = new System.Drawing.Point(103, 147);
            this.EmailUrl.Name = "EmailUrl";
            this.EmailUrl.Size = new System.Drawing.Size(441, 29);
            this.EmailUrl.TabIndex = 9;
            // 
            // InstLabel
            // 
            this.InstLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.InstLabel.AutoSize = true;
            this.InstLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.InstLabel.Location = new System.Drawing.Point(3, 75);
            this.InstLabel.Name = "InstLabel";
            this.InstLabel.Size = new System.Drawing.Size(94, 30);
            this.InstLabel.TabIndex = 4;
            this.InstLabel.Text = "Inst";
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WebsitesWithURL);
            this.Controls.Add(this.CoursesList);
            this.Controls.Add(this.CreateCourse);
            this.MinimumSize = new System.Drawing.Size(815, 480);
            this.Name = "Courses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Courses_Load);
            this.WebsitesWithURL.ResumeLayout(false);
            this.WebsitesWithURL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CreateCourse;
        private System.Windows.Forms.ListBox CoursesList;
        private System.Windows.Forms.Label VkLabel;
        private System.Windows.Forms.TextBox VkUrl;
        private System.Windows.Forms.TableLayoutPanel WebsitesWithURL;
        private System.Windows.Forms.Label TgLabel;
        private System.Windows.Forms.TextBox TgUrl;
        private System.Windows.Forms.Label InstLabel;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Label TaplinkLabel;
        private System.Windows.Forms.TextBox InstUrl;
        private System.Windows.Forms.TextBox TaplinkUrl;
        private System.Windows.Forms.TextBox EmailUrl;
    }
}

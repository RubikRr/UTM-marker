using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace UTM_marker
{
    public partial class Links : Form
    {
        List<Site> SitesWithLinks = new List<Site>();
        List<Website> Sources = new List<Website>();
        private int selectedSiteIndex;


        public Links()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void Courses_Load(object sender, EventArgs e)
        {

            ContextMenySettings();
            ShortLinkMenuStripSettings();
            AddSourceMenuStripSettings();

            Sources = JsonWorker.DeserializeUtmLinksJson();
            //foreach (var item in UtmLinks)
            //{
            //    Console.WriteLine($"{item.Name} {item.UTMparam.Source}");
            //}
            var rowCount = Sources.Count();
            WebsitesWithUtmLinks.RowCount = rowCount;
            for (int i = 0; i < rowCount; i++)
            {
                var site = Sources[i];
                if (i == 0)
                    WebsitesWithUtmLinks.RowStyles[0] = new RowStyle(SizeType.Percent, 100 / rowCount);
                else
                    WebsitesWithUtmLinks.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rowCount));

                WebsitesWithUtmLinks.Controls.Add(CreateWebsiteLable(site.Name), 0, i);
                WebsitesWithUtmLinks.Controls.Add(CreateWebsiteTextBox(site.Name), 1, i);
                WebsitesWithUtmLinks.Controls.Add(CreateCopyButton(i), 2, i);
            }

            SitesWithLinks = JsonWorker.DeserializeSitesJson();
            SitesWithLinks?.ForEach(course => SitesList.Items.Add(course.Name));

        }

        private Label CreateWebsiteLable(string name)
        {
            var websiteLable = new Label();
            websiteLable.Name = $"{name}label";
            websiteLable.Text = name;
            var font = new Font("Segoe UI", 16);
            websiteLable.Font = font;
            websiteLable.Size = new Size(180, 30);
            websiteLable.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            return websiteLable;
        }

        private TextBox CreateWebsiteTextBox(string name)
        {
            var websiteTextBox = new TextBox();
            websiteTextBox.Name = $"{name}Url";
            websiteTextBox.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            websiteTextBox.Size = new Size(460, 30);
            return websiteTextBox;
        }

        private Button CreateCopyButton(int i)
        {
            var copyButton = new Button();
            copyButton.Name = $"CopyButton{i}";
            copyButton.Size = new Size(34, 26);
            copyButton.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            copyButton.Click += CopyButton_Click;
            copyButton.Image = Image.FromFile(@"icons\copybutton.png");
            copyButton.AutoSizeMode = AutoSizeMode.GrowOnly;
            return copyButton;
        }

        private void CreateCourse_Click(object sender, EventArgs e)
        {
            var utmCreateForm = new UtmCreator(SitesWithLinks,Sources, SitesList);
            utmCreateForm.Show();
        }

        private void ShortLinkMenuStripEdit_Click(object sender, EventArgs e)
        {
            var shortLinkForm = new ShortLinkCreator();
            shortLinkForm.Show();
        }

        private void AddSourceMenuStripEdit_Click(object sender, EventArgs e)
        {
            var addSourceForm = new AddTrafficSource(this,Sources, WebsitesWithUtmLinks);
            addSourceForm.Show();
        }

        public  void ChangeWebsitesTable()
        {
            WebsitesWithUtmLinks.RowCount++;
            var rowCount = WebsitesWithUtmLinks.RowCount;
            for (int i = 0; i < rowCount; i++)
            {
                if (i == rowCount - 1)
                {
                    var site = Sources[rowCount - 1];
                    WebsitesWithUtmLinks.RowStyles.Add(new RowStyle(SizeType.Percent, 100 / rowCount));

                    WebsitesWithUtmLinks.Controls.Add(CreateWebsiteLable(site.Name), 0, i);
                    WebsitesWithUtmLinks.Controls.Add(CreateWebsiteTextBox(site.Name), 1, i);
                    WebsitesWithUtmLinks.Controls.Add(CreateCopyButton(i), 2, i);
                }
                else
                    WebsitesWithUtmLinks.RowStyles[i] = new RowStyle(SizeType.Percent, 100 / rowCount);
            }
        }



        private void toolStripDeleat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы действительно хотите удалить сайт?", "Подтверждение", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SitesWithLinks.RemoveAt(selectedSiteIndex);
                SitesList.Items.Clear();
                JsonWorker.SerializeJson(SitesWithLinks);
                SitesWithLinks?.ForEach(course => SitesList.Items.Add(course.Name));
                ResetWebsitesWithUrl();
            }
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            var utmChangeForm = new UtmEditor(SitesWithLinks,Sources, SitesList, selectedSiteIndex);
            utmChangeForm.Show();
        }

       
        private void myListBox_MouseUp(object sender, MouseEventArgs e)
        {
            selectedSiteIndex = -1;
            if (e.Button != MouseButtons.Right) return;
            var index = SitesList.IndexFromPoint(e.Location);

            listboxContextMenu.Show(Cursor.Position);
            if (index != ListBox.NoMatches)
            {
                selectedSiteIndex = index;
                SitesList.SetSelected(index, true);
                listboxContextMenu.Visible = true;
            }
            else
            {
                listboxContextMenu.Visible = false;
            }
        }

        private void CopyButton_Click(object sender, EventArgs e)
        {

            var msg = (Button)sender;
            string phoneNumber = msg.Name;
            string pattern = @"\D";
            string target = "";
            Regex regex = new Regex(pattern);
            string result = regex.Replace(phoneNumber, target);
            var url = WebsitesWithUtmLinks.GetControlFromPosition(1, int.Parse(result)).Text;
            Clipboard.SetText($"{url}");

        }
        private void SitesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SitesList.SelectedIndex != ListBox.NoMatches)
            {
                Site currentSite = SitesWithLinks[SitesList.SelectedIndex];
                int i = 0;
                foreach (var web in currentSite.Websites)
                {
                    string webName = web.Name;
                    string url = web.UTMparam.LinkForUser;
                    WebsitesWithUtmLinks.GetControlFromPosition(1, i).Text = url;
                    i++;

                }
            }

        }

        private void ContextMenySettings()
        {
            var toolStripMenuItem1 = new ToolStripMenuItem { Text = "Изменить" };
            toolStripMenuItem1.Click += toolStripEdit_Click;

            var toolStripDeleat = new ToolStripMenuItem { Text = "Удалить" };
            toolStripDeleat.Click += toolStripDeleat_Click;

            listboxContextMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripDeleat });
            SitesList.ContextMenuStrip = listboxContextMenu;
            SitesList.MouseUp += myListBox_MouseUp;
        }

        public void ShortLinkMenuStripSettings()
        {
            ToolStripMenuItem shortLink = new ToolStripMenuItem("Укоротить ссылку");
            shortLink.Image = Image.FromFile($"icons/external-link.png");

            shortLink.Click += ShortLinkMenuStripEdit_Click;

            menuStrip.Items.Add(shortLink);
        }

        public void AddSourceMenuStripSettings()
        {
            ToolStripMenuItem addSource = new ToolStripMenuItem("Доабвить источник трафика");
            addSource.Image = Image.FromFile($"icons/addsource.png");

            addSource.Click += AddSourceMenuStripEdit_Click;

            menuStrip.Items.Add(addSource);
        }

        private void ResetWebsitesWithUrl()
        {
            for (int i = 0; i < WebsitesWithUtmLinks.RowCount;)
            {
                WebsitesWithUtmLinks.GetControlFromPosition(1, i).Text = "";
                i++;
            }
        }
    }
}

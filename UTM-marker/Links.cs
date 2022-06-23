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
using System.Linq;

namespace UTM_marker
{
    public partial class Links : Form
    {
        List<Site> SitesWithLinks = new List<Site>();
        private int selectedItemIndex;
        public Links()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void CreateCourse_Click(object sender, EventArgs e)
        {
            var utmCreateForm = new UtmCreator(SitesWithLinks, SitesList);
            utmCreateForm.Show();
        }

        private void toolStripDeleat_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to deleat site", "Confirmation", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                SitesWithLinks.RemoveAt(selectedItemIndex);
                SitesList.Items.Clear();
                JsonWorker.SerializeJson(SitesWithLinks);
                SitesWithLinks?.ForEach(course => SitesList.Items.Add(course.Name));
                ResetWebsitesWithUrl();
            }
        }

        private void toolStripEdit_Click(object sender, EventArgs e)
        {
            var utmChangeForm = new UtmEditor(SitesWithLinks, SitesList, selectedItemIndex);
            utmChangeForm.Show();
        }

        private void myListBox_MouseUp(object sender, MouseEventArgs e)
        {
            selectedItemIndex = -1;
            if (e.Button != MouseButtons.Right) return;
            var index = SitesList.IndexFromPoint(e.Location);

            listboxContextMenu.Show(Cursor.Position);
            if (index != ListBox.NoMatches)
            {
                selectedItemIndex = index;
                SitesList.SetSelected(index, true);
                listboxContextMenu.Visible = true;
            }
            else
            {
                listboxContextMenu.Visible = false;
            }
        }
        private void ContextMenySettings()
        {
            var toolStripMenuItem1 = new ToolStripMenuItem { Text = "Edit" };
            toolStripMenuItem1.Click += toolStripEdit_Click;

            var toolStripDeleat = new ToolStripMenuItem { Text = "Deleat" };
            toolStripDeleat.Click += toolStripDeleat_Click;

            listboxContextMenu.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripDeleat });
            SitesList.ContextMenuStrip = listboxContextMenu;
            SitesList.MouseUp += myListBox_MouseUp;
        }

        private void Courses_Load(object sender, EventArgs e)
        {

            ContextMenySettings();

            for (int i = 0; i < WebsitesWithURL.RowCount; i++)
            {
                WebsitesWithURL.GetControlFromPosition(2, i).Click += CopyButton_Click;
            }

            SitesWithLinks = JsonWorker.DeserializeJson();
            SitesWithLinks?.ForEach(course => SitesList.Items.Add(course.Name));

        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            var msg = (Button)sender;
            var str = int.Parse(msg.Name[msg.Name.Length - 1].ToString());
            var url = WebsitesWithURL.GetControlFromPosition(1, str).Text;
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
                    string url = web.UTMparam.LinkForWin;
                    string shortUrl = web.UTMparam.ShortLink;
                    WebsitesWithURL.GetControlFromPosition(1, i).Text = url;
                    i++;
                    WebsitesWithURL.GetControlFromPosition(1, i).Text = shortUrl;
                    i++;
                }
            }

        }

        private void ResetWebsitesWithUrl()
        {
            for (int i = 0; i < WebsitesWithURL.RowCount;)
            {
                WebsitesWithURL.GetControlFromPosition(1, i).Text = "";
                i++;
                WebsitesWithURL.GetControlFromPosition(1, i).Text = "";
                i++;
            }
        }
    }
}

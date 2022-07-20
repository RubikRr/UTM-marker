using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTM_marker
{
    public partial class UtmEditor : Form
    {
        public List<Site> SitesWithLinks { get; set; }
        List<Website> UtmLinks = new List<Website>();
        ListBox SitesList = new ListBox();
        private int selectedItemIndex;
        public UtmEditor(List<Site> sitesWithLinks,List<Website> utmLinks, ListBox sitesList,int selectedItemIndex)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            SitesWithLinks = sitesWithLinks;
            UtmLinks = utmLinks;
            SitesList = sitesList;
            this.selectedItemIndex= selectedItemIndex;
        }
        private void ChangeUtmLinks_Click(object sender, EventArgs e)
        {
            string courseName = Site.Text;
            string url = Link.Text;

            UtmLinks.ForEach(site => site.UTMparam.AddUTMmark(url));
            SitesList.Items[selectedItemIndex]=courseName;
            var site = new Site(courseName, url, UtmLinks);
            SitesWithLinks[selectedItemIndex]=(site);

            JsonWorker.SerializeJson(SitesWithLinks);
            MessageBox.Show("Сайт был изменен");
            SitesList.SetSelected(selectedItemIndex, true);
            this.Close();
        }

        private void UtmEditor_Load(object sender, EventArgs e)
        {
            Site.Text = SitesWithLinks[selectedItemIndex].Name;
            Link.Text= SitesWithLinks[selectedItemIndex].Link;
        }
    }
}

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
    public partial class ChangeCampaign : Form
    {
        
        private Site siteForChange;
        private int selectedSiteIndex;
        private ListBox sites;

        public ChangeCampaign(Site siteForChange)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.siteForChange = siteForChange;
            Campaign.Text = siteForChange.Websites[0].UTMparam.Campaign;
        }

        private void Change_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Campaign.Text))
            {
                foreach (var s in siteForChange.Websites)
                {
                    s.UTMparam.ChangeCampaign(siteForChange.Link, Campaign.Text);
                }
            }

            MessageBox.Show("Кампания изменена. Кликнете по названию сайта еще раз.");
            this.Close();
        }
    }
}

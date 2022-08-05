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
    public partial class AddTrafficSource : Form
    {
        List<Website> Sources = new List<Website>();
        TableLayoutPanel WebsitesWithUtmLinks= new TableLayoutPanel();
        Links Link = new Links(); 
        int oldCountOfSources;
        public AddTrafficSource(Links link,TableLayoutPanel websitesWithUtmLinks)
        {
            InitializeComponent();
            StartPosition=FormStartPosition.CenterScreen;
            Link = link;
            Sources = JsonWorker.DeserializeUtmLinksJson(); ;
            WebsitesWithUtmLinks=websitesWithUtmLinks;
            oldCountOfSources = Sources.Count;

        }

        private void AddSource_Click(object sender, EventArgs e)
        {
            if(Source.Text!=""&& Medium.Text!="")
            {
                var name=Source.Text;
                var source=Source.Text.ToLower();
                var medium=Medium.Text;
                var website = new Website(name, new UtmLink(source, medium, "{}"));
                Sources.Add(website);
                JsonWorker.SerializeUtmLinksJson(Sources);
                MessageBox.Show("Источник трафика добавлен");
                this.Close();
            }
        }

        private void AddTrafficSource_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(oldCountOfSources!=Sources.Count)
                Link.ChangeWebsitesTable();
        }
    }
}

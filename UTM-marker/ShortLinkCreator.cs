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
    public partial class ShortLinkCreator : Form
    {
        public ShortLinkCreator()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateUtmLinks_Click(object sender, EventArgs e)
        {
            string link = Link.Text;

            try
            {
                ShortLink.Text = UtmLink.GetShortLink(link).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nShort link has not been created");
                return;
            }
            MessageBox.Show("Short link has been created");

        }
    }
}

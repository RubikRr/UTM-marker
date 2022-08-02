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
            string link = Link.Text.Replace("&","%26");

            try
            {
                ShortLink.Text = UtmLink.GetShortLink(link).Result;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}\nКороткая ссылка не была создана");
                return;
            }
            MessageBox.Show("Короткая ссылка была создана");

        }
    }
}

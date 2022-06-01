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
    public partial class UtmCreator : Form
    {
        public UtmCreator()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


       

        private void UtmCreator_SizeChanged(object sender, EventArgs e)
        {
            //ButtonCentre(CreateUtmLinks,this.Height-CreateUtmLinks.Height*2);
        }

        public void ButtonCentre(Button button, int y)
        {
            button.Location = new Point((this.Width - button.Width) / 2, y);
        }
    }
}

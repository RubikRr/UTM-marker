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
    public partial class Courses : Form
    {
        public Courses()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void Courses_SizeChanged(object sender, EventArgs e)
        {
            //ButtonCentre(CreateCourse, this.Height - 75);
        }
        public void ButtonCentre(Button button,int y)
        {
            //button.Location = new Point((this.Width - button.Width) / 2, y);
        }

        private void CreateCourse_Click(object sender, EventArgs e)
        {
            var utmForm = new UtmCreator();
            utmForm.Show();
        }
    }
}

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
        List<Course> CoursesWithLinks=new List<Course>();
        public Courses()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void CreateCourse_Click(object sender, EventArgs e)
        {
            var utmForm = new UtmCreator();
            utmForm.Show();
        }
    }
}

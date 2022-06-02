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
            var utmForm = new UtmCreator(CoursesWithLinks,CoursesList);
            utmForm.Show();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            using (StreamReader file = File.OpenText(@"..\..\..\jsons\course.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                CoursesWithLinks = (List<Course>)serializer.Deserialize(file, typeof(List<Course>));
            }
            foreach (Course course in CoursesWithLinks)
            {
                CoursesList.Items.Add(course.Name);
            }
           
        }

        private void CoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var courseName = CoursesList.SelectedItem;
            Course courseSel=null;
            foreach (var courseWithLink in CoursesWithLinks)
            {
                if (courseWithLink.Name == courseName)
                {
                    courseSel = courseWithLink;
                    break;
                }
            }
            int i = 0;
            foreach (var web in courseSel.Websites)
            {
                string webName = web.Name;
                string url = web.UTMparam.Link;
                WebsitesWithURL.GetControlFromPosition(0, i).Text=webName;
                WebsitesWithURL.GetControlFromPosition(1, i).Text = url;
                i++;
            }
        }
    }
}

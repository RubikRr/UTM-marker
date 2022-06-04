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
    public partial class Courses : Form
    {
        List<Course> CoursesWithLinks = new List<Course>();
        public Courses()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }


        private void CreateCourse_Click(object sender, EventArgs e)
        {
            var utmForm = new UtmCreator(CoursesWithLinks, CoursesList);
            utmForm.Show();
        }

        private void Courses_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < WebsitesWithURL.RowCount; i++)
            {
                WebsitesWithURL.GetControlFromPosition(2, i).Click += CommonBtn_Click;
            }

            using (StreamReader file = File.OpenText(@"jsons\course.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                CoursesWithLinks = (List<Course>)serializer.Deserialize(file, typeof(List<Course>));
            }

            CoursesWithLinks = CoursesWithLinks ?? new List<Course>();
            CoursesWithLinks?.ForEach(course => CoursesList.Items.Add(course.Name));

        }

        private void CommonBtn_Click(object sender, EventArgs e)
        {
            var msg = (Button)sender;
            var str = int.Parse(msg.Name[msg.Name.Length - 1].ToString());
            var url = WebsitesWithURL.GetControlFromPosition(1, str).Text;
            Clipboard.SetText($"{url}");

        }
        private void CoursesList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var courseName = CoursesList.SelectedItem;
            Course courseSel = null;
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
                string url = web.UTMparam.LinkForWin;
                string shortUrl = web.UTMparam.ShortLink;
                WebsitesWithURL.GetControlFromPosition(1, i).Text = url;
                i++;
                WebsitesWithURL.GetControlFromPosition(1, i).Text = shortUrl;
                i++;
            }
        }
    }
}

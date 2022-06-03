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
    public partial class UtmCreator : Form
    {
        public List<Course> CoursesWithUrls { get; set; }
        List<Website> websites = new List<Website>();
        ListBox CoursesList = new ListBox();
        public UtmCreator(List<Course> coursesWithUrls,ListBox coursesList)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
           CoursesWithUrls = coursesWithUrls;
           CoursesList = coursesList;
        }
       
        private void CreateUtmLinks_Click(object sender, EventArgs e)
        {
            string courseName = Course.Text;
            string url = Link.Text;
            CoursesList.Items.Add(courseName);
            foreach (var site in websites)
            {
                site.UTMparam.AddUTMmark(url);
            }
            var course = new Course(courseName, url, websites);
            CoursesWithUrls.Add(course);

            using (StreamWriter file = File.CreateText(@"..\..\..\jsons\course.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, CoursesWithUrls);
            }

            MessageBox.Show("Курс создан");
            Refresh();
           
        }

        private void UtmCreator_Load(object sender, EventArgs e)
        {
            var VkSite = new Website("Vk", new UtmLink("myAnalytics", "social", "vk"));
            var TgSite = new Website("Tg", new UtmLink("myAnalytics", "social", "tg"));
            var InstSite = new Website("Inst", new UtmLink("myAnalytics", "social", "inst"));
            var TaplinkSite = new Website("Taplink", new UtmLink("myAnalytics", "organic", "taplink"));
            var EmailSite = new Website("Email", new UtmLink("myAnalytics", "email", "stepik"));
            websites.AddRange(new Website[] { VkSite, TgSite, InstSite, TaplinkSite, EmailSite });
        }

        public void Refresh()
        {
            Course.Text = "";
            Link.Text = "";
            //Link.Enabled = false;
        }

        private void Course_TextChanged(object sender, EventArgs e)
        {
           // Link.Enabled = true;
        }
    }
}

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
            var utmForm = new UtmCreator();
            utmForm.Show();
        }

        private void Courses_Load(object sender, EventArgs e)
        {
            CoursesWithLinks  = JsonConvert.DeserializeObject<List<Course>>(File.ReadAllText(@"..\..\..\jsons\course.json"));

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(@"..\..\..\jsons\course.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                CoursesWithLinks = (List<Course>)serializer.Deserialize(file, typeof(List<Course>));
            }
            Console.WriteLine(CoursesWithLinks[1].Name);
        }
    }
}

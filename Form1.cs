using System.Diagnostics;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LAB3
{
    public partial class Form1 : Form
    {
        //List<Student> student; = new List<Student> students;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Student Object
            //Student name1 = new Student("Robert", "233312", 20, 2002, 167, 3.88, "CIS");
            //Student name2 = new Student("Rose", "233412", 21, 2001, 175, 3.45, "DS");
            //name1.name = "Mickky";
            //name2.name = "Jacky";
            //name1.id = "234442";
            //name2.id = "234443";
            //name1.age = 20;
            //name2.age = 21;
            //name1.birthdat = 2003;
            //name2.birthdat = 2002;
            /// Show to textbox
            //textBoxName1.Text = name1.name;
            //textBoxName2.Text = name1.id;
            //textBoxName3.Text = name1.age.ToString();
            //textBoxName4.Text = name1.birthdat.ToString();
            //textBoxHight.Text = name1.Hight.ToString();
            //textBoxGrade.Text = name1.grade.ToString();
            //textBoxMajor.Text = name1.major;
            // calculate age
            //textBoxName3.Text = name1.AgeSumm().ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBoxName1.Text = "";
            textBoxName2.Text = "";
            textBoxName3.Text = "";
            textBoxName4.Text = "";
            textBoxHight.Text = "";
            textBoxGrade.Text = "";
            textBoxMajor.Text = "";
            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //Student Newstudent = new Student(name,id);
            //this.student.Add(Newstudent);
            //MessageBox.Show(string.Format("{0}\n{1}\n{2}\n{3}\n{4}\n{5}\n{6}"
            //, "ชื่อ", textBoxName1.Text,
            //"ID", textBoxName2.Text,
            //"อายุ", textBoxName3.Text,
            //"ปีเกิด", textBoxName4.Text,
            //"ส่วนสูง", textBoxHight.Text,
            //"เกรดเฉลี่ย", textBoxGrade.Text,
            //"สาขา", textBoxMajor.Text));

            Student std = new Student(textBoxName1.Text,textBoxName2.Text,int.Parse(textBoxName3.Text),int.Parse(textBoxName4.Text)
                                         ,int.Parse(textBoxHight.Text),int.Parse(textBoxGrade.Text),textBoxMajor.Text) { };
            std.AddData(dataGridView1);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }

        private void Showbut_Click(object sender, EventArgs e)
        {
            
        }
    }
}
namespace LAB3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Create Student Object
            Student name1 = new Student("Robert", "233312", 20, 2002, 167, 3.88, "CIS");
            Student name2 = new Student("Rose", "233412", 21, 2001, 175, 3.45, "DS");
            //name1.name = "Mickky";
            //name2.name = "Jacky";
            //name1.id = "234442";
            //name2.id = "234443";
            //name1.age = 20;
            //name2.age = 21;
            //name1.birthdat = 2003;
            //name2.birthdat = 2002;
            /// Show to textbox
            textBoxName1.Text = name1.name;
            textBoxName2.Text = name1.id;
            textBoxName3.Text = name1.age.ToString();
            textBoxName4.Text = name1.birthdat.ToString();
            textBoxHight.Text = name1.Hight.ToString();
            textBoxGrade.Text = name1.grade.ToString();
            textBoxMajor.Text = name1.major;
            // calculate age
            //textBoxName3.Text = name1.AgeSumm().ToString();


        }

    }
}
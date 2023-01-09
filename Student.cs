using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB3
{
    internal class Student
    {
      public  string name;
       public string id;
       public int age;
        public int birthdat;
        public int Hight;
        public double grade;
        public string major;


        public Student(string name, string id, int age, int birthdat, int hight, double grade, string major)
        {
            //Student name1 = new Student("Robert", "233312", 20, 2002, 167,3.88,"CIS");
            //Student name2 = new Student("Rose", "233412", 21, 2001, 175,3.45,"DS");
            this.Hight = hight;
            this.grade = grade;
            this.major = major;
            this.name = name;
            this.id = id;
            this.age = age;
            this.birthdat = birthdat;
        }




        //public String AgeSumm(int age)
        //{
            //int age2 = 2023 - birthdat; 
            //return age2.ToString();
        //}
    }
}

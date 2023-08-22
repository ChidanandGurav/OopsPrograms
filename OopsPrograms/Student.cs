using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopsPrograms
{
    public class Student
    {
        private int id, roll_no;
        private string name, branch ;
        private double percentage, english, hindi, marathi, total;


        //Constructor
        public Student()
        {
            id = 0;
            roll_no = 0;
            name = "";
            branch = "";
            percentage = 0;
        }

        public Student(int id , int roll_no , string name ,string branch , double percentage)
        {
            this.id = id;
            this.roll_no = roll_no;
            this.name = name;
            this.branch = branch;
            this.percentage = percentage;
        }


        public void AcceptDetails(int i, string nn, int r, string bb, double en, double mar, double hi)
        {
            id = i;
            roll_no = r;
            name = nn;
            branch = bb;
            english = en;
            hindi = hi;
            marathi = mar;
        }
        public void calculate()
        {
            total = marathi + hindi + english;
            percentage = total / 3;
        }

        public void grade()
        {
            if (percentage > 75)
            {
                Console.WriteLine("Grade A");
            }
            else if (percentage > 60)
            {
                Console.WriteLine("Grade B");
            }
            else if (percentage > 50)
            {
                Console.WriteLine("Garde C");
            }
            else if (percentage > 35)
            {
                Console.WriteLine("Garde D");
            }
            else
            {
                Console.WriteLine("Fail");
            }
        }
        public string PrintDetails()
        {
            return $"Name: {name}  ID: {id}  Roll_no:{roll_no}  Percentage:{percentage} Branch: {branch}  Total: {total}";
        }
    }
}
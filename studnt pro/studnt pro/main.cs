using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace studnt_pro
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CreateStudentProfile obj = new CreateStudentProfile();
            obj.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            using (StreamWriter obj = new StreamWriter("D:/DataStudent.txt", true))
            {
                MessageBox.Show("Please enter Your ID number");
                string studentInput = Console.ReadLine();
                obj.WriteLine(studentInput);
                MessageBox.Show("Please enter Your Name");
                studentInput = Console.ReadLine();
                obj.WriteLine(studentInput);
                MessageBox.Show("Please enter Your  Semester");
                studentInput = Console.ReadLine();
                obj.WriteLine(studentInput);
                MessageBox.Show("Please enter Your CGPA");
                studentInput = Console.ReadLine();
                obj.WriteLine(studentInput);
                MessageBox.Show("Please enter Your Department");
                studentInput = Console.ReadLine();
                obj.WriteLine(studentInput);
                MessageBox.Show("Please enter Your University");
                studentInput = Console.ReadLine();
                obj.WriteLine(studentInput);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("D:/Lajeen1.txt");
            MessageBox.Show("Input Id to delete data");
            String SID = Console.ReadLine();
            String display = "";
            {
                string Nextline = sr.ReadLine();
                if (Nextline.Equals(SID))
                {
                    display += null;
                    display += "/n";
                }
                {
                    display += sr.ReadLine();
                    display += "/n";

                }
                Console.WriteLine(display);
                Console.WriteLine("Data is deleted");
                SID = Console.ReadLine();

            }
        }
    }
}
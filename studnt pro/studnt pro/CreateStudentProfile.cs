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
    public partial class CreateStudentProfile : Form
    {
        public CreateStudentProfile()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Update_Click(object sender, EventArgs e)
        {
            using(StreamWriter obj =new StreamWriter("D:/Lajeen1.txt",true))
            {
                obj.WriteLine(eno.Text);
                obj.WriteLine(nam.Text);
                obj.WriteLine(smstr.Text);
                eno.Clear();
                eno.AppendText("12");
            }
        }

        private void eno_TextChanged(object sender, EventArgs e)
        {

        }

        private void nam_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateStudentProfile_Load(object sender, EventArgs e)
        {

        }
    }
}

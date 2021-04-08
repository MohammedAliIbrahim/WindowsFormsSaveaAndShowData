using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsSaveaAndShowData
{
    public partial class ShowStudentsForm : Form
    {
        List<Student> students { get; set; }
        public ShowStudentsForm(List<Student> studentsList)
        {
            InitializeComponent();
            students = studentsList;
            foreach (Student student in studentsList)
            {

                dataGridView1.Rows.Add(student.name, student.country, student.yearOfBirth, student.Gender, student.languages);
            }
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            string keyWord = textBox1.Text;
            foreach (Student student in students)
            {


                if (student.name.Contains(keyWord))
                {

                    dataGridView1.Rows.Add(student.name, student.country, student.yearOfBirth, student.Gender, student.languages);
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dataGridView1.Rows.Clear();
            foreach (Student student in students)
            {

                dataGridView1.Rows.Add(student.name, student.country, student.yearOfBirth, student.Gender, student.languages);
            }

        }
    }
}

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
        public ShowStudentsForm(List<Student> studentsList)
        {
            InitializeComponent();
            foreach (Student student in studentsList)

            {

                dataGridView1.Rows.Add(student.name, student.country, student.yearOfBirth, student.Gender, student.languages);
            }
        }
    }
}

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
    public partial class Form1 : Form
    {
        List<Student> studentsList = new List<Student>();

        public Form1()
        {
            InitializeComponent();


           
            //List<string> yearsList = new List<string>() { "2010", "2011", "2012", "2013", "2014" };


            //   comboBox1.Items.AddRange(yearsList.ToArray()) ;

            //string[] yearsArray = { "2010", "2011", "2012", "2013", "2014" };
            //comboBox1.Items.AddRange(yearsArray);


            //comboBox1.Items.Add(2010);
            //comboBox1.Items.Add(2011);
            //comboBox1.Items.Add(2012);
            //comboBox1.Items.Add(2013);
            //comboBox1.Items.Add(2014);

            for (int i=1950; i<2015; i++)
            {

                comboBox1.Items.Add(i);
            }



        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            // do validation on user input 
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(comboBox2.Text) || string.IsNullOrWhiteSpace(comboBox1.Text))
            {

                MessageBox.Show("الرجاء إدخال جميع البيانات المطلوبة");

                //  label6.Text = "الرجاء إدخال جميع البيانات المطلوبة";
                // label6.Visible = true;
            }
            else { 
                //Student s1 = new Student();
                //s1.name = "salma";

                string selectedGender="";
                    if (radioButton1.Checked)
                {
                    selectedGender = radioButton1.Text;
                }
                    if (radioButton2.Checked) { selectedGender = radioButton2.Text; }


                string selectedLanguages = "";

                if (checkBox1.Checked) { selectedLanguages = selectedLanguages +" "+ checkBox1.Text; }

                if (checkBox2.Checked) { selectedLanguages = selectedLanguages + " " + checkBox2.Text; }

                if (checkBox3.Checked) { selectedLanguages = selectedLanguages + " " + checkBox3.Text; }



                studentsList.Add(new Student { name = textBox1.Text, country = comboBox2.SelectedItem.ToString(), yearOfBirth = int.Parse(comboBox1.SelectedItem.ToString()), Gender=selectedGender,languages=selectedLanguages});


                // for testing only
                //  MessageBox.Show(selectedLanguages);


                // clear inputs after each saving
             //   textBox1.Text = "";
                textBox1.Clear();

                radioButton1.Checked = false;
                radioButton2.Checked = false;

                checkBox1.Checked = false;
                checkBox2.Checked = false;
                checkBox3.Checked = false;



            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShowStudentsForm showStudentsForm = new ShowStudentsForm(studentsList);
            showStudentsForm.Show();
        }
    }
}

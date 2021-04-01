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
            if (string.IsNullOrWhiteSpace(textBox1.Text)||string.IsNullOrWhiteSpace (comboBox2.Text) )
            {

                MessageBox.Show("الرجاء إدخال جميع البيانات المطلوبة");

                //  label6.Text = "الرجاء إدخال جميع البيانات المطلوبة";
               // label6.Visible = true;
            }

        }
    }
}

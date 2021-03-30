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



            //comboBox1.Items.Add(2010);
            //comboBox1.Items.Add(2011);
            //comboBox1.Items.Add(2012);
            //comboBox1.Items.Add(2013);
            //comboBox1.Items.Add(2014);

            List<object> yearsList = new List<object>() { 2010, 2011, 2012, 2013, 2014 };

          
            comboBox1.Items.AddRange(yearsList.ToArray()) ;




        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM3
{
    public partial class Form1 : Form
    {
        ArrayList MyCustomer = new ArrayList(); 
        public Form1()
        {   
            InitializeComponent();
            button1.Text = "Add";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MyCustomer.Add(new Customer() { FirstName = textBox1.Text, LastName = textBox2.Text });
            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();
            foreach(Customer c in MyCustomer)
            {
                listBox1.Items.Add(c);
            }
        }
    }
}

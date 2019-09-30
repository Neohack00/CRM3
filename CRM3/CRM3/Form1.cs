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
        ArrayList MyEmployee = new ArrayList();
        private string mode = "Customer" ;
        public Form1()
        {   
            InitializeComponent();
            button1.Text = "Add";
            updateForm();
            button3.Text = "Customer";
            button4.Text = "Employee";
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (mode == "Customer")
            {
                MyCustomer.Add(new Customer() { FirstName = textBox1.Text, LastName = textBox2.Text });
            }
            else if (mode == "Employee")
            {
                MyEmployee.Add(new Employee() { FirstName = textBox1.Text, LastName = textBox2.Text });
            }



            textBox1.Clear();
            textBox2.Clear();
            textBox1.Focus();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (mode == "Customer")
            {
                foreach (Customer displayedCustomer in MyCustomer)
                {
                    listBox1.Items.Add(displayedCustomer);
                }
            }
            else if (mode == "Employee")
            {
                foreach (Employee displayedEmployee in MyEmployee)
                {
                    listBox1.Items.Add(displayedEmployee);
                }
            }


        }
        //tänker att använder får välja ett typ av lägen de vill vara i genom trycka på en av de två knapperna.
        //Det kommer finnas två lägen "kund" eller "anställd". Där kund är default läget programet startat med.
        //Den valda läget kommer ställa om funktionerna så att allt sparas och skrivs ut på rätt sätt
        private void button3_Click(object sender, EventArgs e)
        {
            mode = "Customer";
            updateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mode = "Employee";
            updateForm();
        }

        private void updateForm()
        {
            button2.Text = string.Format("Show {0}", mode);
            label4.Text = string.Format("New {0}", mode);
            label5.Text = string.Format("{0} list", mode);
        }

    }
}

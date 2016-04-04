using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Phonebook
{
    public partial class Contacts : Form
    {
        public Contacts()
        {
            InitializeComponent();
            comboBox1.DataSource = Enum.GetValues(typeof(Type));
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Contacts_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < TelephoneDirectory.persons.Count; i++)
            {
                listBox1.Items.Add(TelephoneDirectory.persons[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TelephoneDirectory.persons.Add(new Person(textBox1.Text, textBox2.Text, Int32.Parse(textBox3.Text), textBox4.Text, comboBox1.Text));
        }

        
    }
}

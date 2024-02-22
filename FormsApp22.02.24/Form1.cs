using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsApp22._02._24
{
    public partial class Form1 : Form
    {
        public List<Person> Persons = new List<Person>()
     {
         new Person("Maria", 18),
         new Person("Ema", 13),
         new Person("Tomas", 23),
         new Person("Wiliam", 17),
         new Person("Zet", 26),
         new Person("Betty", 30)
     };
        public Form1()
        {
            InitializeComponent();

            foreach (var persons in Persons)
            {
                cmbChooseName.Items.Add(persons.Name);
            }
        }
        public void NewPerson(Person person)
        {
            Persons.Add(person);
            cmbChooseName.Items.Add(person.Name);
        }
        private void cmbChooseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtbShowAge.Text = Persons[cmbChooseName.SelectedIndex].Age.ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure?", "Closing!",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("Goodbye!", "Good day!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
                Close();
            }                    
        }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnNewPerson_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.Show();
        }
    }
}

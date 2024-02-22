using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormsApp22._02._24
{
    public partial class Form2 : Form
    {
        private Form1 form1;
            
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtbAge.Text, out int age))
            {
                Person person1 = new Person(txtbName.Text, age);
                form1.NewPerson(person1);
                MessageBox.Show("Successfully added!", "Completion!", 
                    MessageBoxButtons.OK,
                MessageBoxIcon.Asterisk);
                Close();
            }
            else
            {
                MessageBox.Show("Invalid information.", "Warning!!!",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}

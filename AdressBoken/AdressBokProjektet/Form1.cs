using System;
using System.Windows.Forms;

namespace AdressBokProjektet
{
    public partial class Form1 : Form
    {       

        public Form1()
        {
            InitializeComponent();
        }

        protected virtual void formFirstName_TextChanged(object sender, EventArgs e)
        {
            Persons person = new Persons();
            person.FirstName = formFirstName.Text;  
        }
        protected void formLastName_TextChanged(object sender, EventArgs e)
        {
            Persons person = new Persons();
            person.LastName = formLastName.Text;
        }
        protected void formAdress_TextChanged(object sender, EventArgs e)
        {
            Persons person = new Persons();
            person.Adress = formAdress.Text;
        }
        private void Add_Click(object sender, EventArgs e)
        {
            ExcelWriting writing = new ExcelWriting();
            writing.WriteData();
            MessageBox.Show("Excelfil skapad");
        }
    }
}


namespace AdressBokProjektet
{
    public class Persons
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }

        public Persons() { }    

        public Persons(string firstName, string lastName, string adress)
            : this()
        {
            FirstName = firstName;
            LastName = lastName;
            Adress = adress;
        }
    }
}

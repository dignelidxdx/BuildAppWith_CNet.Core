namespace NETCORE.Entidades
{
    class School{

        string nameSchool;
        public string Name
        {
            get { return "Copy: " + nameSchool; }
            set { nameSchool = value.ToUpper(); }
        }

        public int BornYear { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        private int myVar;

        public SchoolType SchoolType{ get; set; }

        public School(string name, int year) => (this.nameSchool, BornYear) = (name, year);

        public override string ToString()
        {
            return $"Name: {Name}, Type: {SchoolType} \nCountry: {Country}; City: {City}";
        }

    }

    


}
using System;
using System.Collections.Generic;

namespace NETCORE.Entidades
{
    class School{

        public string UniqueId { get; private set; } = Guid.NewGuid().ToString();
        string NameSchool;
        public string Name
        {
            get { return "Copy: " + NameSchool; }
            set { NameSchool = value.ToUpper(); }
        }

        public int BornYear { get; set; }

        public string Country { get; set; }

        public string City { get; set; }

        public SchoolType SchoolType{ get; set; }

        public List<Course> Courses { get; set; }

        public School(string name, int year) => (this.NameSchool, BornYear) = (name, year);

        public School(string name, int year, 
                       SchoolType type, 
                       string country = "", string city = "") : base()
        {
            (NameSchool, BornYear) = (name, year);
            Country = country;
            City = city;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {SchoolType} \nCountry: {Country}; City: {City}";
        }

    }

    


}
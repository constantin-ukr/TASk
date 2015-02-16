using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using Common;

namespace T3Service
{
    public class T3Implementation: IT3Interface
    {
        public List<Seminar> GetSeminars()
        {
            List<Common.Seminar> allSeminars = new List<Seminar>();

            Seminar sem1 = new Common.Seminar();
            sem1.ID = 1;
            sem1.Name =  "C#";
            
            Seminar sem2 = new Common.Seminar();
            sem2.ID = 2;
            sem2.Name =  "ASP.NET";

            allSeminars.Add(sem1);
            allSeminars.Add(sem2);

            return allSeminars;
        }

        public List<Person> GetPersons()
        {
            List<Person> allPersons = new List<Person>();

            Person p1 = new Person();
            p1.ID = 1;
            p1.Name = "Petro";
            p1.Address = "34 Dodoshenko st.";
            p1.Zip = "47003";
            
            Person p2 = new Person();
            p2.ID = 1;
            p2.Name = "Vasya";
            p2.Address = "11 Dodoshenko st.";
            p2.Zip = "47005";

            allPersons.Add(p1);
            allPersons.Add(p2);

            return allPersons;
        }

        public void AddPersons(List<Person> newPersons)
        {
            throw new NotImplementedException();
        }

        public void RemovePersons(List<Person> remPersons)
        {
            throw new NotImplementedException();
        }

        public void UpdatePersons(List<Person> updPersons)
        {
            throw new NotImplementedException();
        }
    }
}

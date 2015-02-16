using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
using Common;
using DataAccess;


namespace T3Service
{
    public class T3Implementation: IT3Interface
    {
        /// <summary>
        /// Отримати типізований список усіх семінарів
        /// </summary>
        /// <returns>Список усіх семінарів</returns>
        public List<Seminar> GetSeminars()
        {
            return DAL.GetSeminars();
        }

        /// <summary>
        /// Отримати типізований список усіх лекторів
        /// </summary>
        /// <returns>Список усіх лекторів</returns>
        public List<Person> GetPersons()
        {
            return DAL.GetPersons();
        }

        /// <summary>
        /// Додати нового запису про лектора в DataAccess
        /// </summary>
        /// <param name="newPersons">Типізоване представлення запису лектора</param>
        public void AddPersons(List<Person> newPersons)
        {
            foreach (Person person in newPersons)
            {
                DAL.AddNewPerson(person);
            }
        }

        /// <summary>
        /// Видалення запису про лектора в DataAccess
        /// </summary>
        /// <param name="remPersons">Типізоване представлення запису лектора</param>
        public void RemovePersons(List<Person> remPersons)
        {
            foreach (Person person in remPersons)
            {
                DAL.DaletePerson(person);
            }
        }

        /// <summary>
        /// Оновлення типізованого запису лектора
        /// </summary>
        /// <param name="newPersons">Запис який зберігає нові дані</param>
        /// <param name="oldPersons">Запис який зберігає старі дані</param>
        public void UpdatePersons(List<Person> newPersons, List<Person> oldPersons)
        {
            foreach (Person newPerson in newPersons)
            {
                foreach (Person oldPerson in oldPersons)
                {
                    if (newPerson.ID == oldPerson.ID)
                    {
                        if (newPerson.Name != oldPerson.Name
                            || newPerson.Birthday != oldPerson.Birthday
                            || newPerson.Address != oldPerson.Address
                            || newPerson.City != oldPerson.City
                            || newPerson.Zip != oldPerson.Zip
                            || newPerson.Tax != oldPerson.Tax
                            || newPerson.Memo != oldPerson.Memo)
                        {
                            DAL.UpdatePerson(newPerson);
                        }
                    }
                    else
                    {
                        continue;
                    }
                }
            }
        }
        
        /// <summary>
        /// Створення асоціації між семінаром та списком лекторів
        /// </summary>
        /// <param name="sem">Типізоване представлення запису семінар</param>
        /// <param name="persons">Типізований список лекторів</param>
        public void AddAssociationSem_Per(Seminar sem, List<Person> persons)
        {
            StringBuilder IDs = new StringBuilder();
            for (int i = 0, len = persons.Count; i < len; i++)
            {
                IDs.Append(persons[i].ID + ", ");
            }

            DAL.AddAssociationSemToPer(sem.Name, IDs.Remove(IDs.Length-1, 1).ToString());
        }

        /// <summary>
        ///  Створення асоціації між лектором та списком семінарів
        /// </summary>
        /// <param name="person">Типізоване представлення запису лектор</param>
        /// <param name="seminars">Типізований список семінарів</param>
        public void AddAssociationPer_Sem(Person person, List<Seminar> seminars)
        {
            StringBuilder IDs = new StringBuilder();
            for (int i = 0, len = seminars.Count; i < len; i++)
            {
                
                IDs.Append(seminars[i].ID + ", ");
            }

            DAL.AddAssociationPerToSem(person.ID, IDs.Remove(IDs.Length - 1, 1).ToString());
        }

        /// <summary>
        /// Видалення асоціації між лектором та списком семінарів
        /// </summary>
        /// <param name="person">Типізоване представлення запису лектор</param>
        /// <param name="seminars">Типізований список семінарів</param>
        public void RemoveAssociationPer_Sem(Person person, List<Seminar> seminars)
        {
            StringBuilder IDs = new StringBuilder();
            for (int i = 0, len = seminars.Count; i < len; i++)
            {
                IDs.Append(seminars[i].ID + ", ");
            }

            DAL.DeleteAssociationPerToSem(person.ID, IDs.Remove(IDs.Length - 1, 1).ToString());
        }
    }
}

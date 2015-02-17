using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.Serialization;
using System.ServiceModel;

namespace Common
{
    [ServiceContract]
    public interface IT3Interface
    {
        [OperationContract]
        List<Seminar> GetSeminars();

        [OperationContract]
        List<Person> GetPersons();

        [OperationContract]
        List<Person> GetPersonsForSeminar(Seminar seminar);

        [OperationContract]
        List<Seminar> GetSeminarsForPerson(Person person);

        [OperationContract]
        void AddPersons(List<Person> newPersons);

        [OperationContract]
        void RemovePersons(List<Person> remPersons);

        [OperationContract]
        void UpdatePersons(List<Person> newPersons, List<Person> oldPersons);

        [OperationContract]
        void AddAssociationSem_Per(Seminar sem, List<Person> persons);

        [OperationContract]
        void AddAssociationPer_Sem(Person person, List<Seminar> seminars);

        [OperationContract]
        void RemoveAssociationPer_Sem(Person person, List<Seminar> seminars);

        [OperationContract]
        bool IsRun();

    }
}

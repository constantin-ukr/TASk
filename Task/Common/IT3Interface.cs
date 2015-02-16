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
        void AddPersons(List<Person> newPersons);

        [OperationContract]
        void RemovePersons(List<Person> remPersons);

        [OperationContract]
        void UpdatePersons(List<Person> updPersons);
    }
}

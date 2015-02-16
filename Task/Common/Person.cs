using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.Runtime.Serialization;
namespace Common
{
    [DataContract]
    public class Person
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public DateTime? Birthday { get; set; }
        [DataMember]
        public string Address { get; set; }
        [DataMember]
        public string Zip { get; set; }
        [DataMember]
        public string City { get; set; }
        [DataMember]
        public string Tax { get; set; }
        [DataMember]
        public string Memo { get; set; }
        
        public override string ToString()
        {
            return String.Format(
                "Імя: {0}{7}Дата народження:{1}{7}Адреса:{2}{7}Індекс:{3}{7}Місто:{4}{7}Тах:{5}{7}Опис:{6}{7}",
                    Name, Birthday, Address, Zip, City, Tax, Memo, Environment.NewLine);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Provider;
using System.Data;
using Common;


namespace DataAccess
{
    public static class DAL
    {
        private static Provider.Provider _provider = new Provider.Provider();        
        
        public static List<Person> GetPersonsForSeminar(int seminarID)
        {
            string query = String.Format(
                    "select p.[ID],p.[Name],p.[BirthDate],p.[Address],p.[Zip],p.[City],p.[Tax],p.[Memo] "+
                    "from Seminar s inner join QualRef q on s.ID = q.SemID inner join Person p on p.ID = q.PerID " +
                    "where s.ID = {0};", seminarID);

            List<Person> persons = new List<Person>();

            using (IDbConnection sqlCon = _provider.DbConnection)
            {                
                IDbCommand sqlCom = _provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;

                try
                {                    
                    sqlCon.Open();

                    IDataReader sdr = sqlCom.ExecuteReader();

                    while (sdr.Read())
                    {
                        Person person = new Person();
                        person.ID = sdr.GetInt32(0);
                        person.Name = sdr.GetString(1);
                        person.Birthday = Convert.ToDateTime(sdr.GetString(2));
                        person.Address = sdr.GetString(3);
                        person.Zip = sdr.GetString(4);
                        person.City = sdr.GetString(5);
                        person.Tax = sdr.GetString(6);
                        person.Memo = sdr.GetString(4);
                        persons.Add(person);
                    }
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
            }
            
            return persons;
        }

        public static List<Seminar> GetSeminarsForPerson(int personID)
        {
            string query = String.Format(
                    "select s.[ID],s.[Name] from Seminar s inner join QualRef q on s.ID = q.SemID "+
                    "inner join Person p on p.ID = q.PerID where p.ID = {0};", personID);

            List<Seminar> seminars = new List<Seminar>();

            using (IDbConnection sqlCon = _provider.DbConnection)
            {
                IDbCommand sqlCom = _provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;

                try
                {
                    sqlCon.Open();

                    IDataReader sdr = sqlCom.ExecuteReader();

                    while (sdr.Read())
                    {
                        Seminar seminar = new Seminar();
                        seminar.ID = sdr.GetInt32(0);
                        seminar.Name = sdr.GetString(1);                        
                        seminars.Add(seminar);
                    }
                }
                catch (Exception ex)
                {
                    //_service.ShowError(ex.Message + "\n" + ex.Source);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
            }

            return seminars;
        }

            
        // список семінарів
        public static List<Seminar> GetSeminars()
        {
            List<Seminar> seminars = new List<Seminar>();

            string query = String.Empty;

            query = "SELECT [ID], [Name] FROM [Seminar] ORDER BY [Name];";
                        
            using (IDbConnection sqlCon = _provider.DbConnection)
            {
                IDbCommand sqlCom = _provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;

                try
                {
                    sqlCon.Open();

                    IDataReader sdr = sqlCom.ExecuteReader();

                    while (sdr.Read())
                    {
                         Seminar seminar = new Seminar();

                        seminar.ID = sdr.GetInt32(0);
                        seminar.Name = sdr.GetString(1);

                        seminars.Add(seminar);
                    }
                }
                catch (Exception ex)
                {
                    //_service.ShowError(ex.Message + "\n" + ex.Source);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
            }
                       
            return seminars;
            
        }

        // список лекторів
        public static List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();

            string query = String.Empty;

            query = "SELECT [ID], [Name], [BirthDate], [Address], [Zip], [City], [Tax],	[Memo] FROM Person ORDER BY [Name];";
            
            using (IDbConnection sqlCon = _provider.DbConnection)
            {
                IDbCommand sqlCom = _provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;

                try
                {
                    sqlCon.Open();

                    IDataReader sdr = sqlCom.ExecuteReader();

                    while (sdr.Read())
                    {
                        Person person = new Person();
                        person.ID = sdr.GetInt32(0);
                        person.Name = sdr.GetString(1);

                        bool date = sdr.IsDBNull(2); 
                            
                        if (!sdr.IsDBNull(2))
                        {
                            person.Birthday = Convert.ToDateTime(sdr.GetString(2));
                        }
                        else
                        {
                            person.Birthday = null;
                        }
                        person.Address = !sdr.IsDBNull(3) ? sdr.GetString(3) : null;
                        person.Zip = !sdr.IsDBNull(4) ? sdr.GetString(4) : null;
                        person.City = !sdr.IsDBNull(5) ? sdr.GetString(5) : null;
                        person.Tax = !sdr.IsDBNull(6) ? sdr.GetString(6) : null;
                        person.Memo = !sdr.IsDBNull(7) ? sdr.GetString(7) : null;
                        
                        persons.Add(person);
                    }
                }
                catch (Exception ex)
                {
                    //_service.ShowError(ex.Message + "\n" + ex.Source);
                    //string temp = ex.Message;
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
            }
            return persons;            
        }

        public static void AddAssociationSemToPer(string semName, string listId)
        {

            string query = String.Format(
                "insert into [QualRef](SemID,PerID ) select (select ID from Seminar where Name = '{0}') as SemID,PerID " +
                "from [QualRef] where [SemID] = (select ID from Seminar where Name = '{0}') and PerID not in ({1}})",
                semName, listId);

            using (IDbConnection sqlCon = _provider.DbConnection)
            {
                IDbCommand sqlCom = _provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;

                try
                {
                    sqlCon.Open();

                    sqlCom.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //_service.ShowError(ex.Message + "\n" + ex.Source);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
            }

        }

        public static void AddNewPerson(Person person)
        {
            string query = String.Format(
                "INSERT INTO [Person]([Name],[BirthDate],[Address],[Zip],[City],[Tax],[Memo]) " +
                "VALUES ('{0}',{1},'{2}','{3}','{4}','{5}','{6}');",
                person.Name, person.Birthday, person.Address, person.Zip,person.City, person.Tax, person.Memo);
            
            using (IDbConnection sqlCon = _provider.DbConnection)
            {
                IDbCommand sqlCom = _provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;

                try
                {
                    sqlCon.Open();

                    sqlCom.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //_service.ShowError(ex.Message + "\n" + ex.Source);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
            }
        }

        public static void DaletePerson(Person person)
        {
            string query = String.Format(
                "delete from [QualRef] where PerID={0}; " +
                "delete from [Person] where ID = {0};",
                person.ID);

            using (IDbConnection sqlCon = _provider.DbConnection)
            {
                IDbCommand sqlCom = _provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;

                try
                {
                    sqlCon.Open();

                    sqlCom.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //_service.ShowError(ex.Message + "\n" + ex.Source);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
            }
        }

        public static void UpdatePerson(Person newPerson)
        {
            string query = String.Format(
                "UPDATE [dbo].[Person] SET [Name] = '{0}', [BirthDate] = '{1}', [Address] = '{2}', [Zip] ='{3}', "+
                "[City] = '{4}', [Tax] = '{5}', [Memo] = '{6}' WHERE ID = {7};",
                newPerson.Name, newPerson.Birthday, newPerson.Address, newPerson.Zip, newPerson.City, newPerson.Tax,
                newPerson.Memo,newPerson.ID);

            using (IDbConnection sqlCon = _provider.DbConnection)
            {
                IDbCommand sqlCom = _provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;

                try
                {
                    sqlCon.Open();

                    sqlCom.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //_service.ShowError(ex.Message + "\n" + ex.Source);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
            }
        }

        public static void AddAssociationPerToSem(int pID, string listId)
        {
            string query = String.Format(
               "insert into [QualRef](PerID, SemID) select {0} as PerID,  " +
               "from [QualRef] where [SemID] = (select ID from Seminar where Name = '{0}') and PerID not in ({1}})",
               pID, listId);

            using (IDbConnection sqlCon = _provider.DbConnection)
            {
                IDbCommand sqlCom = _provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;

                try
                {
                    sqlCon.Open();

                    sqlCom.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //_service.ShowError(ex.Message + "\n" + ex.Source);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
            }
        }

        public static void DeleteAssociationPerToSem(int pID, string listId)
        {
            string query = String.Format(
               "delete from [QualRef] where PerId= {0} and SemID in ({1});",
               pID, listId);

            using (IDbConnection sqlCon = _provider.DbConnection)
            {
                IDbCommand sqlCom = _provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;

                try
                {
                    sqlCon.Open();

                    sqlCom.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    //_service.ShowError(ex.Message + "\n" + ex.Source);
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
            }
        }
    }


}

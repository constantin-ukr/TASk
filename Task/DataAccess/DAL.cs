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
        private static string _connString;
        static DAL()
        {
            _connString = Provider.Provider.DbConnection.ConnectionString;
        }
        public static List<Person> GetPersonsForSeminar(int seminarID)
        {
            string query = String.Format(
                    "select p.[ID],p.[Name],p.[BirthDate],p.[Address],p.[Zip],p.[City],p.[Tax],p.[Memo] "+
                    "from Seminar s inner join QualRef q on s.ID = q.SemID inner join Person p on p.ID = q.PerID " +
                    "where s.ID = {0};", seminarID);

            List<Person> persons = new List<Person>();

            using (IDbConnection sqlCon = Provider.Provider.DbConnection)
            {                
                IDbCommand sqlCom = Provider.Provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;
                sqlCom.Connection.ConnectionString = _connString;
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
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
            }
            
            return persons;
        }

        public static int GetID()
        {
            string query = "Select Max(ID) from Person;";

            int maxID = 0; 

            using (IDbConnection sqlCon = Provider.Provider.DbConnection)
            {
                IDbCommand sqlCom = Provider.Provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;

                sqlCom.Connection.ConnectionString = _connString;
                try
                {
                    sqlCon.Open();

                    //IDataReader sdr =
                     maxID = Convert.ToInt32(sqlCom.ExecuteScalar());// ExecuteReader();

                    /*while (sdr.Read())
                    {
                        maxID = sdr.GetInt32(0);
                    }*/
                }
                catch (Exception ex)
                {
                    //_service.ShowError(ex.Message + "\n" + ex.Source);
                    //string message = ex.Message;
                }
                finally
                {
                    if (sqlCon.State == ConnectionState.Open)
                        sqlCon.Close();
                }
            }

            return maxID;
        }


        public static List<Seminar> GetSeminarsForPerson(int personID)
        {
            string query = String.Format(
                    "select s.[ID],s.[Name] from Seminar s inner join QualRef q on s.ID = q.SemID "+
                    "inner join Person p on p.ID = q.PerID where p.ID = {0};", personID);

            List<Seminar> seminars = new List<Seminar>();

            using (IDbConnection sqlCon = Provider.Provider.DbConnection)
            {
                IDbCommand sqlCom = Provider.Provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;
                sqlCom.Connection.ConnectionString = _connString;
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
                        
            using (IDbConnection sqlCon = Provider.Provider.DbConnection)
            {
                IDbCommand sqlCom = Provider.Provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;

                sqlCom.Connection.ConnectionString = _connString;
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
                    string message = ex.Message;
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
            
            using (IDbConnection sqlCon = Provider.Provider.DbConnection)
            {
                IDbCommand sqlCom = Provider.Provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;
                                
                sqlCom.Connection.ConnectionString = _connString;
                try
                {
                    sqlCon.Open();

                    IDataReader sdr = sqlCom.ExecuteReader();

                    while (sdr.Read())
                    {
                        Person person = new Person();
                        person.ID = sdr.GetInt32(0);
                        person.Name = sdr.GetString(1);
                                                                            
                        if (!sdr.IsDBNull(2))
                        {
                            person.Birthday = Convert.ToDateTime(sdr.GetDateTime(2));
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

        public static void AddAssociationSemToPer(string semName, int[] pID)
        {
            StringBuilder query = new StringBuilder();
            for (int i = 0, len = pID.Length; i < len; i++)
			{
			    query.Append(String.Format("insert into [QualRef](SemID,PerID )  select distinct (select ID from Seminar where Name = '{0}') as SemID, {1} " +
                    "from [QualRef] where (select Count(PerID) from [QualRef] where [SemID] = (select ID from Seminar where Name = '{0}') and PerID = {1}) = 0; ",
                    semName, pID[i]));
			}
            

            using (IDbConnection sqlCon = Provider.Provider.DbConnection)
            {
                IDbCommand sqlCom = Provider.Provider.DbCommand;
                sqlCom.CommandText = query.ToString();
                sqlCom.Connection = sqlCon;
                sqlCom.Connection.ConnectionString = _connString;

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
                "VALUES ('{0}',convert(datetime,'{1}',103),'{2}','{3}','{4}','{5}','{6}');",
                person.Name, person.Birthday, person.Address, person.Zip,person.City, person.Tax, person.Memo);
            
            using (IDbConnection sqlCon = Provider.Provider.DbConnection)
            {
                IDbCommand sqlCom = Provider.Provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;
                sqlCom.Connection.ConnectionString = _connString;

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

            using (IDbConnection sqlCon = Provider.Provider.DbConnection)
            {
                IDbCommand sqlCom = Provider.Provider.DbCommand;
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

            using (IDbConnection sqlCon = Provider.Provider.DbConnection)
            {
                IDbCommand sqlCom = Provider.Provider.DbCommand;
                sqlCom.CommandText = query;
                sqlCom.Connection = sqlCon;
                sqlCom.Connection.ConnectionString = _connString;
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

        public static void AddAssociationPerToSem(int pID, int[] sID)
        {

            StringBuilder query = new StringBuilder();
            for (int i = 0, len = sID.Length; i < len; i++)
            {
                query.Append(
                    String.Format("insert into [QualRef](PerID, SemID) " +
                    "select distinct {0}, {1} from QUALREF " +
                    "where (select Count(SemID) from QUALREF " +
                    "where PerID = {0}  and SemID = {1}) = 0 ;",
                    pID, sID[i]));
            }

            using (IDbConnection sqlCon = Provider.Provider.DbConnection)
            {
                IDbCommand sqlCom = Provider.Provider.DbCommand;
                sqlCom.CommandText = query.ToString();
                sqlCom.Connection = sqlCon;
                sqlCom.Connection.ConnectionString = _connString;
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

        public static void DeleteAssociationPerToSem(int pID, int[] sID)
        {
            StringBuilder query = new StringBuilder();
            for (int i = 0, len = sID.Length; i < len; i++)
            {
                query.Append(
                    String.Format("delete from [QualRef] where PerId= {0} and SemID = {1};", pID, sID[i]));
            }

            using (IDbConnection sqlCon = Provider.Provider.DbConnection)
            {
                IDbCommand sqlCom = Provider.Provider.DbCommand;
                sqlCom.CommandText = query.ToString();
                sqlCom.Connection = sqlCon;
                sqlCom.Connection.ConnectionString = _connString;
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

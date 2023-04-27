using System.Collections.Generic;
using cassandra_demo.DL;
using cassandra_demo.Model;

namespace cassandra_demo.DAL
{
    internal class IdolDAO
    {
        private readonly CassandraCore _cassandraCore;

        public IdolDAO()
        {
            _cassandraCore = new CassandraCore();
        }

        public IEnumerable<Idol> GetAllIdol()
        {
            var query =
                "SELECT " +
                "stage_name, " +
                "full_name, " +
                "date_of_birth, " +
                "group, " +
                "country, " +
                "birthplace, " +
                "gender, " +
                "instagram " +
                "FROM " +
                Constants.TableName;
            return _cassandraCore.ExecuteLoadQuery<Idol>(query);
        }

        public void InsertIdol(Idol idol)
        {
            var query =
                "INSERT INTO " +
                Constants.TableName +
                "(stage_name, full_name, date_of_birth, group, country, birthplace, gender, instagram) " +
                "VALUES(" +
                "'" + idol.StageName + "', " +
                "'" + idol.FullName + "', " +
                "'" + idol.DateOfBirth + "', " +
                "'" + idol.Group + "', " +
                "'" + idol.Country + "', " +
                "'" + idol.BirthPlace + "', " +
                "'" + idol.Gender + "', " +
                "'" + idol.Instagram + "'" +
                ")";
            _cassandraCore.ExecuteNonQuery(query);
        }

        public IEnumerable<Idol> SearchIdol(string key)
        {
            var query =
                "SELECT " +
                "stage_name, " +
                "full_name, " +
                "date_of_birth, " +
                "group, " +
                "country, " +
                "birthplace, " +
                "gender, " +
                "instagram " +
                "FROM " +
                Constants.TableName + " " +
                "WHERE " +
                "stage_name = '" + key + "'";
            return _cassandraCore.ExecuteLoadQuery<Idol>(query);
        }

        public void UpdateIdol(Idol idol)
        {
            var query =
                "UPDATE " +
                Constants.TableName + " " +
                "SET " +
                "date_of_birth = '" + idol.DateOfBirth + "', " +
                "group = '" + idol.Group + "', " +
                "country = '" + idol.Country + "', " +
                "birthplace = '" + idol.BirthPlace + "', " +
                "gender = '" + idol.Gender + "', " +
                "instagram = '" + idol.Instagram + "' " +
                "WHERE " +
                "stage_name = '" + idol.StageName + "' " +
                "AND " +
                "full_name = '" + idol.FullName + "'";
            _cassandraCore.ExecuteNonQuery(query);
        }

        public void DeleteIdol(string key)
        {
            var query =
                "DELETE FROM " +
                Constants.TableName + " " +
                "WHERE " +
                "stage_name = '" + key + "'";
            _cassandraCore.ExecuteNonQuery(query);
        }
    }
}
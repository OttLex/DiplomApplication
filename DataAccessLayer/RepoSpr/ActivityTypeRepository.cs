using Model.ModelSpr;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

namespace DataAccessLayer.RepoSpr
{
    public class ActivityTypeRepository : IRepository<ActivityType>
    {
        const string _tableName = "ActivityType";
        string connectionString = null;
        public ActivityTypeRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(ActivityType obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"insert into {_tableName} values('{obj.Description}', '{obj.Name}')");
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"delete {_tableName}  where Id= {id}");
            }
        }

        public ActivityType GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<ActivityType>($"SELECT * FROM {_tableName} where Id= {id}").FirstOrDefault();
            }
        }

        public List<ActivityType> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<ActivityType>("SELECT * FROM " + _tableName).ToList();
            }
        }

        public void Update(ActivityType obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"UPDATE {_tableName} SET Name= '{obj.Name}', Description= '{obj.Description}' WHERE id={obj.Id}");
            }
        }
    }
}

using Model.ModelSpr;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

namespace DataAccessLayer.RepoSpr
{
    public class ActivityRepository : IRepository<Activity>
    {
        const string _tableName = "Activity";
        string connectionString = null;
        public ActivityRepository(string conn)
        {
            connectionString = conn;
        }
        public void Create(Activity obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
               // db.Query($@"insert into {_tableName} values('{obj.Name}', {obj.ObjectId}, {obj.NumberOfZoom}, {obj.ActivityTypeId}, '{obj.Description}')");
                db.Query($@"insert into {_tableName} values({obj.IdBackground}, {obj.ObjectId}, {obj.ActivityTypeId}, '{obj.Description}', '{obj.Name}')");
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"delete {_tableName}  where Id= {id}");
            }
        }

        public Activity GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Activity>($"SELECT * FROM {_tableName} where Id= {id}").FirstOrDefault();
            }
        }

        public List<Activity> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Activity>("SELECT * FROM " + _tableName).ToList();
            }
        }

        public void Update(Activity obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                //db.Query($@"UPDATE {_tableName} SET Name= '{obj.Name}', ObjectId={obj.ObjectId}, NumberOfZoom={obj.NumberOfZoom}, ActivityTypeId={obj.ActivityTypeId}, Description= '{obj.Description}' WHERE id={obj.Id}");
                db.Query($@"UPDATE {_tableName} SET IdBackground = {obj.IdBackground}, Name= '{obj.Name}', ObjectId={obj.ObjectId}, ActivityTypeId={obj.ActivityTypeId}, Description= '{obj.Description}' WHERE id={obj.Id}");
            }
        }
    }
}

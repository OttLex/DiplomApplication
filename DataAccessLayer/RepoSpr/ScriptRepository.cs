using Model.ModelRelations;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;
using Model.ModelsSpr;

namespace DataAccessLayer.RepoSpr
{
    public class ScriptRepository : IRepository<Script>
    {
        const string _tableName = "Script";
        string connectionString = null;
        public ScriptRepository(string conn)
        {
            connectionString = conn;
        }
        public void Create(Script obj)
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
                db.Query($@"delete {_tableName}  where id= {id}");
            }
        }

        public Script GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Script>($"SELECT * FROM {_tableName} where Id= {id}").FirstOrDefault();
            }
        }

        public List<Script> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Script>("SELECT * FROM " + _tableName).ToList();
            }
        }

        public void Update(Script obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"UPDATE {_tableName} SET Name= '{obj.Name}', Description = '{obj.Description}' WHERE Id={obj.Id}");
            }
        }
    }
}

using Model.ModelRelations;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

namespace DataAccessLayer.RepoRel
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
                db.Query($@"insert into {_tableName} values({obj.IdBlocks}, {obj.IdBackground}, {obj.IdActivity})");
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
                db.Query($@"UPDATE {_tableName} SET IdBlocks = {obj.IdBlocks}, IdBackground={obj.IdBackground}, IdActivity={obj.IdActivity} WHERE Id={obj.Id} and IdScript={obj.IdScript}");
            }
        }
    }
}

using Model.ModelRelations;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

namespace DataAccessLayer.RepoRel
{
    public class ScriptDataRepository : IRepository<ScriptData>
    {
        const string _tableName = "ScriptData";
        string connectionString = null;
        public ScriptDataRepository(string conn)
        {
            connectionString = conn;
        }
        public void Create(ScriptData obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                //db.Query($@"insert into {_tableName} values({obj.IdScript},{obj.NumberOfStep},{obj.IdBlocks}, {obj.IdBackground}, {obj.IdActivity})");
                db.Query($@"insert into {_tableName} values({obj.IdScript},{obj.NumberOfStep},{obj.IdBlocks}, {obj.IdActivity})");
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"delete {_tableName}  where id= {id}");
            }
        }

        public ScriptData GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<ScriptData>($"SELECT * FROM {_tableName} where Id= {id}").FirstOrDefault();
            }
        }

        public List<ScriptData> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<ScriptData>("SELECT * FROM " + _tableName).ToList();
            }
        }

        public void Update(ScriptData obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
               // db.Query($@"UPDATE {_tableName} SET NumberOfStep={obj.NumberOfStep}, IdBlocks = {obj.IdBlocks}, IdBackground={obj.IdBackground}, IdActivity={obj.IdActivity} WHERE Id={obj.Id} and IdScript={obj.IdScript}");
                db.Query($@"UPDATE {_tableName} SET NumberOfStep={obj.NumberOfStep}, IdBlocks = {obj.IdBlocks}, IdActivity={obj.IdActivity} WHERE Id={obj.Id} and IdScript={obj.IdScript}");
            }
        }
    }
}

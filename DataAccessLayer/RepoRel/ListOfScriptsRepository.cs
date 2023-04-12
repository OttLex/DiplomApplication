using Model.ModelRelations;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

namespace DataAccessLayer.RepoRel
{
    public class ListOfScriptsRepository : IRepository<ListOfScripts>
    {
        const string _tableName = "ListOfScripts";
        string connectionString = null;
        public ListOfScriptsRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(ListOfScripts obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"insert into {_tableName} values({obj.IdScript},'{obj.Name}','{obj.Description}')");
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"delete {_tableName}  where id= {id}");
            }
        }

        public ListOfScripts GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<ListOfScripts>($"SELECT * FROM {_tableName} where Id= {id}").FirstOrDefault();
            }
        }

        public List<ListOfScripts> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<ListOfScripts>("SELECT * FROM " + _tableName).ToList();
            }
        }

        public void Update(ListOfScripts obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"UPDATE {_tableName} SET IdScript= {obj.IdScript}, Name= '{obj.Name}', Description= '{obj.Description}' WHERE id={obj.Id}");
            }
        }
    }
}

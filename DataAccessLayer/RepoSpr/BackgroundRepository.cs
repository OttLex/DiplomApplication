using Model.ModelSpr;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

namespace DataAccessLayer.RepoSpr
{
    public class BackgroundRepository : IRepository<Background>
    {
        const string _tableName = "Background";
        string connectionString = null;
        public BackgroundRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(Background obj)
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

        public Background GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Background>($"SELECT * FROM {_tableName} where Id= {id}").FirstOrDefault();
            }
        }

        public List<Background> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Background>("SELECT * FROM " + _tableName).ToList();
            }
        }

        public void Update(Background obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"UPDATE {_tableName} SET Name= '{obj.Name}', Description= '{obj.Description}' WHERE id={obj.Id}");
            }
        }
    }
}

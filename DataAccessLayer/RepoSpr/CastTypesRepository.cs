using Model.ModelSpr;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

namespace DataAccessLayer.RepoSpr
{
    public class CastTypesRepository : IRepository<CastTypes>
    {
        const string _tableName = "CastTypes";
        string connectionString = null;
        public CastTypesRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(CastTypes obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"insert into {_tableName} values('{obj.Name}')");
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"delete {_tableName}  where Id= {id}");
            }
        }

        public CastTypes GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<CastTypes>($"SELECT * FROM {_tableName} where Id= {id}").FirstOrDefault();
            }
        }

        public List<CastTypes> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<CastTypes>("SELECT * FROM " + _tableName).ToList();
            }
        }

        public void Update(CastTypes obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"UPDATE {_tableName} SET Name= '{obj.Name}' WHERE id={obj.Id}");
            }
        }
    }
}

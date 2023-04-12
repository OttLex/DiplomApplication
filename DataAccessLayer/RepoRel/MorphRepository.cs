using Dapper;
using Microsoft.Data.SqlClient;
using Model.ModelRelations;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace DataAccessLayer.RepoRel
{
    public class MorphRepository : IRepository<Morph>
    {
        const string _tableName = "Morph";
        string connectionString = null;
        public MorphRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(Morph obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"insert into {_tableName} values({obj.IdMorph}, {obj.IdObjectInTheComposition})");
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"delete {_tableName}  where Id= {id}");
            }
        }

        public Morph GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Morph>($"SELECT * FROM {_tableName} where id= {id}").FirstOrDefault();
            }
        }

        public List<Morph> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Morph>("SELECT * FROM " + _tableName).ToList();
            }
        }

        public void Update(Morph obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"UPDATE {_tableName} SET IdObjectInTheComposition={obj.IdObjectInTheComposition} WHERE Id={obj.Id}");                
            }
        }
    }
}

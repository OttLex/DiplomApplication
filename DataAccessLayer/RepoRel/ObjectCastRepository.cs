using Model.ModelRelations;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DataAccessLayer.RepoRel
{
    public class ObjectCastRepository : IRepository<ObjectCast>
    {
        const string _tableName = "ObjectCast";
        string connectionString = null;
        public ObjectCastRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(ObjectCast obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"insert into {_tableName} values({obj.IdCastType}, {obj.IdObject}, {obj.IdStep})");
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"delete {_tableName}  where id= {id}");
            }
        }

        public ObjectCast GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<ObjectCast>($"SELECT * FROM {_tableName} where id= {id}").FirstOrDefault();
            }
        }

        public List<ObjectCast> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<ObjectCast>("SELECT * FROM " + _tableName).ToList();
            }
        }

        public void Update(ObjectCast obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"UPDATE {_tableName} SET IdCastType = {obj.IdCastType}, IdObject={obj.IdObject}, IdStep={obj.IdStep} WHERE id={obj.Id}");
            }
        }
    }
}

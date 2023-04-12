using Model.ModelSpr;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System;

namespace DataAccessLayer.RepoSpr
{
    public class BlockRepository : IRepository<Block>
    {
        const string _tableName = "Block";
        string connectionString = null;
        public BlockRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(Block obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"insert into {_tableName} values({obj.IdBackground} , '{obj.Name}', '{obj.Description}')");
            }
        }

        public void Delete(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"delete {_tableName}  where Id= {id}");
            }
        }

        public Block GetObject(int id)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Block>($"SELECT * FROM {_tableName} where Id= {id}").FirstOrDefault();
            }
        }

        public List<Block> GetObjects()
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                return db.Query<Block>("SELECT * FROM " + _tableName).ToList();
            }
        }

        public void Update(Block obj)
        {
            using (IDbConnection db = new SqlConnection(connectionString))
            {
                db.Query($@"UPDATE {_tableName} SET IdBackground= {obj.IdBackground}, Name= '{obj.Name}', Description= '{obj.Description}' WHERE id={obj.Id}");
            }
        }
    }
}

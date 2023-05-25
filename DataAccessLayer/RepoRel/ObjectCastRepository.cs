using Model.ModelRelations;
using Dapper;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
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
                // db.Query($@"insert into {_tableName} values({obj.IdCastType}, {obj.IdObject}, {obj.IdStep})");

                string idActivity = obj.IdActivity != null ? obj.IdBlock.ToString() : null;
                string idCastType = obj.IdCastType != null ? obj.IdCastType.ToString() : null;
                string idObjectSpent = obj.IdObjectSpent != null ? obj.IdObjectSpent.ToString() : null;
                string idObjectRecive = obj.IdObjectRecive != null ? obj.IdObjectRecive.ToString() : null;


                var parameters = new { 
                    tableName= _tableName,
                    IdBlock = obj.IdBlock,
                    IdBackground = obj.IdBackground,
                    IdActivity = idActivity,
                    IdStep = obj.IdStep,
                    IdCastType = idCastType,
                    IdObjectSpent= idObjectSpent,
                    IdObjectRecive= idObjectRecive,
                    Description= obj.Description
                };


                var sql = $@"insert into {_tableName} values(@IdBlock, @IdStep, 
                                                            @IdBackground,  @IdActivity, 
                                                            @IdCastType, @IdObjectSpent,
                                                            @IdObjectRecive, N'{obj.Description}')" ;


                db.Query(sql,parameters);


                //db.Query($@"insert into {_tableName} values({obj.IdBlock}, {obj.IdBackground}, 
                //                                            {obj.IdActivity}, {obj.IdStep}, 
                //                                            {obj.IdCastType}, {obj.IdObjectSpent},
                //                                            {obj.IdObjectRecive}, N'{obj.Description}')");
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

                string idActivity = obj.IdActivity != null ? obj.IdActivity.ToString() : null;
                string idCastType = obj.IdCastType != null ? obj.IdCastType.ToString() : null;
                string idObjectSpent = obj.IdObjectSpent != null ? obj.IdObjectSpent.ToString() : null;
                string idObjectRecive = obj.IdObjectRecive != null ? obj.IdObjectRecive.ToString() : null;


                var parameters = new
                {
                    tableName = _tableName,
                    IdBlock = obj.IdBlock,
                    IdBackground = obj.IdBackground,
                    IdActivity = idActivity,
                    IdStep = obj.IdStep,
                    IdCastType = idCastType,
                    IdObjectSpent = idObjectSpent,
                    IdObjectRecive = idObjectRecive,
                    Description = obj.Description
                };


                var sql = $@"UPDATE {_tableName} SET IdBlock =@IdBlock, IdStep=@IdStep, 
                                                            IdBackground= @IdBackground, IdActivity= @IdActivity, 
                                                            IdCastType= @IdCastType, IdObjectSpent= @IdObjectSpent,
                                                            IdObjectRecive= @IdObjectRecive, Description=N'{obj.Description}'";


                db.Query(sql, parameters);

                //db.Query($@"UPDATE {_tableName} SET IdCastType = {obj.IdCastType}, IdObject={obj.IdObject}, IdStep={obj.IdStep} WHERE id={obj.Id}");
                //db.Query($@"UPDATE {_tableName} SET IdBlock = {obj.IdBlock}, IdBackground={obj.IdBackground},
                //                                    IdActivity={obj.IdActivity}, IdStep={obj.IdStep},
                //                                    IdCastType={obj.IdCastType}, IdObjectSpent={obj.IdObjectSpent},
                //                                    IdObjectRecive={obj.IdObjectRecive}, Description=N'{obj.Description}'
                //                                    WHERE id={obj.Id}");
            }
        }
    }
}

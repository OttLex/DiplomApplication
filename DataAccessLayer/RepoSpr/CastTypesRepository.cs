using Model.ModelSpr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.RepoSpr
{
    public class CastTypesRepository : IRepository<CastTypes>
    {
        const string _tableName = "Objects";
        string connectionString = null;
        public CastTypesRepository(string conn)
        {
            connectionString = conn;
        }

        public void Create(CastTypes obj)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public CastTypes GetObject(int id)
        {
            throw new NotImplementedException();
        }

        public List<CastTypes> GetObjects()
        {
            throw new NotImplementedException();
        }

        public void Update(CastTypes obj)
        {
            throw new NotImplementedException();
        }
    }
}

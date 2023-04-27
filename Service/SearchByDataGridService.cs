using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class SearchByDataGridService<T> where T : AbstractSpr
    {
        List<T> _sourceList;
        string _searchQuery;

        public SearchByDataGridService(List<T> sourceList, string searchQuery)
        {
            _searchQuery=searchQuery;
            _sourceList = sourceList;
        }

        public List<T> Search()
        {
            List<T> result = (from row in _sourceList
                              where row.Name.Contains(_searchQuery)
                              select row).ToList();

            _sourceList =null;
            _sourceList= new List<T>();
            _sourceList.AddRange(result);

            return _sourceList;
        }

    }
}

using Model.DTO;
using Model.ModelRelations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CheckSpentAndReciveObjectsService
    {
        Inventory _inventory;
        List<ObjectCastDTO> _objectCasts;

        public CheckSpentAndReciveObjectsService(List<ObjectCastDTO> objectCasts)
        {
            _inventory = new Inventory();
            _objectCasts = objectCasts;
        }

        public List<String> Test()
        {
            List<String> result = new List<string>();


            foreach(ObjectCastDTO cast in _objectCasts)
            {
                bool canSpend = _inventory.DefineFromInventory(cast);
                bool canRecive = _inventory.AddToInventory(cast);

                if (canSpend == false || canRecive ==false)
                {
                    string row =  $"Проверка каста {cast.NameBlock}, шаг {cast.IdStep}: ";

                    if(canSpend == false)
                    {
                       row += "Трата: предмет невозможно потратить; ";
                    }
                    else
                    {
                        row += "Трата: предмет в порядке; ";
                    }

                    if (canRecive == false)
                    {
                        row += "Получение: предмет невозможно получить повторно; ";
                    }
                    else
                    {
                        row += "Трата: предмет в порядке; ";
                    }

                    result.Add(row);
                }
            }
            return result;
        }
    }

    internal class Inventory
    {
        public List<int> CurrentItems { private set; get; }

        public Inventory()
        {
            CurrentItems = new List<int>();
        }

        public bool AddToInventory(ObjectCastDTO cast)
        {
            if (cast.IdObjectRecive != null)
            {
                int count = CurrentItems.Where(i => i == cast.IdObjectRecive).Count();

                if (count == 0)
                {
                    CurrentItems.Add((int)cast.IdObjectRecive);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        public bool DefineFromInventory(ObjectCastDTO cast)
        {
            if (cast.IdObjectSpent != null)
            {
                int count = CurrentItems.Where(i => i == cast.IdObjectSpent).Count();

                if (count != 0)
                {
                    CurrentItems.Remove((int)cast.IdObjectSpent);
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}

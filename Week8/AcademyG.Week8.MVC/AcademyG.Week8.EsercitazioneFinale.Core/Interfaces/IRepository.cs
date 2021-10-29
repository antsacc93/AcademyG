using System;
using System.Collections.Generic;
using System.Text;

namespace AcademyG.Week8.EsercizioFinale.Core.Interfaces
{
    public interface IRepository<T>
    {
        
        bool AddItem(T newItem);
        bool RemoveItem(T item);
        IEnumerable<T> FetchAll();
    }
}

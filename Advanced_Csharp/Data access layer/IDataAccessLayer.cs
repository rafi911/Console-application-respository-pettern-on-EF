using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csharp.Data_access_layer
{
    interface IDataAccessLayer<T> where T : class
    {
        IEnumerable<T> SelectAll();
        bool Add(T newElement);
        bool Delete(object id);
        
    }
}

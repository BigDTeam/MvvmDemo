using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mvvm.Model
{
    class StudentDataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            var item = new DataItem("I'm as student!");
            callback(item,null);
        }
    }
}

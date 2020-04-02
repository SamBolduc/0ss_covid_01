using System;
using System.Collections.Generic;
using System.Text;

namespace BillingManagement.Models
{
    interface IDataService<T>
    {
        IEnumerable<T> GetAll();
    }
}

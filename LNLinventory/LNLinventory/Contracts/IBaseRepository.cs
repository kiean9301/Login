using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LNLinventory.Contracts
{
    public enum ErrorCode
    {
        Success,
        Error
    }
    interface IBaseRepository<T>
    {
        T Get(object id);
        List<T> Getall();
        ErrorCode Create(T t);
        ErrorCode Update(object id, T t);
        ErrorCode Delete(object id);
    }
}

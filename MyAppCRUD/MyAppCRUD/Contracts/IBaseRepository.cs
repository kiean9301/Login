using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppCRUD.Contracts
{
    public enum ErrorCode
    {
        Success,
        Error
    }
    public interface IBaseRepository<T>
    {
        T Get(object id);
        List<T> GetAll();
        ErrorCode Create();
        ErrorCode Update(object id,T t);
        ErrorCode Delete(object id);

        
    }
    public interface IBaseRepository<T>
    {
        T Get(object id);
        List<T> GetAll();
        ErrorCode Create();
        ErrorCode Update(object id, T t);
        ErrorCode Delete(object id);


    }
}

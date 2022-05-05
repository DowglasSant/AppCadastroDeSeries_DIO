using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T>
    {
        List<T> List();
        T ReturnByID(int id);        
        void Create(T entidade);        
        void Delete(int id);        
        void Update(int id, T entidade);
        int NextId();
    }
}
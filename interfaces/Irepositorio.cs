using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DioSeries.interfaces
{
    public interface Irepositorio<T>
    {
        List<T> Lista();
        T RetornaPorId(int Id);
        void Insere (T entidade);
        void Exclui(int id, T entidade);
        int  ProximoId();
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiagnosticoWeb.Model
{
    public interface IRepositorio<T> where T : class 
    {
        void Adicionar(T item);
        void Remover(T item);
        void Remover(object id);
        void Editar(T item);
        T ObtemPorId(object id);
        IQueryable<T> ObtemTodos();
    }
}
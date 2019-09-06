using System.Collections.Generic;

namespace BookManager.Domain.Interfaces.Service {
    public interface CRUDService<T> {
        T Add(T t);
        T Change(T t);
        void Remove(int id);
        T GetById(int id);
        IEnumerable<T> GetAll();
    }
}
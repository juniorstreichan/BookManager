using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace BookManager.WebAPI.Controllers {
    public interface CRUDController<T> {

        ActionResult<IEnumerable<T>> GetAll ();
        ActionResult<T> GetById (int id);
        ActionResult<T> Post (T entity);
        ActionResult<T> Put (T entity);
        ActionResult Delete (int id);

    }
}
namespace Core.Interfaces
{
  public interface IRepository<T>
    where T : class, new()
  {
    // only the update is let for the CRUD
    //T Entity Create(); 
    T Post(T entity);

    IEnumerable<T> GetAll();

    //T Entity GetByID(); 
    T GetByID(int id);

    //T Entity Delete(); 
    T Delete(T entity);

    T Update(T entity);
  }
}

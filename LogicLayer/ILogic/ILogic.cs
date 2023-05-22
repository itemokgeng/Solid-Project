namespace LogicLayer.ILogic
{
  public interface ILogic<T> 
    where T : class, new()
  {
    //READ
    List<T> GetAll();
    T GetByID(int id);
    //DELETE
    void Delete(T entity);

    //UPDATE
    T Update(T entity);

    //POST, CREATE
    T Post(T entity);
  }
}

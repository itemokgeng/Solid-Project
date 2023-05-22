using Core.Interfaces;
using DataLayer.Context;
using Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repository
{
  public class EmployeeRepository : IRepository<Employee>
  {
    private readonly EmployeeDBContext _contextEmp;

    //A constructor used to initilze objects 
    public EmployeeRepository(EmployeeDBContext context)
    {
      _contextEmp = context;
    }
    // CREATE// POST
    public Employee Post(Employee entity)
    {
      _contextEmp.Entry<Employee>(entity).State = EntityState.Added;
      _contextEmp.SaveChanges();
      return entity;
    }
    // DELETE
    public Employee Delete(Employee entity)
    {
      _contextEmp.Remove<Employee>(entity);
      _contextEmp.SaveChanges();
      return entity;
    }
    // GET ALL
    public IEnumerable<Employee> GetAll()
    {
      return _contextEmp.Employee.ToList();
    }
    // GETBYID
    public Employee? GetByID(int id)
    {
      return _contextEmp.Employee.FirstOrDefault(x => x.EmployeeID == id);
    }

    // Update
    public Employee Update(Employee entity)
    {
      _contextEmp.Entry<Employee>(entity).State = EntityState.Modified;
      _contextEmp.SaveChanges();
      return entity;
    }
  }
}

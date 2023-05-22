using Domain.Models;
using DataLayer.Context;
using Microsoft.EntityFrameworkCore;
using Core.Interfaces;

namespace DataLayer.Repository
{

  public class DepartmentRepository : IRepository<Department>
  {
    // field that im using to use the employeeContext
    private readonly EmployeeDBContext _contextDep;
    // A constructor used to initilze objects 
    public DepartmentRepository(EmployeeDBContext context)
    {
      _contextDep = context;
    }
    // CREATE
    public Department Post(Department entity)
    {
      _contextDep.Entry<Department>(entity).State = EntityState.Added;
      _contextDep.SaveChanges();
      return entity;
    }
    //DELETE
    public Department Delete(Department entity)
    {
      _contextDep.Remove<Department>(entity);
      _contextDep.SaveChanges();
      return entity;
    }
    //GET All
    public IEnumerable<Department> GetAll()
    {
      return _contextDep.Department.ToList();
    }
    // GETBYID
    public Department? GetByID(int id)
    {
      return _contextDep.Department.FirstOrDefault(x => x.DepartmentID == id);
    }
    
    public Department Update(Department entity)
    {
      _contextDep.Entry<Department>(entity).State = EntityState.Modified;
      _contextDep.SaveChanges();
      return entity;
    }
  }
}

using Core.Interfaces;
using DataLayer.Repository;
using Domain.Models;
using LogicLayer.ILogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.EmployeeLogic
{
  // this is the implementation of the inteface for the Employee
  public class EmployeeLogic : ILogic<Employee>
  {
    // here is where you put the repository class (employee)
    
    private readonly IRepository<Employee> _empRepo;
    // services are that are constructed 
    // constructed class
    // the implementation constructor
    public EmployeeLogic(IRepository<Employee> empRepo)
    {
      this._empRepo = empRepo;
    }
    // DELETE
    public void Delete(Employee entity)
    {
      _empRepo.Delete(entity);
    }
    // READ
    public List<Employee> GetAll()
    {
      return _empRepo.GetAll().ToList();
    }
    // READ
    public Employee GetByID(int id)
    {
      return _empRepo.GetByID(id);
    }
    //POST
    public Employee Post(Employee entity)
    {
      return _empRepo.Post(entity);
    }
    //UPDATE
    public Employee Update(Employee entity)
    {
      return _empRepo.Update(entity);
    }
  }
}

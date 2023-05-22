using Core.Interfaces;
using DataLayer.Repository;
using Domain.Models;
using LogicLayer.ILogic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer.DepartmentLogic
{
  // this is the implementation of the inteface for the Department 
  public class DepartmentLogic : ILogic<Department>
  {
    // here is where you put the repository class (department)

    private readonly IRepository<Department> _depRepo;
    // services are that are constructed
    // constructed class
    // the implementation constructor

    public DepartmentLogic(IRepository<Department> depRepo)
    {
      this._depRepo = depRepo;
    }
    // READ
    public List<Department> GetAll()
    {
      return _depRepo.GetAll().ToList();
    }
    // READBYID
    public Department GetByID(int id)
    {
      return _depRepo.GetByID(id);
    }
    //POST
    public Department Post(Department entity)
    {
      return _depRepo.Post(entity);
    }
    //UPDATE
    public Department Update(Department entity)
    {
      return _depRepo.Update(entity);
    }
    // DELETE
    public void Delete(Department entity)
    {
      _depRepo.Delete(entity);
    }
  }
}

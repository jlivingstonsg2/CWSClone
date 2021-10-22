using WebPage8.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage8.Data
{
    public class ComputerRepo : IComputerRepo
    {
        private readonly ApplicationDbContext _applicationDbContext;
        public ComputerRepo(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public Computer Create(Computer computer)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Computer> Read()
        {
            return _applicationDbContext.Computers
                .Include(c => c.Category)
                .Include(r => r.Reviews)
                .ToList();
        }

        public Computer Read(int id)
        {
            return _applicationDbContext.Computers
                .Include(c => c.Category)
                .Include(r => r.Reviews)
                .FirstOrDefault(c => c.ComputerId == id);
        }

        public Computer Update(Computer computer)
        {
            throw new NotImplementedException();
        }
    }
}

using WebPage8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebPage8.Data
{
    public interface IComputerRepo
    {
        public Computer Create(Computer computer);
        public List<Computer> Read();
        public Computer Read(int id);

        Computer Update(Computer computer);
        public bool Delete(int id);
    }
}

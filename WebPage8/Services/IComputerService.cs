using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Models;
using WebPage8.ViewModels;

namespace WebPage8.Services
{
    public interface IComputerService
    {
        Computer Add(CreateComputerViewModel person);
        ComputerViewModel All();
        ComputerViewModel FindBy(ComputerViewModel search);
        Computer FindBy(int id);
        Computer Edit(int id, Computer person);
        bool Remove(int id);
    }
}

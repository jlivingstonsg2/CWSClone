using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebPage8.Data;
using WebPage8.Models;
using WebPage8.ViewModels;

namespace WebPage8.Services
{
    public class ComputerService : IComputerService
    {
        private readonly IComputerRepo _computerRepo;
        private readonly ICategoryRepo _categoryRepo;
        public ComputerService(IComputerRepo computerRepo, ICategoryRepo categoryRepo)
        {
            _computerRepo = computerRepo;
            _categoryRepo = categoryRepo;
        }
        public Computer Add(CreateComputerViewModel person)
        {
            throw new NotImplementedException();
        }

        public ComputerViewModel All()
        {
            ComputerViewModel computerViewModel = new ComputerViewModel {
                Computers = _computerRepo.Read(),
                Categories = _categoryRepo.Read()
            };

            return computerViewModel;
        }

        public Computer Edit(int id, Computer person)
        {
            throw new NotImplementedException();
        }

        public ComputerViewModel FindBy(ComputerViewModel search)
        {
            search.Computers = _computerRepo.Read()
                .FindAll(
                    computer => computer.Name .Contains(search.Search, System.StringComparison.OrdinalIgnoreCase) ||
                                computer.Processor.Contains(search.Search, System.StringComparison.OrdinalIgnoreCase) ||
                                computer.RAM.Contains(search.Search, System.StringComparison.OrdinalIgnoreCase) ||
                                computer.Category.Name.Contains(search.Search, System.StringComparison.OrdinalIgnoreCase) 
                    );
            return search;
        }

        public Computer FindBy(int id)
        {
            return _computerRepo.Read(id);
        }

        public bool Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}

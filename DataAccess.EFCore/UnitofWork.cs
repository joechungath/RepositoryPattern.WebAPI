using Domain;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore
{
    public class UnitofWork : IUnitofWork
    {
        private readonly ApplicationContext _Context;
        public UnitofWork(ApplicationContext Context)
        {
            _Context = Context;
            Developers = new DeveloperRepository(_Context);
            Projects = new ProjectRepository(_Context);
        }
        public IDeveloperRepository Developers { get; private set; }

        public IProjectRepository Projects { get; private set; }

        public int Complete()
        {
            return _Context.SaveChanges();
        }

        public void Dispose()
        {
            _Context.Dispose();
        }
    }
}

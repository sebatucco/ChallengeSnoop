using ChallengeSnoop.Infraestructure.Repositories;
using ChallengeSnopp.Core.Entities;
using ChallengeSnopp.Core.Entities.EntityBase;
using ChallengeSnopp.Core.Interface;
using ChallengeSnopp.Infraestructure.Context;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSnoop.Infraestructure.UoW
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataContext _context;
        public IEmpleadoRespository EmpleadoRespository { get; }

        public UnitOfWork(DataContext context)
        {
            _context = context;
            EmpleadoRespository = new EmpleadoRespository(_context);
        }

       

        public void Dispose()
        {
            if (_context != null) _context.Dispose();
        }


        public void SaveChanges()
        {
            _context.SaveChanges();
        }

        public async Task SaveChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}

using ChallengeSnopp.Core.Entities;
using ChallengeSnopp.Core.Entities.EntityBase;
using ChallengeSnopp.Core.Interface;
using ChallengeSnopp.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSnoop.Infraestructure.Repositories
{
    public class BaseRepository<T> : IBaseRepository<T> where T : Entity
    {
        protected DataContext _context;

        protected DbSet<T> _entities;
        public BaseRepository(DataContext context)
        {
            _context = context;   
            _entities = context.Set<T>();
            
        }
        public async Task<T> Add(T entity)
        {
           _entities.Add(entity);
           await _context.SaveChangesAsync();
            return entity;

        }

        public async Task DeleteByIdAsync(int id)
        {
            var entityResult = await GetByIdAsync(id);
            _context.Set<T>().Remove(entityResult);
        }

        public async  Task<IEnumerable<T>> GetAllAsync()
        {
            return await _entities.ToListAsync();
        }

        public async  Task<T> GetByIdAsync(int id)
        {
            return await _entities.FindAsync(id);
        }

        public async  Task<T> Update(T entity)
        {
            _entities.Update(entity);
            await _context.SaveChangesAsync();
            return entity;
        }
    }
}

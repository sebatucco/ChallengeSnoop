using ChallengeSnopp.Core.Entities;
using ChallengeSnopp.Core.Entities.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeSnopp.Core.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IEmpleadoRespository EmpleadoRespository { get; }

        void SaveChanges();

        Task SaveChangesAsync();
    }
}

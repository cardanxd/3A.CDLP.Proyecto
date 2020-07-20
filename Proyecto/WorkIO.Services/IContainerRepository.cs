using System;
using System.Collections.Generic;
using System.Text;
using WorkIO.Models;

namespace WorkIO.Services
{
    public interface IContainerRepository : IRepository<Orden>
    {
        public IEnumerable<Candidato> GetCandidatos();
    }
}

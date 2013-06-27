using System.Collections.Generic;
using MyWebSite.Data;
using MyWebSite.Domain;

namespace MyWebSite.Service
{
    public class ReferentialService : IReferentialService
    {
        private readonly IReferentialRepository _referentialRepository;

        public ReferentialService(IReferentialRepository referentialRepository)
        {
            _referentialRepository = referentialRepository;
        }

        public IList<Entity1> GetAllEntities()
        {
            return _referentialRepository.GetAll();
        }
    }
}

using System.Collections.Generic;
using MyWebSite.Domain;

namespace MyWebSite.Service
{
    public class ReferentialService : IReferentialService
    {
        public IList<Entity1> GetAllEntities()
        {
            return new List<Entity1>();
        }
    }
}

using System.Collections.Generic;
using MyWebSite.Domain;

namespace MyWebSite.Service
{
    public interface IReferentialService
    {
        IList<Entity1> GetAllEntities();
    }
}
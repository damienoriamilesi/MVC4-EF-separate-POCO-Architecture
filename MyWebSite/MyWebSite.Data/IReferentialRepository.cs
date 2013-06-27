using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyWebSite.Domain;

namespace MyWebSite.Data
{
    public interface IReferentialRepository
    {
        IList<Entity1> GetAll();
    }

    public class ReferentialRepository : IReferentialRepository
    {
        public IList<Entity1> GetAll()
        {
            return new List<Entity1>();
        }
    }
}

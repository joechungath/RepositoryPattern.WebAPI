using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EFCore
{
    public class DeveloperRepository : GenericRepository<Developer>, IDeveloperRepository
    {
        public DeveloperRepository(ApplicationContext context):base(context)
        {

        }
        public IEnumerable<Developer> GetPopularDevelopers(int count)
        {
            return _Context.Developers.OrderByDescending(d => d.Followers).Take(count).ToList();
        }
    }
}

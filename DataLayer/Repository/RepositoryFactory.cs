using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public static class RepositoryFactory
    {
        public static IRepository GetRepository(bool connection)
        {
            if (connection)
            {
                return new APIRepository();
            }
            else
                return new FileRepository();
        }

        public static ISettings GetResourcesRepository() => new SettingsRepository();
    }
}

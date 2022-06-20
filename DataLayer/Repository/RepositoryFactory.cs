using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public static class RepositoryFactory
    {
        public static IRepository GetAPIRepository() => new APIRepository();
        public static IRepository GetFileRepository() => new FileRepository();
    }
}

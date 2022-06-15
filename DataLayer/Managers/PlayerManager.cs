using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Managers
{
    public class PlayerManager
    {
        private readonly IRepository repository;
        public PlayerManager() => repository = RepositoryFactory.GetRepository();
    }
}

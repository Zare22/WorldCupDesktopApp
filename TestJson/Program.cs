using DAL.Models;
using DAL.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestJson
{
    internal class Program
    {
        public readonly IRepository repository = RepositoryFactory.GetRepository();
        public IList<Match> matches;
        static void Main(string[] args)
        {
            IRepository repo = RepositoryFactory.GetRepository();
        }
    }
}

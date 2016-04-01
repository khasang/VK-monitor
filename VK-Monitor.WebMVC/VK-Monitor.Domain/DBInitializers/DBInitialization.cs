using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain;

namespace VK_Monitor.Domain.DBInitializers
{
    public class DBInitialization
    {
        List<InitializationAbstract> methods = new List<InitializationAbstract>();
        ApplicationDbContext context;

        public DBInitialization(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(InitializationAbstract initObject)
        {
            methods.Add(initObject);
        }

        public void Initialization()
        {
            foreach (var method in methods)
                method.Initialization(context);
        }
    }
}

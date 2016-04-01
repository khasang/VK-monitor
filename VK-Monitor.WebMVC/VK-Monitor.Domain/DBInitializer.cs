using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VK_Monitor.Domain;
using VK_Monitor.Domain.DBInitializers;

namespace VK_Monitor.Domain
{
    public class DBInitializer : DropCreateDatabaseIfModelChanges<ApplicationDbContext>
    {
        private Random rnd = new Random();

        protected override void Seed(ApplicationDbContext context)
        {
            // Здесь инициализируем БД

            DBInitialization initialization = new DBInitialization(context);

            // Здесь добавляем созданные нами объекты, наследованные от InitializationDB, для инициализации БД
            // Пример DBInitilizers.InitUserAdmin
            initialization.Add(new InitUserAdmin());  // Добавил Ruslan

            initialization.Initialization();
        }
    }
}

using Layer_Support.Entity;
using System;
using System.Data.Entity;
using System.Linq;

namespace Layer_Data.Context
{
    public class MyDbContext : DbContext
    {
        // El contexto se ha configurado para usar una cadena de conexión 'MyDbContext' del archivo 
        // de configuración de la aplicación (App.config o Web.config). De forma predeterminada, 
        // esta cadena de conexión tiene como destino la base de datos 'Layer_Data.Context.MyDbContext' de la instancia LocalDb. 
        // 
        // Si desea tener como destino una base de datos y/o un proveedor de base de datos diferente, 
        // modifique la cadena de conexión 'MyDbContext'  en el archivo de configuración de la aplicación.
        public MyDbContext()
            : base("name=MyDbContext")
        {
        }

        // Agregue un DbSet para cada tipo de entidad que desee incluir en el modelo. Para obtener más información 
        // sobre cómo configurar y usar un modelo Code First, vea http://go.microsoft.com/fwlink/?LinkId=390109.

         public virtual DbSet<Brand> Brands { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Server> Servers { get; set; }
        public virtual  DbSet<SO> SOs { get; set; }
    }

 
}
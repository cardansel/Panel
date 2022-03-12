namespace Layer_Data.Migrations
{
    using Layer_Support.Entity;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Layer_Data.Context.MyDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Layer_Data.Context.MyDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            context.Brands.AddOrUpdate(x => x.Id,

                new Brand() { Id = 1, Brand_Name = "DELL", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new Brand() { Id = 2, Brand_Name = "LENOVO", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new Brand() { Id = 3, Brand_Name = "TOSHIBA", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new Brand() { Id = 4, Brand_Name = "SONY", CreateDate = DateTime.Now, UpdateDate = DateTime.Now }

                );

            context.Categories.AddOrUpdate(x => x.Id,

                new Category() { Id = 1, Category_Name = "Servidores Web", Category_Desc = "Servidores de Hosting", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new Category() { Id = 2, Category_Name = "Servidores Database", Category_Desc = "Servidores Database", CreateDate = DateTime.Now, UpdateDate = DateTime.Now },
                new Category() { Id = 3, Category_Name = "Servidores Backup", Category_Desc = "Servidores Backup", CreateDate = DateTime.Now, UpdateDate = DateTime.Now }

                );

            context.SOs.AddOrUpdate(x=>x.Id,
                
                new SO() { Id=1,Server_So="Windows Server 2012 Std",SO_Url="http://localhost",
                                            Develop="Microsoft",SO_Desc="Windows Server 2012 es un sistema operativo destinado a servidores lanzado por Microsoft. Es la versión para servidores de Windows 8",
                                            SO_Date =DateTime.Today,CreateDate=DateTime.Now,UpdateDate=DateTime.Now
                                        }
                
                );
        }
    }
}

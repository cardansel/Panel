using Layer_Data.Context;
using Layer_Support.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_Data.Data
{
    public class CategoryDAL
    {
        #region GetAll
        public async Task<IEnumerable<Category>>GetAll()
        {
            List<Category> _list = new List<Category>();
            try
            {
                using (var db = new MyDbContext())
                {
                    var list = await db.Categories.OrderByDescending(x => x.Id).ToListAsync();
                    return list;
                }
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region GetById
        public async Task<Category>GetById(int? id)
        {
            var category = new Category();
            
            try
            {
                using (var db=new MyDbContext())
                {
                    if(id==null)
                    {
                        throw new Exception();
                    }
                    
                    category =await db.Categories.FindAsync(id);

                    if (category==null)
                    {
                        throw new Exception();
                    }

                    return category;
                }
                    
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }
        #endregion


        #region AddRegister
        public async Task<Category>Create(Category category)
        {
            try
            {
                using (var db=new MyDbContext())
                {
                    category.CreateDate = DateTime.Now;
                    category.UpdateDate = DateTime.Now;

                    db.Categories.Add(category);
                    var result = await db.SaveChangesAsync();

                    if (result == 0)
                        throw new Exception();
                   
                }

                return category;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }
        #endregion

        #region Edit
        public async Task<Category>Edit(Category category)
        {
            try
            {
                using (var db=new MyDbContext())
                {
                    category.UpdateDate = DateTime.Now;
                    db.Entry(category).State = EntityState.Modified;
                    db.Entry(category).Property(x => x.CreateDate).IsModified = false;

                    await db.SaveChangesAsync();
                }

                return category;
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }
        #endregion
    }
}

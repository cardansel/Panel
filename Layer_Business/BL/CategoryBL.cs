using Layer_Data.Data;
using Layer_Support.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Layer_Business.BL
{
    public class CategoryBL
    {
        private CategoryDAL CategoryDAL = new CategoryDAL();

        #region GetAll
        public async Task<IEnumerable<Category>> GetAll()
        {
            try
            {
                return await CategoryDAL.GetAll();
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region GetById
        public async Task<Category> GetById(int id)
        {
            try
            {
                return await CategoryDAL.GetById(id);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.Message);
            }
        }
        #endregion

        #region Create
        public async Task<Category>Create(Category category)
        {
            try
            {
                return await CategoryDAL.Create(category);
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
                return await CategoryDAL.Edit(category);
            }
            catch (Exception ex)
            {

                throw new Exception(ex.ToString());
            }
        }
        #endregion
    }
}

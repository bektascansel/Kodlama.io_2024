
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.Dto.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
           _categoryDal = categoryDal;
        }

        public void Create(CreateCategoryDto category)
        {
            Category createCategory = new Category
            {
                Name = category.Name,
            };

            _categoryDal.Create(createCategory);
        }

        public void Delete(int id)
        {
           var category=_categoryDal.Get(x=>x.Id == id);
           _categoryDal.Delete(category);
        }

        public Category Get(int id)
        {
            var category = _categoryDal.Get(x => x.Id == id);
            return category;
        }

        public List<Category> GetAll()
        {
            var categories=_categoryDal.GetAll();
            return categories;
        }

        public void Update(UpdateCategoryDto category)
        {
            var updatedCategory = _categoryDal.Get(x=>x.Id==category.Id);

            updatedCategory.Name = category.Name;
           
            _categoryDal.Update(updatedCategory);
        }
    }
}

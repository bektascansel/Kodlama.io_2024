using Entities.Concrete;
using Entities.Concrete.Dto.CategoryDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface  ICategoryService
    {
        List<Category> GetAll();
        Category Get(int id);
        void Update(UpdateCategoryDto category);
        void Create(CreateCategoryDto category);
        void Delete(int id);


    }
}

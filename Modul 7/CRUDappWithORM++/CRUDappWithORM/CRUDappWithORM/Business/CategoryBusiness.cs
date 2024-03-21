using CRUDappWithORM.Data;
using CRUDappWithORM.Data.Models;
using CRUDappWithORMv2.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace CRUDappWithORM.Business {
    public class CategoryBusiness {
        private ProductContext productContext;

        public List<Category> GetAll() {
            using (productContext = new ProductContext()) {
                return productContext.Categories.ToList();
            }
        }

        public Category Get(int id) { 
            using (productContext = new ProductContext()) {
                return productContext.Categories.FirstOrDefault(c => c.Id == id);
            }
        }

        public void Add(Category category) {
            using (productContext = new ProductContext()) {
                productContext.Categories.Add(category);
                productContext.SaveChanges();
            }
        }

        public void Update(Category category) {
            using (productContext = new ProductContext()) {
                var item = productContext.Categories.Find(category.Id);
                if (item != null) {
                    productContext.Entry(item).CurrentValues.SetValues(category);
                    productContext.SaveChanges();
                }
            }
        }

        public void Delete(int id) {
            var category = productContext.Categories.FirstOrDefault(c => c.Id == id);
            if (category != null) {
                productContext.Categories.Remove(category);
                productContext.SaveChanges();
            }
        }
    }
}

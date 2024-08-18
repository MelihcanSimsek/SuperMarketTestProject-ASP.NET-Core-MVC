namespace SuperMarketProject.Models
{
    public static class CategoriesRepository
    {
        public static List<Category> _categories = new List<Category>()
       {
           new Category(){CategoryId=1,Name="Beverage",Description="This is a Beverage category"},
           new Category(){CategoryId=2,Name="Bakery",Description="This is a Bakery category"},
           new Category(){CategoryId=3,Name="Meat",Description="This is a Meat category"}
       };


        public static void AddCategory(Category category)
        {
            int maxId = _categories.Max(x => x.CategoryId);
            category.CategoryId = (maxId + 1);
            _categories.Add(category);
        }

        public static List<Category> GetAllCategories()
        {
            return _categories;
        }

        public static Category GetCategoryById(int categoryId)
        {
            Category? category = _categories.FirstOrDefault(c => c.CategoryId == categoryId);
            if(category != null)
            {
                return category;
            }
            return null;
        }

        public static void UpdateCategory(int categoryId,Category category)
        {
            Category? dbCategory = _categories.FirstOrDefault(c => c.CategoryId == categoryId);

            if(category != null)
            {
                dbCategory.Description = category.Description;
                dbCategory.Name = category.Name;
                
            }


            return;
        }


        public static void DeleteCategory(int categoryId)
        {
            Category? category = GetCategoryById(categoryId);
            if(category != null)
            {
                _categories.Remove(category);
            }

            return;
        }
    }
}

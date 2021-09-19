using System; using System.Linq; using System.Collections.Generic;
namespace CSharpBook.Chapter13
{
    public class Category //类别
    {
        public string ID, Name; //类别编号、类别名称
        public static List<Category> GetCategoryList()
        {
            List<Category> list = new List<Category>();
            list.Add(new Category { ID = "1", Name = "饮料" });
            list.Add(new Category { ID = "2", Name = "水果" });
            list.Add(new Category { ID = "3", Name = "蔬菜" });
            return (list);
        }
    }
    public class Product //产品
    {
        public string ID, Name, categoryID;//产品编号、产品名称、类别编号
        public int num; //产品数量
        public static List<Product> GetProductList()
        {
            List<Product> list = new List<Product>();
            list.Add(new Product { ID = "1", Name = "可乐", num = 10, categoryID = "1" });
            list.Add(new Product { ID = "2", Name = "橙汁", num = 20, categoryID = "1" });
            list.Add(new Product { ID = "3", Name = "苹果", num = 11, categoryID = "2" });
            list.Add(new Product { ID = "4", Name = "香蕉", num = 22, categoryID = "2" });
            list.Add(new Product { ID = "5", Name = "菠萝", num = 33, categoryID = "2" });
            return (list);
        }
    }
    public class JoinTest
    {
        public static void Main()
        {
            List<Category> categories = Category.GetCategoryList();
            List<Product> products = Product.GetProductList();
            var q11 = from c in categories
                      join p in products on c.ID equals p.categoryID
                      select new { CategoryName = c.Name, ProductID = p.ID, ProductName = p.Name };
            foreach (var item in q11) Console.WriteLine(item);
            var q12 = categories.Join(products, c => c.ID, p => p.categoryID,
                      (c, p) => new { CategoryName = c.Name, ProductID = p.ID, ProductName = p.Name });
            foreach (var item in q12) Console.WriteLine(item);
            var q21 = from c in categories
                      join p in products on c.ID equals p.categoryID into ps
                      select new { CategoryName = c.Name, Nums = ps.Sum(p => p.num) };
            foreach (var item in q21) Console.WriteLine(item);
            var q22 = categories.GroupJoin(products, c => c.ID, p => p.categoryID,
                                    (c, ps) => new { CategoryName = c.Name, Nums = ps.Sum(p => p.num) });
            foreach (var item in q22) Console.WriteLine(item);
            Console.ReadKey();
        }
    }
}

using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//ProductTest();
//CategoryTest();











//static void ProductTest()
//{
//    ProductManager productManager = new ProductManager(new EfProductDal(),new ProductManager());

//    var result = productManager.GetProductDetails();

//    if (result.Success==true )
//    {
//        foreach (var item in result.Data)
//        {
//            Console.WriteLine(item.ProductName);
//        }
//    }
//    else
//    {
//        Console.WriteLine(result.Message);
//    }
//}

//static void CategoryTest()
//{
//    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

//    foreach (var category in categoryManager.GetAll().Data)
//    {
//        Console.WriteLine(category.CategoryName);
//    }
//}
using InstrumentShop.RestApiClient;
using System;

namespace InstrumentShop.DataAccessLayer.Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var unitOfInstrument = new UnitOfInstrument())
            //{
            //    var categoryRepository = unitOfInstrument.CategoryRepository;
            //    var categorys = categoryRepository.List();
            //    foreach(Category category in categorys)
            //    {
            //        Console.WriteLine(category.Name);
            //    }

            //}
            //Console.ReadKey();

            GetCategoryNames();
            Console.ReadKey();
        }
        public static async void GetCategoryNames()
        {
            var categorys = await RestClient.ListCategoryNamesAsync();
            foreach (var category in categorys)
            {
                Console.WriteLine(category.Name);
            }
            if (categorys.Count > 0)
            {
                var category = await RestClient.GetCategoryAsync(categorys[0].ID);
                category.Phone = "1234";
                try
                {
                    await RestClient.UpdateCategoryAsync(category);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


    }
}

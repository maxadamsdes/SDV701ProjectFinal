using InstrumentShop.RestApiClient;
using System;

namespace InstrumentShop.DataAccessLayer.Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            GetCategoryNames();
            GetInstrumentNames();
            Console.ReadKey();
        }
        public static async void GetCategoryNames()
        {
            var categorys = await RestClient.ListCategoryNamesAsync();
            foreach (var category in categorys)
            {
                Console.WriteLine(category.Description);
            }
            if (categorys.Count > 0)
            {
                var category = await RestClient.GetCategoryAsync(categorys[0].ID);
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

        public static async void GetInstrumentNames()
        {
            var instruments = await RestClient.ListInstrumentNamesAsync();
            foreach (var instrument in instruments)
            {
                Console.WriteLine(instrument.Description);
            }
            if (instruments.Count > 0)
            {
                var instrument = await RestClient.GetInstrumentAsync(instruments[0].ID);
                try
                {
                    await RestClient.UpdateInstrumentAsync(instrument);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}

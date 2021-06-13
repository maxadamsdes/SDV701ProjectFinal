using ArtGallery.RestApiClient;
using System;

namespace ArtGallery.DataAccessLayer.Test_App
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (var unitOfWork = new UnitOfWork())
            //{
            //    var artistRepository = unitOfWork.ArtistRepository;
            //    var artists = artistRepository.List();
            //    foreach(Artist artist in artists)
            //    {
            //        Console.WriteLine(artist.Name);
            //    }

            //}
            //Console.ReadKey();

            GetArtistNames();
            Console.ReadKey();
        }
        public static async void GetArtistNames()
        {
            var artists = await RestClient.ListArtistNamesAsync();
            foreach (var artist in artists)
            {
                Console.WriteLine(artist.Name);
            }
            if (artists.Count > 0)
            {
                var artist = await RestClient.GetArtistAsync(artists[0].ID);
                artist.Phone = "1234";
                try
                {
                    await RestClient.UpdateArtistAsync(artist);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }


    }
}

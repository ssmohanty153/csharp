using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace jsonPrograming
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("seralization");
            Movie m = new Movie { id = 1, moviesName = "3 idiots" };
            string str= seralizationMeth(m);
            Console.WriteLine(str);
            Console.WriteLine("deseralization");
            deseralizationMeth(str);
            Console.ReadKey();
        }
        public static string seralizationMeth(Movie m)
        {
            string result = JsonConvert.SerializeObject(m);
            return result;
        }
        public static void deseralizationMeth(string result)
        {
            Movie newMovie = JsonConvert.DeserializeObject<Movie>(result);
            Console.WriteLine(newMovie);
            Console.WriteLine("id name{0}, and movieNAme {1}", newMovie.id,newMovie.moviesName);
        }
    }



   public  class Movie
    {
     public int id { get; set;}
    public string moviesName  { get; set; }
        

    }
}


using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace M15_Demo_LINQ
{
    class M15DemoMain
    {
        // fields
        static List<string> elements = new List<string>() { "Gold", "Platinum", "Aluminium", "Silber", "Kupfer", "Eisen" };
        static int[] numbers = new int[] { 45, 34, 6, 2, 75, 27, 543 };
        static List<Todo> todos = new List<Todo>();

        static readonly HttpClient httpClient = new HttpClient();
        static void Main(string[] args)
        {
            // Linq-Methoden liefern entweder ein Objekt oder ein Enumerable zurück
            var fourLettersElement = from el in elements
                                     where el.Length == 4
                                     select el;
            Console.WriteLine($"fourLettersElement: {fourLettersElement}");
            foreach (var item in fourLettersElement)
                Console.WriteLine($"fourLettersElement item: {item}");

            HoleTodos();




            Console.ReadKey();

        }

        static async void HoleTodos()
        {
            HttpResponseMessage response =
                await httpClient.GetAsync("http://jsonplaceholder.typicode.com/todos");
            string responseContent = await response.Content.ReadAsStringAsync();
            todos = JsonConvert.DeserializeObject<List<Todo>>(responseContent);

            var todosUserThreeTitles =
                todos.Where(t => t.UserId == 3).
                Select(t => t).
                Where(t => t.Completed == false).
                Select(t => t.Title);
            foreach (var item in todosUserThreeTitles)
                Console.WriteLine($"todosUserThreeTitles item: {item}");
        }
    }
    class Todo
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Completed { get; set; }

    }
}

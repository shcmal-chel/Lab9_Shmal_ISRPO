//using MyClass;
//using Newtonsoft.Json;
//using HtmlAgilityPack;
//Person2 ivan = new("Ivan");
using Lab_9;

static async Task Main()
{
    //Fruit apple = new() { Name = "Яблоко", Quantity = 5 };
    //string json = JsonConvert.SerializeObject(apple);
    //Console.WriteLine("В JSON: " + json);
    //var deserialized = JsonConvert.DeserializeObject<Fruit>(json);
    //Console.WriteLine($"Объект: {deserialized?.Name} - {deserialized?.Quantity} шт.");

    //Console.Write("Введите URL сайта: ");
    //string? url = Console.ReadLine();

    //if (!string.IsNullOrEmpty(url))
    //{
    //    try
    //    {
    //        HttpClient client = new HttpClient();
    //        string html = await client.GetStringAsync(url);
    //        HtmlDocument doc = new HtmlDocument();
    //        doc.LoadHtml(html);
    //        var titleNode = doc.DocumentNode.SelectSingleNode("//title");
    //        if (titleNode != null)
    //        {
    //            Console.WriteLine($"Заголовок страницы: {titleNode.InnerText}");
    //        }
    //        else
    //        {
    //            Console.WriteLine("Заголовок страницы не найден");
    //        }
    //    }
    //    catch (Exception ex)
    //    {
    //        Console.WriteLine("Ошибка: " + ex.Message);
    //    }
    //}
    //else
    //{
    //    Console.WriteLine("Url не может быть пустым.");
    //}

    //int? val = null;
    //IsNull(val);
    //val = 22;
    //IsNull(val);
    //void IsNull(int? obj)
    //{
    //    if (obj == null) Console.WriteLine("null");
    //    else Console.WriteLine(obj);
    //}

    //string? GetUserName(int id)
    //{
    //    return id == 1 ? "Alice" : null;
    //}

    //var user = GetUserName(2);
    //Console.WriteLine(user?.ToUpper());

    //string? input = Console.ReadLine();

    //if (input != null)
    //    Console.WriteLine($"Вы ввели: {input}");
    //else
    //    Console.WriteLine("Вы ничего не ввели!");

    //List<string> names = new() {"Anna",null,"Bob" };
    //foreach (var name in names)
    //{
    //    Console.WriteLine(name?.Length??0);
    //}
}

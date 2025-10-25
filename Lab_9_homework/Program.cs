using HtmlAgilityPack;
using Lab_9_homework;
using MathLibrary;
using Newtonsoft.Json;
public delegate void Logger(string message);
class Program
{

    public static void LogToConsole(string message)
    {
        Console.WriteLine(message);
    }
    static void Main(string[] args)
    {

        //Задание 1
        //MathTools math = new MathTools();

        //int x = 15;
        //int y = 100;

        //Console.WriteLine("Сумма: {0}",math.Add(x,y));
        //Console.WriteLine("Произведение: {0}",math.Multiply(x,y));

        //Задание 2
        //var web = new HtmlWeb();
        //var doc = web.Load("https://paltosik92.github.io/it-labs/labs/programming/csharp/index.html");
        //var titleNode = doc.DocumentNode.SelectSingleNode("//title")?.InnerText;
        //Console.WriteLine($"Заголовок: {titleNode}");

        //Задание 3
        //Logger logger = LogToConsole;
        //logger("Привет, мир!");
        //logger("Тестовое сообщение");

        //Задание 4
        //Thermometer thermometer = new Thermometer();
        //thermometer.TemperatureTooHigh += () => Console.WriteLine("Температура превышена!!!");
        //thermometer.Measure(24);
        //thermometer.Measure(101);

        //Задание 5
        //PrintLength("Слово");
        //PrintLength(null);

        //Задание 6
        SmartLight light = new SmartLight();
        light.OnStateChanged += state => Console.WriteLine(state ? "Свет включён" : "Свет выключен");

        light.Toggle();
        light.Toggle();
    }

    public static void PrintLength(string? input)
    {
        if (input != null)
            Console.WriteLine($"Длина строки: {input.Length}");
        else
            Console.WriteLine("Строка отсутствует");
    }

}

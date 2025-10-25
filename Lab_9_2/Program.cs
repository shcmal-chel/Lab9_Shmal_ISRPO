//ТУТ ВСЕ НАЧИНАЯ С 8 ШАГА

namespace Lab_9_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int? number1 = 5;
            //Nullable<int> number2 = 5;

            //PrintNullable(5);
            //PrintNullable(null);

            //int? number = null;
            //Console.WriteLine(number.GetValueOrDefault());
            //Console.WriteLine(number.GetValueOrDefault(10));

            //number = 15;
            //Console.WriteLine(number.GetValueOrDefault());
            //Console.WriteLine(number.GetValueOrDefault(10));

            //void PrintNullable(int? number)
            //{
            //    if (number.HasValue)
            //    {
            //        Console.WriteLine(number.Value);
            //        Console.WriteLine(number);
            //    }
            //    else
            //    {
            //        Console.WriteLine("Параметр равен null");
            //    }
            //}

            var tempSensor = new TemperatureSensor();
            var motionSensor = new MotionSensor();
            var smartLight = new SmartLight();

            tempSensor.OnOverheat += Notifier.SendTemperatureAlert;
            motionSensor.OnMotionDetected += Notifier.LogMotionEvent;
            motionSensor.OnMotionDetected += smartLight.TurnOn;

            Console.WriteLine("=== Симуляция умного дома ===");

            tempSensor.CheckTemperature(35);
            motionSensor.DetectMotion(true);
            smartLight.TurnOn("Обнаружено движение");
            Thread.Sleep(3000);
            smartLight.TurnOff();
        }
    }
}

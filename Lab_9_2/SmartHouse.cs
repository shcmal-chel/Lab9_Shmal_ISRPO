public delegate void TemperatureEventHandler(string message);
public delegate void MotionEventHandler(string message);

public class TemperatureSensor
{
    public event TemperatureEventHandler OnOverheat;

    public void CheckTemperature(int currentTemp)
    {
        if (currentTemp > 30)
        {
            OnOverheat?.Invoke($"!! Температура критическая: {currentTemp}°C!");
        }
    }
}
    public class MotionSensor
    {
        public event MotionEventHandler OnMotionDetected;

        public void DetectMotion(bool isMotion)
        {
            if (isMotion)
            {
                OnMotionDetected?.Invoke("!! Обнаружено движение в коридоре!");
            }
        }
    }

    public class Notifier
    {
        public static void SendTemperatureAlert(string message)
        {
            Console.WriteLine($"[Уведомление] {message}");
        }

        public static void LogMotionEvent(string message)
        {
            Console.WriteLine($"[Лог] {message} (время: {DateTime.Now})");
        }
    }

public class SmartLight
{
    private bool isOn = false;

    public void TurnOn(string message)
    {
        if (!isOn)
        {
            isOn = true;
            Console.WriteLine("[Лампочка]! Включена (триггер: движение)");
        }    
    }
    public void TurnOff()
    {
        if (!isOn)
        {
            isOn = false;
            Console.WriteLine("[Лампочка]! Выключена (прошло время без движения)");
        }
    }
}



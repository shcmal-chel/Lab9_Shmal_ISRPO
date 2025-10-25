

namespace Lab_9_homework
{
    internal class SmartLight
    {
        public bool IsOn {  get; set; }
        public int Brightness { get; set; }

        public event Action<bool> OnStateChanged;

        public void Toggle()
        {
            IsOn = !IsOn;
            OnStateChanged.Invoke(IsOn);
        }


    }
}

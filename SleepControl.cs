using System;
namespace OOPExample
{
    class SleepControl : ISleep
    {
        public bool isSleeping { get; private set; }

        public void ToggleSleep()
        {
            isSleeping = !isSleeping;
        }

    }

}

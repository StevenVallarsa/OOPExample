using System;
namespace OOPExample
{
    class Desktop : Computer, ISleep
    {
        private ISleep sleepController;

        public enum CaseType
        {
            Undefined,
            Tower,
            MiniTower
        }

        public bool isSleeping { get { return sleepController.isSleeping; } }

        string _caseType = "Undefined";

        public CaseType caseType { get; set; }

        public override string name
        {
            get
            {
                return base.name + " is a " + caseType + " computer";
            }
        }



        public Desktop(string name, CaseType caseType) : base(name)
        {
            this.caseType = caseType;
            sleepController = new SleepControl();
        }


        public Desktop() : base()
        {
        }

        public Desktop(string name) : base(name)
        {
        }

        public void ToggleSleep()
        {
            if(!isOn)
            {
                return;
            }

            sleepController.ToggleSleep();
        }

        public override void TogglePower()
        {
            if(isSleeping)
            {
                return;
            }

            base.TogglePower();
        }



    }
}

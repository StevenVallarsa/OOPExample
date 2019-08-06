using System;
namespace OOPExample
{
    class Desktop : Computer
    {
        public enum CaseType
        {
            Tower,
            MiniTower
        }

        public CaseType caseType { get; private set; }

        public Desktop(string name, CaseType caseType) : base(name)
        {
            this.caseType = caseType;
        }

        public Desktop() : base()
        {
        }

    }
}

namespace PersonalRegister2026VT
{
    internal class Robot
    {
        //Struktur på en klass
        //1. Privata fält
        //2. Publika properties
        //3. Konstruktor
        //4. Methoder.


        //Privata fält
        private string _name;

       // private int _age;

        //Publika properties
        //Lite extra funktionalitet här, där om vi sätter ett värde under 0 så sätts det automatiskt till 0.
        //Snippet propfull skapar en property med ett bakomliggnade fält
        public int Age
        {
            get { return field; }
            set
            {
                if (value < 0)
                    field = 0;
                else
                field = value;
            }
        }

        //public int Salary { get; private set; }

        //Autoproperty, om man inte behöver ha validering eller liknande i koden.
        //Snippet prop.
        //Inget set i detta fallet innebär att det inte går att sätta värdet utanför konstruktorn.
        //Hade vi haft en private set hade det gått att sätta i klassen men inte utanför.
        public int Salary { get;}

        //Statisk innebär att den är en del av klassen snarare än klassinstanser, kommer ha samma värde i hela applikationen
        //Kallas med Robot.Count(klassen) snarare än r.Count (instansen)
        public static int Count { get; set; }

        //Konstruktor
        //Snippet ctor
        //Fyller alla nya instanser med datan som anges.
        public Robot(string name, int age, int salary)
        {
            _name = name;
            Age = age;
            Salary = salary;
            Count++; 
        }

        //Metoder
        //För att hämta och sätta värden av privata fält i detta fallet. 
        public void SetSalary(int salary)
        {
            //Salary = salary; 
        }

        public string GetName()
        {
            return _name;
        }
        public void SetName(string name)
        {
            //Validation
            _name = name;
        }
    }
}
namespace Part2.OOP
{
    class Car
    {
        public Car()
        {
            
        }

        public string MyProperty 
        {
            get
            {
                return text;
            }
            set
            {
                if(value == "new")
                    text = "This value cannot be new";
                text = value;
            } 
        }

        public DateTime Year { get; init; }

        private string text;
    }

    class Caller
    {
        void Main()
        {
            var car = new Car()
            {
                Year = DateTime.Now,
            };

            //car.Year = DateTime.Now; You cannot give a value for Year here, because it is init only 
        }
    }
}

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

        private string text;
    }
}

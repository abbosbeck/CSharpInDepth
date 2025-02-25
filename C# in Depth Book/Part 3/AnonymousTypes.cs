namespace Part3
{
    public class AnonymousTypes
    {
        public void CreateAnAnonanonymousPbjectCreationExpression()
        {
            var pupil = new
            {
                Ism = "Abbos",
                Familiya = "Abduqayumov",
                Yosh = 21
            };

            var players = new[]
             {
                new { Name = "Priti", Score = 6000 },
                new { Name = "Chris", Score = 7000 },
                new { Name = "Amanda", Score = 8000 },
             }; // this is an array of anonymous types, which is valid

            /*var players = new[]
             {
                new { Name = "Priti", Score = 6000 },
                new { Score = 7000, Name = "Chris" },
                new { Name = "Amanda", Score = 8000 },
             };*/ // this is not valid because of the second line
        }
    }
}

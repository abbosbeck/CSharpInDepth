namespace Part3
{
    public class LambdaExpressionManual
    {
        public Func<int, int, IEnumerable<int>> square = (x, y) =>
        {
            var numbers = new List<int>();
            for (int i = x; x < y; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        };
    }

    class CapturedVariablesDemo
    {
        private string instanceField = "instance field";
        public Action<string> CreateAction(string methodParameter)
        {
            string methodLocal = "method local";
            string uncaptured = "uncaptured local";
            Action<string> action = lambdaParameter =>
            {
                string lambdaLocal = "lambda local";
                Console.WriteLine("Instance field: {0}", instanceField);
                Console.WriteLine("Method parameter: {0}", methodParameter);
                Console.WriteLine("Method local: {0}", methodLocal);
                Console.WriteLine("Lambda parameter: {0}", lambdaParameter);
                Console.WriteLine("Lambda local: {0}", lambdaLocal);
            };
            methodLocal = "modified method local";
            return action;
        }
    }
}


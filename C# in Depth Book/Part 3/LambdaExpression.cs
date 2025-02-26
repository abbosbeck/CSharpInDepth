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
            int counter = 0;
            string methodLocal = "method local";
            string uncaptured = "uncaptured local";
            Action<string> action = lambdaParameter =>
            {
                string lambdaLocal = "lambda local";
                Console.WriteLine("Instance field: {0}. Counter: {1}", instanceField);
                Console.WriteLine("Method parameter: {0}", methodParameter);
                Console.WriteLine("Method local: {0}", methodLocal);
                Console.WriteLine("Lambda parameter: {0}", lambdaParameter);
                Console.WriteLine("Lambda local: {0}", lambdaLocal);
            };
            methodLocal = "modified method local";
            return action;
        }

        public Action CreateAction()
        {
            int count = 0;
            return () => Console.WriteLine(++count);
        }

        public static List<Action> CreateActions()
        {
            List<Action> actions = new List<Action>();
            for (int i = 0; i < 5; i++)
            {
                string text = string.Format("message {0}", i);
                actions.Add(() => Console.WriteLine(text));
            }
            return actions;
        }
    }

    public class ChainingMethodCalls
    {
        public void Main()
        {
            string[] words = { "keys", "coat", "laptop", "bottle" };

            IEnumerable<string> query = words
                .Where(word => word.Length > 4)
                .OrderBy(word => word)
                .Select(word => word.ToUpper());


            foreach (string word in query)
            {
                Console.WriteLine(word);
            }
        }
    }
}
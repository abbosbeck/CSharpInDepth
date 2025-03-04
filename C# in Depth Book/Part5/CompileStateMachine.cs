using System.Runtime.CompilerServices;

namespace Part5
{
    public struct CompileStateMachine : IAsyncStateMachine
    {
        public int State;
        public AsyncTaskMethodBuilder Builder;
        private TaskAwaiter Awaiter;
        public void MoveNext()
        {
            try
            {
                if(State == 0)
                {
                    Console.WriteLine("Boiling water");
                    Awaiter = Task.Delay(5000).GetAwaiter();
                    if(!Awaiter.IsCompleted)
                    {
                        State = 1;
                        Builder.AwaitOnCompleted(ref Awaiter, ref this);
                        
                        return;
                    }
                }

                if (State == 1)
                {
                    Console.WriteLine("Adding pasta...");
                }
            }
            catch (Exception ex)
            {
                Builder.SetException(ex);

                return;
            }

            Builder.SetResult();
        }

        public void SetStateMachine(IAsyncStateMachine stateMachine)
        {
            throw new NotImplementedException();
        }
    }

    public class CookDinner
    {
        public static Task CookDinnerAsync()
        {
            CompileStateMachine stateMachine = new CompileStateMachine();
            stateMachine.Builder = AsyncTaskMethodBuilder.Create();
            stateMachine.State = -1;
            stateMachine.Builder.Start(ref stateMachine);
            return stateMachine.Builder.Task;
        }
    }
}

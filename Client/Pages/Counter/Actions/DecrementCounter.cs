namespace BlazorFluxor.Client.Pages.Counter.Actions
{
    public class DecrementCounter
    {
        public DecrementCounter(int counterNumber)
        {
            CounterNumber = counterNumber;
        }
        public int CounterNumber { get; init; }
    }
}

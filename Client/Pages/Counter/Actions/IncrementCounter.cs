namespace BlazorFluxor.Client.Pages.Counter.Actions
{
    public class IncrementCounter
    {
        public IncrementCounter(int counterNumber)
        {
            CounterNumber = counterNumber;
        }
        public int CounterNumber { get; init; }
    }
}

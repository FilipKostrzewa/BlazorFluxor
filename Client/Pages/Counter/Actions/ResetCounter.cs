namespace BlazorFluxor.Client.Pages.Counter.Actions
{
    public class ResetCounter
    {
        public ResetCounter(int counterNumber)
        {
            CounterNumber = counterNumber;
        }
        public int CounterNumber { get; init; }
    }
}

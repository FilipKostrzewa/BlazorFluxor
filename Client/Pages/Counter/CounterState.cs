namespace BlazorFluxor.Client.Pages.Counter
{
    public record CounterState
    {
        public string Name { get; set; }
        public int Count1 { get; init; }
        public int Count2 { get; init; }
        public int Count3 { get; init; }
    }
}

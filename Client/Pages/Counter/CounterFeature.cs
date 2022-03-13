using Fluxor;

namespace BlazorFluxor.Client.Pages.Counter
{
    public class CounterFeature : Feature<CounterState>
    {
        public override string GetName() => nameof(CounterState);

        protected override CounterState GetInitialState()
        {
            return new CounterState
            {
                Name = "Counter",
                Count1 = 0,
                Count2 = 0,
                Count3 = 0,
            };
        }
    }
}

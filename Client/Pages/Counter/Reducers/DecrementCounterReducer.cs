using BlazorFluxor.Client.Pages.Counter.Actions;
using Fluxor;

namespace BlazorFluxor.Client.Pages.Counter.Reducers
{
    public class DecrementCounterReducer : Reducer<CounterState, DecrementCounter>
    {
        public override CounterState Reduce(CounterState state, DecrementCounter action)
        {
            var result = action.CounterNumber switch
            {
                1 => state with {Count1 = state.Count1 - 1},
                2 => state with {Count2 = state.Count2 - 1},
                3 => state with {Count3 = state.Count3 - 1},
                _ => throw new ArgumentException()
            };

            return result;
        }
    }
}

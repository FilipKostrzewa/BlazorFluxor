using BlazorFluxor.Client.Pages.Counter.Actions;
using Fluxor;

namespace BlazorFluxor.Client.Pages.Counter.Reducers
{
    public class ResetCounterReducer : Reducer<CounterState, ResetCounter>
    {
        public override CounterState Reduce(CounterState state, ResetCounter action)
        {
            var result = action.CounterNumber switch
            {
                1 => state with {Count1 = 0}, 
                2 => state with {Count2 = 0},
                3 => state with {Count3 = 0},
                _ => throw new ArgumentException()
            };

            return result;
        }
    }
}

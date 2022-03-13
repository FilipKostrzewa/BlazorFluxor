using BlazorFluxor.Client.Pages.Counter.Actions;
using Fluxor;

namespace BlazorFluxor.Client.Pages.Counter.Reducers
{
    public class ClearNameReducer : Reducer<CounterState, ClearName>
    {
        public override CounterState Reduce(CounterState state, ClearName action)
        {
            return state with {Name = null};
        }
    }
}

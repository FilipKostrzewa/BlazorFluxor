using BlazorFluxor.Client.Pages.Counter.Actions;
using Fluxor;

namespace BlazorFluxor.Client.Pages.Counter.Reducers
{
    public class SetNameReducer : Reducer<CounterState, SetName>
    {
        public override CounterState Reduce(CounterState state, SetName action)
        {
            return state with {Name = action.Name};
        }
    }
}

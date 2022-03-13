namespace BlazorFluxor.Client.Pages.Counter.Actions
{
    public class SetName
    {
        public SetName(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}

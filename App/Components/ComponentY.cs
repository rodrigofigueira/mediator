namespace App.Components
{
    public class ComponentY : BaseComponent
    {
        public void DoC()
        {
            Console.WriteLine("DoC...");
            _mediator.Notify(this, "C");
        }

        public void DoD()
        {
            Console.WriteLine("DoD...");
            _mediator.Notify(this, "D");
        }
    }
}

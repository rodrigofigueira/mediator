namespace App.Components
{
    public class ComponentX : BaseComponent
    {
        public void DoA()
        {
            Console.WriteLine("DoA...");
            _mediator.Notify(this, "A");
        }

        public void DoB()
        {
            Console.WriteLine("DoB...");
            _mediator.Notify(this, "B");
        }
    }
}

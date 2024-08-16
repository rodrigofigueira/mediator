using App.Interfaces;

namespace App.Components
{
    public class Mediator : IMediator
    {
        private readonly ComponentX _componentX;
        private readonly ComponentY _componentY;

        public Mediator(ComponentX componentX, ComponentY componentY)
        {
            _componentX = componentX;
            _componentX.SetMediator(this);
            _componentY = componentY;
            _componentY.SetMediator(this);
        }

        public void Notify(object sender, string ev)
        {
            if (ev == "A")
            {
                Console.WriteLine("Event A was triggered");
                Console.WriteLine("Mediator will call ComponentY.DoD");
                _componentY.DoD();
                return;
            }

            if (ev == "C")
            {
                Console.WriteLine("Event C was triggered");
                Console.WriteLine("Mediator will call ComponentX.DoB");
                _componentX.DoB();
                return;
            }
        }
    }
}

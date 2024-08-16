using App.Components;

Console.WriteLine("Starting program");

ComponentX componentX = new();
ComponentY componentY = new();

_ = new Mediator(componentX, componentY);

componentX.DoA();
componentY.DoC();

Console.WriteLine("End of program");
Console.ReadKey();
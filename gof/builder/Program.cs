string result = "";
Director director = new Director(new ConcreteBuilder());

result = (string)director.Constract();
Console.WriteLine(result);

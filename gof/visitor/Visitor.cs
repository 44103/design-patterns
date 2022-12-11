public abstract class Visitor
{
  public abstract void Visit(ConcreteAcceptorA acceptorA);
  public abstract void Visit(ConcreteAcceptorB acceptorB);
}

public class ConcreteVisitorA : Visitor
{
  private string Name { get; } = "ConcreteVisitorA";
  public override void Visit(ConcreteAcceptorA acceptorA)
  {
    Console.WriteLine($"{Name}が{acceptorA.Name}を訪問した");
  }
  public override void Visit(ConcreteAcceptorB acceptorB)
  {
    Console.WriteLine($"{Name}が{acceptorB.Name}を訪問した");
  }
}

public class ConcreteVisitorB : Visitor
{
  private string Name { get; } = "ConcreteVisitorB";
  public override void Visit(ConcreteAcceptorA acceptorA)
  {
    Console.WriteLine($"{Name}が{acceptorA.Name}に参りました");
  }
  public override void Visit(ConcreteAcceptorB acceptorB)
  {
    Console.WriteLine($"{Name}が{acceptorB.Name}に参りました");
  }
}

public abstract class Acceptor
{
  public abstract string Name { get; }
  public abstract void Accept(Visitor visitor);
}

public class ConcreteAcceptorA : Acceptor
{
  public override string Name { get; } = "ConcreteAcceptorA";
  public override void Accept(Visitor visitor)
  {
    visitor.Visit(this);
  }
}

public class ConcreteAcceptorB : Acceptor
{
  public override string Name { get; } = "ConcreteAcceptorB";
  public override void Accept(Visitor visitor)
  {
    visitor.Visit(this);
  }
}

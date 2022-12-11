public class Abstraction
{
  private Implementor impl;
  public Abstraction(Implementor impl)
  {
    this.impl = impl;
  }
  public void AbstractionMethod()
  {
    impl.ImplMethod();
  }
}

public class RefinedAbstraction : Abstraction
{
  public RefinedAbstraction(Implementor impl) : base(impl) { }
  public void RefinedMethod()
  {
    Console.WriteLine("追加機能");
  }
}

public abstract class Implementor
{
  public abstract void ImplMethod();
}

public class ConcreteImplementor : Implementor
{
  public override void ImplMethod()
  {
    Console.WriteLine("実装機能");
  }
}

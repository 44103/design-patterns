public class Director
{
  private Builder builder;
  public Director(Builder builder)
  {
    this.builder = builder;
  }
  public Object Constract()
  {
    builder.Part1("工程 1");
    builder.Part2("工程 2");
    return builder.GetResult();
  }
}

public abstract class Builder
{
  public abstract void Part1(string str);
  public abstract void Part2(string str);
  public abstract Object GetResult();
}

public class ConcreteBuilder : Builder
{
  private string buffer = "";
  public override void Part1(string str)
  {
    buffer += $"part1: {str}\n";
  }
  public override void Part2(string str)
  {
    buffer += $"part2: {str}\n";
  }
  public override Object GetResult()
  {
    return buffer;
  }
}

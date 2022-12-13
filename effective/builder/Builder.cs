using System;
using System.Collections.Generic;

public class Director
{
  public string Id { get; }
  public string Name { get; }
  public string[] Tag { get; }

  public Director(Builder builder)
  {
    if (builder.Id is null) throw new Exception("invalid field: ID");
    if (builder.Name is null) throw new Exception("invalid field: Name");
    Id = builder.Id;
    Name = builder.Name;
    Tag = builder.Tag.ToArray();
  }

  public override string ToString()
  {
    return $"ID: {Id}, Name: {Name}, Tag: {String.Join(",", Tag)}";
  }

  public sealed class Builder
  {
    internal string? Id { get; private set; }
    internal string? Name { get; private set; }
    internal List<string> Tag { get; private set; } = new List<string>();

    public Builder() { }

    public Builder SetId(string id)
    {
      Id = id; return this;
    }
    public Builder SetName(string name)
    {
      Name = name; return this;
    }
    public Builder AddTag(string tag)
    {
      Tag.Add(tag); return this;
    }
    public Director Build() => new Director(this);
  }
}

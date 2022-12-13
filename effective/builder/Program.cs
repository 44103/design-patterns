Director director = new Director.Builder()
  .SetId("0001")
  .SetName("Sample")
  .AddTag("#effective")
  .AddTag("#builder")
  .Build();

Console.WriteLine(director);

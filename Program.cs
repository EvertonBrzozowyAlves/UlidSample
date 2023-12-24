var ulidList = new List<Ulid>();

for (var i = 0; i < 10; i++)
{
    var generatedUlid = Ulid.NewUlid();
    Console.WriteLine("Generated one: " + generatedUlid);
    ulidList.Add(generatedUlid);
}

Console.WriteLine("");
Console.WriteLine("Before sort:");
Console.WriteLine("");


ulidList.ForEach(x => Console.WriteLine(x));

ulidList.Reverse();

Console.WriteLine("");
Console.WriteLine("After Revert:");
Console.WriteLine("");

ulidList.ForEach(x => Console.WriteLine(x));

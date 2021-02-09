using System;

Console.WriteLine("Hello World from Food!");
Console.WriteLine(GetMyName("Mohamad"));
Console.WriteLine(GetMyLastNameName("Lawand"));

static string GetMyName(string name)
{
    return $"Hello {name}, Welcome to C# 9 features";
}

static string GetMyLastNameName(string lastName)
{
    return $"Your LastName is {lastName}";
}
using System;
using System.Text.Json;

namespace RecordSample
{
    class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person(1, "Mohamad", "Lawand", "m@m.com");
            var person2 = new Person(2, "Donald", "Duck", "donald@m.com");

            // Serialize person 1 
            var jsonP1 = JsonSerializer.Serialize(person1);
            Console.WriteLine($"Person 1 Json: {jsonP1}");

            // deserialized json
            var person3 = JsonSerializer.Deserialize<Person>(jsonP1);
            
            var isEqual = person1.Equals(person3);

            Console.WriteLine($"Is Person 1 and Person 3 equal: {isEqual}");   

            var (id, fname, lname, email) = person2;
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"First Name: {fname}");
            Console.WriteLine($"Last Name: {lname}"); 


            // Point class for mutability
            var p1 = new Point(3,6);
            //p1 = p1 with {X = 6};
            p1.X = 6;
        }
    }

    record Person(int id, string FirstName, string LastName, string Email);

    // public class Point
    // {
    //     public int X { get;  }
    //     public int Y { get;  }


    //     public Point(int x, int y)
    //     {
    //         X = x;
    //         Y = y;
    //     }
    // }

    record Point(int X, int Y)
    {
        public int X { get; set; } = X;
        public int Y { get; set; } = Y;
    }

    // public class Person : IEquatable<Person>
    // {
    //     public int Id { get; set; }
    //     public string FirstName { get; set; }
    //     public string LastName { get; set; }
    //     public string Email { get; set; }

    //     public Person()
    //     {
            
    //     }
        
    //     public Person(int id, string fname, string lname)
    //     {
    //         Id = id;
    //         FirstName = fname;
    //         LastName = lname;
    //     }

    //     public override bool Equals(object obj) => obj is Person p && Equals(p);

    //     public bool Equals(Person other) =>
    //         other is object &&
    //             Id == other.Id &&
    //             FirstName == other.FirstName &&
    //             LastName == other.LastName;

    //     public override int GetHashCode() => HashCode.Combine(Id, FirstName, LastName);
    //     public override string ToString() => $"{FirstName} {LastName}";

    //     public void Deconstruct(out int id, out string fname, out string lname)
    //     {
    //         id = Id;
    //         fname = FirstName;
    //         lname = LastName;
    //     }
    // }
}

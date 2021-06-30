using System;
using System.Collections.Generic;
using System.Linq;

namespace Dotnet6
{
    class Program
    {
        static void Main(string[] args)
        {
            //DateOnly
            DateOnly date = new DateOnly(2021, 5, 31);
            Console.WriteLine(date.Year);
            Console.WriteLine(date.Month);
            Console.WriteLine(date.Day);

            Console.WriteLine(date.AddMonths(2));

            //TimeOnly
            TimeOnly time = new TimeOnly(16, 30, 10);
            Console.WriteLine(time.Hour);
            Console.WriteLine(time.Minute);
            Console.WriteLine(time.Second);

            Console.WriteLine(time.AddHours(2).AddMinutes(2));

            //MaxBy, MinBy
            var group1 = new List<(string Name, int Age)>()
            {
                (Name: "Vicki", Age: 24),
                (Name: "Leonard ", Age: 24),
                (Name: "Eve", Age: 29),
            };
                        var group2 = new List<(string Name, int Age)>()
            {
                (Name: "Eric", Age: 43),
                (Name: "David", Age: 24),
                (Name: "Lucy", Age: 34),
            };

            var max = group1.MaxBy(p => p.Age).Name;
            // Person with max age in group1: Eve

            var min = group1.MinBy(p => p.Age).Name;

            Console.WriteLine(max);
            Console.WriteLine(min);

            //DinstinctBy, UnionBy
            var distinct = group1
                .DistinctBy(p => p.Age)
                .Select(p => p.Name);
            // People with unique age in group1: Vicki, Eve

            var union = group1
                            .UnionBy(group2, p => p.Age)
                            .Select(p => p.Name);
            Console.WriteLine(distinct.Count());
            Console.WriteLine(union.Count());
            Console.WriteLine(union.ElementAt(^2));

            var numbers = new List<int>() { 3, 1, 4, 1, 5, 9 };
            var result = Enumerable
                            .Range(0, numbers.Count())
                            .Where(i => numbers[i] == 6)
                            .FirstOrDefault(-2);
            Console.WriteLine(result);
        }
    }
}

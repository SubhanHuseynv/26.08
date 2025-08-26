namespace Delegate__Anonymous_methods__Function__Action__Predicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Models.Person> people = new List<Models.Person>()
            {
                new Models.Person(){ Name="John", Surname="Doe", Age=30},
                new Models.Person(){ Name="Jane", Surname="Smith", Age=25},
                new Models.Person(){ Name="Sam", Surname="Brown", Age=40},
                new Models.Person(){ Name="Lucy", Surname="Johnson", Age=35},
            };
           people.ForEach(p => Console.WriteLine($"{p.Name} {p.Surname}, Age: {p.Age}"));
            people.FindAll(p => p.Name > "John").forEach(p => Console.WriteLine($"{p.Name} {p.Surname}, Age: {p.Age}"));
            people.FindAll(p => (p.Name.EndWith("ov") || p.Name.EndWith("ova"))).forEach(p => Console.WriteLine($"{p.Name} {p.Surname}, Age: {p.Age}"));
            people.FindAll(p=>p.Age>20).forEach(p => Console.WriteLine($"{p.Name} {p.Surname}, Age: {p.Age}"));
        }
        
    }
}

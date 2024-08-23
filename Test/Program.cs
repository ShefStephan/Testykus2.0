
internal class Program
{
    public static void Main(string[] args)
    {
        for (int i = 0; i < 4; i++)
        {
            Console.WriteLine(i);
        }
        Person tom = new("Tom", "Smith");

        Console.WriteLine(tom.lastname);    // Tom Smith

    }

    
}


class Person
{
    string firstName;
    string lastName;
    //public string Name
    //{
    //    get { return $"{firstName} {lastName}"; }

    //    set => firstName = value;
    //}


    public Person(string firstName, string lastName)
    {
        this.firstName = firstName;
        this.lastName = lastName;
    }
}
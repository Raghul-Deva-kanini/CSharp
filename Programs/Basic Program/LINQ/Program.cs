using LINQ;

delegate bool EligibilityCheck(People person);
class Program
{
    public static void Main(string[] args)
    {
        People[] people =
        {
            new People() {Name="Rad", Age=20},
            new People() {Name="Shiv", Age=14},
            new People() {Name="vasanth", Age=22},
            new People() {Name="Balan", Age=10},
            new People() {Name="Hari", Age=24 }
        };

        /*
        People[] voters = new People[people.Length];

        int i = 0;

        foreach (People person in people)
        {
            if (person.Age >= 18)
            {
                voters[i] = person;
                Console.WriteLine(person.Name);
                i++;
            }
        }
        

        List<People> voters = VoterCheck.where(people, delegate (People person)
        {
            return person.Age >= 18;
        });
        foreach (People voter in voters)
        {
            Console.WriteLine(voter.Name);
        }
        */

        //People[] voters = people.Where(p => p.Age >= 18).ToArray();

        //List<People> voters = people.Where(p => p.Age >= 18).ToList();

        /*
        var voters = from person in people where person.Age>=18 select person;
        
        foreach (People voter in voters)
        {
            Console.WriteLine(voter.Name);
        }
        */
        ExamplesForClassification ex = new ExamplesForClassification();
        //ex.example1();
        //ex.filteringwhere();
        //ex.filteringOfType();
        //ex.SortingOrderBy();
        ex.Grouping();
    }
}
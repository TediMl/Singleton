using Singleton;

public class Program
{
    public static void Main()
    {
        var numbers = Enumerable.Range(0, 10);
        foreach (var i in numbers)
        {
            var vm = VoteMachine.Instance;
            vm.RegisterVote();
        }
        Console.WriteLine(VoteMachine.Instance.TotalVote);
    }
}










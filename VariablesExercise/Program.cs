namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string tvShow = "Star Trek";
            int years = 6;
            char grade = 'A';
            bool watchAll = false;
            double watchPercent = 64.71;
            decimal watchHours = 591.942m;
            Console.WriteLine($"A TV show I love is {tvShow}. I first watched it {years} years ago. Have I watched all the content? {watchAll}. I have watched {watchPercent}% of the series, or {watchHours} hours.");
            Console.WriteLine($"As a former teacher, I give {tvShow} a solid {grade}!");
        }
    }
}

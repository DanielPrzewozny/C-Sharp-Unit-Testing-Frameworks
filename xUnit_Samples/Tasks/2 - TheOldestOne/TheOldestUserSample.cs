namespace Tasks._2___TheOldestOne;

public static class TheOldestUserSample
{
    private readonly static List<User> db = new UserDataBase().Users;

    public static void DisplayTheOldestUser()
    {
        if(!db.Any())
            Console.WriteLine("No user exists on the list");

        var theOldestUser = db.GetTheOldestOne();
        if (theOldestUser != null)
            Console.WriteLine($"The oldest user is {theOldestUser.Name} {theOldestUser.Surname}. Age: {theOldestUser.GetUserAge()}");
        else
            Console.WriteLine("No specific user found");
    }

    public static User? GetTheOldestOne(this List<User> db)
    {
        if (!db.Any())
        {
            Console.WriteLine("No user exists on the list");
            return null;
        }

        var firstUser = db.FirstOrDefault();
        var ageOfFirstUser = firstUser.GetUserAge();
        if (db.All(x => x.GetUserAge() == ageOfFirstUser))
        {
            Console.WriteLine("All users have the same age!");
            return null;
        }

        return db.MaxBy(u => u.GetUserAge()); 
    }

    public static int GetUserAge(this User input)
    {
        var age = DateTime.UtcNow.Year - input.DateOfBirth.Year;
        if (input.DateOfBirth > DateTime.UtcNow.AddYears(-age)) age--;
        return age;
    }
}

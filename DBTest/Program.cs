using System;

namespace DBTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello SQL Server Test");


            // Instanciate the database
            Context ourDatabase = new Context();

            foreach (var item in ourDatabase.Quest)
            {
                Console.WriteLine(item.Name);
            }



            // Create a new instance is quest.
            var quest = new QuestModel();

            quest.Name = "this is a new quest with reward";
            quest.Description = "go and pick up some flowers";
            quest.Rewards.Add(new RewardModel { Name = "flowers" });
            
            ourDatabase.Quest.Add(quest); // Adding this class to the database table
            ourDatabase.SaveChanges(); // Commits the class


            Console.WriteLine("It Worked! :D");
            Console.ReadKey();

        }
    }
}

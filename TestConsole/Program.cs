using Core.Entities.Utilities.EntityGenerator.Abstracts;
using System;
using System.Collections.Generic;
using TestConsole.Profiles;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            IEntityGenerator<Users> entityGenerator = new UserGeneratorProfile();
            ICollection<Users> list = entityGenerator.GenerateEntities(26);
            
            foreach (Users users in list)
            {
                Console.WriteLine($"{users}\n");
            }
        }
    }
}

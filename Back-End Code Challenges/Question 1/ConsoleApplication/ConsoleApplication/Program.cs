using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(ReturnLikes(new List<string> { "User1", "User2", "User3", "User4", "User5", "User6" }));
            Console.ReadLine();
        }

        public static string ReturnLikes(List<string> likes) 
        {
            if (likes?.Any() != true)
                throw new ArgumentNullException(nameof(likes));

            int count = likes.Count;

            switch (count) 
            {
                case 0: return "no one likes this";
                case 1: return $"{likes[0]} likes this";
                case 2: return $"{likes[0]} and {likes[1]} likes this";
                case 3: return $"{likes[0]}, {likes[1]} and {likes[2]} likes this";
                default: return $"{likes[0]}, {likes[1]} and {likes.Count - 2} others like this";
            }
        }
    }
}

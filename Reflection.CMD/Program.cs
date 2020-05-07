using System;
using System.Reflection;

namespace Reflection.CMD
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сюда введите путь к файлу.
            var path = @"Singleton.exe";

            var asm = Assembly.LoadFrom(path);

            Console.WriteLine($"Full Name: {asm.FullName}\n");

            var types = asm.GetTypes();

            Console.WriteLine("Assembly Types:\n");
            foreach(var type in types)
            {
                Console.WriteLine($"Type Name: {type.Name}");
                Console.WriteLine("Members:\n");
                foreach(var member in type.GetMembers())
                {
                    Console.WriteLine($"Member Name: {member.Name}");
                    Console.WriteLine($"Member Type: {member.MemberType}\n");
                }
            }
        }
    }
}
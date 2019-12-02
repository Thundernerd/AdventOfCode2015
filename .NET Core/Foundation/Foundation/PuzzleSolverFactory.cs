using System;
using System.IO;
using System.Reflection;

namespace TNRD.AdventOfCode.Foundation
{
    public class PuzzleSolverFactory
    {
        public static IPuzzleSolver Create()
        {
            if (!File.Exists("session_cookie.txt"))
            {
                Console.WriteLine("A file containing the session cookie is required to continue.");
                return null;
            }

            string sessionCookie = File.ReadAllText("session_cookie.txt");

            Assembly[] assemblies = AppDomain.CurrentDomain.GetAssemblies();
            foreach (Assembly assembly in assemblies)
            {
                Type[] types = assembly.GetTypes();

                foreach (Type type in types)
                {
                    if (!ValidateType(type))
                        continue;

                    return (IPuzzleSolver) Activator.CreateInstance(type, sessionCookie);
                }
            }

            return null;
        }

        private static bool ValidateType(Type type)
        {
            if (!type.IsSubclassOf(typeof(PuzzleSolver)))
                return false;

            if (type.IsAbstract)
                return false;

            return true;
        }
    }
}

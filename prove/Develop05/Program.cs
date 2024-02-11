// Exceeding Requirements: Added input validation for ints and files to be loaded.
// Added level based titles as a form of progress recognition to users.
using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager menu = new GoalManager();
        menu.Start();
    }
}
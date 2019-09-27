using System;

namespace OOP
{
    class Program
    {

        
        static void Main(string[] args)
        {
        
            BottomNavigation bottomNavigation = new BottomNavigation("Backgorund", "Video", "Editor");
            Console.WriteLine(bottomNavigation.NavigationWindows);
            bottomNavigation.CurrentFragment();
        }
    }
}

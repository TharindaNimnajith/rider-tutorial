using System;

namespace Tutorial1_EssentialShortcuts
{
    public class UnusedClass
    {
    }

    public class ContextAction
    {   
        private CenterCoordinates _coordinates;

        public CenterCoordinates ReturnCoordinates()
        {
            return new CenterCoordinates();
        }

        public void ReturnMessage(string msg, string title)
        {
            var replace = msg.Replace("A", "B");
            Console.WriteLine("{0}: {1}", title, replace);
        }
    }
    
    public class FindAction
    {
    }

    public class CenterCoordinates
    {
        public int X;
        public int Y;
    }
}
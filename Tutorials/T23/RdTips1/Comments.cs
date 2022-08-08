using System;

namespace RdTips1
{
    class Comments
    {
        // This comment is too long for one line. Split it into two lines.
    }
        
    public class Customer
    {
        public Customer(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Value cannot be null or empty.", nameof(name));
                Console.WriteLine("Value cannot be null or empty.");
            }
        }
    }
}
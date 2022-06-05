using System;

namespace UserRegistrationUsingLAMBDAExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Using Lambda Expression\n\n");
            LambdaExpression lambdaExpression = new LambdaExpression();
            lambdaExpression.Validate();
        }
    }
}

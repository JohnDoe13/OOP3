using System;

namespace OOP3
{
    //Som synes så är jag långt ifrån klar med denna uppgift.
    //Förstår principen i stora drag men att peta in de olika delarna/byggstenarna är 
    //en utmaning. Jag vill/kommer fortsätta jobba med denna.
    //Ni får den här tillsvidare. Hav förtröstan.
    class Program
    {
        public int input_age;
        //Ja, jag kommer åt variablerna.
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Person p = new Person();

            try
            {

                Console.WriteLine("Please enter your age:");
                p.Age = int.Parse(Console.ReadLine());
            }
            catch (System.ArgumentException e)
            {
                if (p.Age <= 0) 
                {
                    //throw new ArgumentException("Age must be greater than 0 <zero");
                    Console.WriteLine("Age must be greater than 0 <zero>", e);
                    //Console.WriteLine(e);
                }
            }

            try
            {

                Console.WriteLine("Please enter your Firstname:");
                p.Fname = Console.ReadLine();
            }
            catch (ArgumentException e)
            {
                if (p.Fname.Length >=2 || p.Fname.Length<=10)
                {
                    //throw new ArgumentException("{0}Firstname must be between 3 and 10 characters.",e);
                    Console.WriteLine("Age must be greater than 0 <zero>");
                }
            }
            try
            {

                Console.WriteLine("Please enter your Lastname:");
                p.Lname = Console.ReadLine();
            }
            catch (System.ArgumentException e)
            {
                if (p.Lname.Length <= 2 || p.Lname.Length <= 10)
                {
                    throw new ArgumentException("{0} Age must be greater than 0 <zero>",e);
                    //Console.WriteLine("Age must be greater than 0 <zero>");
                }
            }

           

           
        }
    }
}


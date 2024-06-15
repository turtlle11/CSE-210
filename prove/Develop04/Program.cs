using System;


class Program
{
    static void Main(string[] args)
    {

        string choice = "0";
        Console.WriteLine("Choose activity:\n1.Reflection Activity\n2.Breathing Activity\n3.Listing Activity\n4.End program.");
        choice = Console.ReadLine();
        while (choice != "0")
        {
            
            if (choice == "1")
            {
                Reflection reflection = new Reflection("Reflaction","This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.",0);
                reflection.Display_Reflaction_Activity();
                reflection.Display_End_Message("Reflection");
                reflection.Anomation(10);
                Console.Clear();
                Console.WriteLine("Choose activity:\n1.Reflection Activity\n2.Breathing Activity\n3.Listing Activity");
                choice = Console.ReadLine();
                
                
            }
            if (choice == "2")
            {
                Breathing breath =new Breathing("Breathing","This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.",0);
                breath.Display_Breathing_Activity();
                breath.Display_End_Message("Breathing");
                breath.Anomation(10);
                Console.Clear();
                Console.WriteLine("Choose activity:\n1.Reflection Activity\n2.Breathing Activity\n3.Listing Activity");
                choice = Console.ReadLine();
                
            }
            if (choice == "3")
            {
                Listing list = new Listing("Listing","This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.",0);
                list.Display_Listing_Activity();
                list.Display_End_Message("Listing");
                list.Anomation(10);
                Console.Clear();
                Console.WriteLine("Choose activity:\n1.Reflection Activity\n2.Breathing Activity\n3.Listing Activity");
                choice = Console.ReadLine();
                
            }
            
            if (choice == "0")
            Console.WriteLine("Have a good day!");
        }
            Console.WriteLine("Choose activity:\n1.Reflection Activity\n2.Breathing Activity\n3.Listing Activity");
            choice = Console.ReadLine();
    }
}
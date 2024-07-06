using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static int total_points = 0;
    static List<Goal> all_goals = new List<Goal>();
    static void Main(string[] args)
    {
        string choice = "6";
        Console.WriteLine("Your points are:" + total_points);
        Console.WriteLine("Choose what you want to do:\n1.Creat New Goal\n2.List Goals\n3.Save Goals\n4.Load Goals.\n5.Record Event.\n6.End Program.");
        choice = Console.ReadLine();
        while (choice != "6")
        {

            if (choice == "1")
            {
                Console.WriteLine("Choose type of goal:s-Simple, e-Eternal, c-Checklist");
                string variant = Console.ReadLine();
                if(variant=="s")
                {
                    Simple simple_goal = new Simple("","","",0);
                    simple_goal.Get_New_Goal();
                    all_goals.Add(simple_goal);
                }
                if(variant=="e")
                {
                    Eternal eternal_goal = new Eternal("","",0);
                    eternal_goal.Get_New_Goal();
                    all_goals.Add(eternal_goal);
                }
                if(variant=="c")
                {
                    Checklist checklist_goal = new Checklist("","","",0,0,0,0,0);
                    checklist_goal.Get_New_Goal();
                    all_goals.Add(checklist_goal);
                }
                Console.WriteLine("Your points are:" + total_points);
                Console.WriteLine("Choose what you want to do:\n1.Creat New Goal\n2.List Goals\n3.Save Goals\n4.Load Goals.\n5.Record Event.\n6.End Program.");
                choice = Console.ReadLine();

            }
            if (choice == "2")
            {
                foreach(Goal goal in all_goals)
                {
                    goal.Display();
                }
                Console.WriteLine("Your points are:" + total_points);
                Console.WriteLine("Choose what you want to do:\n1.Creat New Goal\n2.List Goals\n3.Save Goals\n4.Load Goals.\n5.Record Event.\n6.End Program.");
                choice = Console.ReadLine();

            }
            if (choice == "3")
            {
                Save_Goals();
                Console.WriteLine("Your points are:" + total_points);   
                Console.WriteLine("Choose what you want to do:\n1.Creat New Goal\n2.List Goals\n3.Save Goals\n4.Load Goals.\n5.Record Event.\n6.End Program.");
                choice = Console.ReadLine();

            }
            if (choice == "4")
            {
                Load_Goals();
                Console.WriteLine("Your points are:" + total_points);
                Console.WriteLine("Choose what you want to do:\n1.Creat New Goal\n2.List Goals\n3.Save Goals\n4.Load Goals.\n5.Record Event.\n6.End Program.");
                choice = Console.ReadLine();
            }
            if (choice == "5")
            {
                Record_Event();
                Console.WriteLine("Your points are:" + total_points);
                Console.WriteLine("Choose what you want to do:\n1.Creat New Goal\n2.List Goals\n3.Save Goals\n4.Load Goals.\n5.Record Event.\n6.End Program.");
                choice = Console.ReadLine();
            }
            if (choice == "6")
                Console.WriteLine("Have a good day!");
        }

    }
    public static void Save_Goals()
    {

        string fileName = "List_of_goals.txt";
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(total_points);
            foreach (Goal entry in all_goals)
            {
                outputFile.WriteLine(entry + " - " + entry.GetStringRepresentation());
            }
        }
    }

    public static void Record_Event()
    {
        int number = 0;
        foreach (Goal goal in all_goals)
        {
            number++;
            Console.WriteLine($"{number})" + goal.Get_Name());
        }
        Console.WriteLine("What goal do you want to record?");
        int choice = int.Parse(Console.ReadLine());
        Goal selected_goal = all_goals[choice-1];
        total_points += selected_goal.Set_Points();
    }

    public static void Load_Goals()
    {
        Goal goal_load;
        all_goals = new List<Goal>();
        string filename = "List_of_goals.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);
        int index = 0;
        foreach (string line in lines)
            {
                if(index == 0)
                {
                    total_points = int.Parse(line);
                }
                else
                {
                    string[] parts = line.Split(" - ");
                    string[] particles = parts[1].Split(": ");
                    if(parts[0] == "Simple")
                    {
                        string new_done = particles[0];
                        string new_name= particles[1];
                        string new_description = particles[2];
                        int new_points= int.Parse(particles[3]);                       
                        goal_load = new Simple(new_done, new_name, new_description, new_points);
                        all_goals.Add(goal_load);
                    }
                    else if(parts[0] == "Eternal")
                    {

                        string new_name= particles[0];
                        string new_description = particles[1];
                        int new_points= int.Parse(particles[2]);                       
                        goal_load = new Eternal(new_name, new_description, new_points);
                        all_goals.Add(goal_load);
                    }
                    else if(parts[0] == "Checklist")
                    {
                        string new_done = particles[0];
                        string new_name= particles[1];
                        string new_description = particles[2];
                        int new_points = 0;
                        int new_attempts_points = int.Parse(particles[3]);
                        int new_attempts= int.Parse(particles[5]);   
                        int new_bonus_points = int.Parse(particles[6]);
                        int new_check_attepts = int.Parse(particles[4]);                    
                        goal_load = new Checklist(new_done, new_name, new_description, new_points, new_attempts_points, new_attempts, new_bonus_points, new_check_attepts);
                        all_goals.Add(goal_load);
                    //     $"{this._done_sign}: {this._name_of_goal}: {this._goal_description}: {this._points_for_attempt}: {_check_attempts}: {this._attempts}: {_bonus_points}"
                    }
                    
                }
                index++;
            }
    }

}
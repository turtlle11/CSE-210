using System;

class Program
{
    static List<Activity> activity_list = new List<Activity>();
    static void Main(string[] args)
    {
        Running running_activity = new Running("20 July 2024", 25, 5);
        running_activity.Get_Pace();
        running_activity.Get_Speed();
        activity_list.Add(running_activity);
        
        Swimming swimming_activity = new Swimming("10 June 2030", 15, 10);
        swimming_activity.Get_Distance(); 
        swimming_activity.Get_Pace();
        swimming_activity.Get_Speed();
        activity_list.Add(swimming_activity);

        Cycling cycling_activity =new Cycling("12 August 2123", 20, 30);
        cycling_activity.Get_Distance();
        cycling_activity.Get_Pace();
        activity_list.Add(cycling_activity);

        foreach(Activity activity in activity_list)
        {
            activity.Summary();
        }
    }
}
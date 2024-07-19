using System;

class Program
{
    static void Main(string[] args)
    {
        // Event lecture_event = new Event();
        Lectures_event lecture = new Lectures_event("The Salt That Surrounds You: The Paradox Basin, Past and Present","What formed the dramatic valley that Moab calls home? Do you find the rocks that surround us beautiful? You can thank salt for all of that, and you can find out why from USU geoscientist Dr. Evey Gannaway Dalton. She will share what makes salt so special, how it shaped the landscapes from Salt Valley to Paradox Valley and everything in between, and why it makes southeastern Utah and southwestern Colorado a mecca for geoscientists like herself.",new Address("163 Hiney Road","Las Vegas","Nevada","USA" ),"Jul 25, 2024","07:00 pm - 08:30 pm","Dr. Evey Gannaway Dalton","250","Lecture"); 
        lecture.Standard_Event_Details();
        Console.WriteLine("----------------------------------------");
        lecture.Full_Event_Details();
        Console.WriteLine("----------------------------------------");
        lecture.Short_Event_Details();
        Console.WriteLine("----------------------------------------");
        Receptions_event reception = new Receptions_event("Wedding","We invite all people on wedding.",new Address("3179 Big Elm","Liberty","Missouri","USA"),"10/24/2025","13:30 PM","Reception","ben@gmail.com");
        reception.Standard_Event_Details();
        Console.WriteLine("----------------------------------------");
        reception.Full_Event_Details();
        Console.WriteLine("----------------------------------------");
        reception.Short_Event_Details();
        Console.WriteLine("----------------------------------------");
        Outdoor_gatherings_event outdoor = new Outdoor_gatherings_event("Clean City","We are going to clean the whole city, so come to joing us to make our city beautiful again", new Address("1689 Rockford Road","Dayton","Nevada","USA"),"Friday, September 20, 2024","1:00 PM - 7:00 PM","Heavy rain","Outdoor Gathering Event");
        outdoor.Standard_Event_Details();
        Console.WriteLine("----------------------------------------");
        outdoor.Full_Event_Details();
        Console.WriteLine("----------------------------------------");
        outdoor.Short_Event_Details();
    }
}
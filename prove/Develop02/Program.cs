using System;
using System.IO;
using System.IO.Compression;
using System.Reflection.Metadata;

class Program
{

    static void Main(string[] args)
    {
        string menu = @"
Select one of these numbers
1. New entry
2. Display
3. Save
4. Load
5. Quit";
        
        
        int end = 0;
        Journal J = new Journal();
        Console.WriteLine("Welcome");
        List<Entry> list= new List<Entry>();
        while(end != 5){
            Console.WriteLine(menu);
            string choice = Console.ReadLine();
            if (choice=="1"){
                PromptGen promp;
                promp = new PromptGen();
                string givpromp = promp.GenPrompt();

                DateTime date = DateTime.Now;
                string datetime = date.ToShortDateString();

                Entry B = new Entry ();
                B._givenPrompt = givpromp;
                B._entryDateTime = datetime;
                Console.WriteLine($"{givpromp}");
                Console.WriteLine("Enter response:");
                string resp = Console.ReadLine();
                B._givenResponse = resp;
                J.AddEntry(B);
                Console.WriteLine($"{givpromp}, {datetime}, {resp}");
            
            }
            else if (choice == "2"){
                J.Display2();
            }

            else if(choice=="3"){
                string fileName = "Journale.txt";
                list = J._entries; 

                using (StreamWriter outputFile = new StreamWriter(fileName))
                {
                    foreach(Entry entry in list)
                    {
                        outputFile.WriteLine(entry._givenPrompt + " - " + entry._givenResponse + " - " + entry._entryDateTime );
                    }
                }
            }

            else if(choice=="4"){
                
                string filename = "Journale.txt";
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(" - ");

                    string prompt = parts[0];
                    string answer = parts[1];
                    string date = parts[2];

                    Entry B = new Entry ();
                    B._givenPrompt = prompt;
                    B._entryDateTime = date;
                    B._givenResponse = answer;
                    J.AddEntry(B);
                }
            }
            else if(choice=="5"){
                Console.WriteLine("The end");
                end = 5;
            }
           
            
        }
       
        
    }
}
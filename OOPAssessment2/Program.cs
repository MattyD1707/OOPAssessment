using System;
using System.IO;

namespace OOPAssessment2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Finding Directory of the File
            string RawFile1 = Path.Combine(Directory.GetCurrentDirectory(), "GitRepositories_1a.txt");
            string RawFile2 = Path.Combine(Directory.GetCurrentDirectory(), "GitRepositories_1b.txt");
            string RawFile3 = Path.Combine(Directory.GetCurrentDirectory(), "GitRepositories_2a.txt");
            string RawFile4 = Path.Combine(Directory.GetCurrentDirectory(), "GitRepositories_2b.txt");
            string RawFile5 = Path.Combine(Directory.GetCurrentDirectory(), "GitRepositories_3a.txt");
            string RawFile6 = Path.Combine(Directory.GetCurrentDirectory(), "GitRepositories_3b.txt");

            //Read / store Files into Arrays
            string[] FiletoArr1 = File.ReadAllLines(RawFile1);
            string[] FiletoArr2 = File.ReadAllLines(RawFile2);
            string[] FiletoArr3 = File.ReadAllLines(RawFile3);
            string[] FiletoArr4 = File.ReadAllLines(RawFile4);
            string[] FiletoArr5 = File.ReadAllLines(RawFile5);
            string[] FiletoArr6 = File.ReadAllLines(RawFile6);

            //Putting Array info into string for comparison later
            string File1 = string.Join("",FiletoArr1);
            string File2 = string.Join("",FiletoArr2);
            string File3 = string.Join("",FiletoArr3);
            string File4 = string.Join("",FiletoArr4);
            string File5 = string.Join("",FiletoArr5);
            string File6 = string.Join("",FiletoArr6);

            Console.WriteLine("choose your first file 1,2,3,4,5,6");
            var Choice = Console.ReadLine();
            if (Choice == "1")
            {
                Choice = File1;
            }
            if (Choice == "2")
            {
                Choice = File2;
            }
            if (Choice == "3")
            {
                Choice = File3;
            }
            if (Choice == "4")
            {
                Choice = File4;
            }
            if (Choice == "5")
            {
                Choice = File5;
            }
            if (Choice == "6")
            {
                Choice = File6;
            }

            Console.WriteLine("choose your second file 1,2,3,4,5,6");
            var Choice2 = Console.ReadLine();
            if (Choice2 == "1")
            {
                Choice2 = File1;
            }
            if (Choice2 == "2")
            {
                Choice2 = File2;
            }
            if (Choice2 == "3")
            {
                Choice2 = File3;
            }
            if (Choice2 == "4")
            {
                Choice2 = File4;
            }
            if (Choice2 == "5")
            {
                Choice2 = File5;
            }
            if (Choice2 == "6")
            {
                Choice2 = File6;
            }





            if (Choice == Choice2)
            {
                Console.WriteLine("Same");
            }
            else
            {
                Console.WriteLine("different");
            }
            Console.ReadKey();
        }

    }


}
//GitRepositories_1a
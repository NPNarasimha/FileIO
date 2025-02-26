using System;
using System.IO;

namespace FileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\Sai Indu\KrishnaSai\Krishna.txt";
            // Exist method return bool it exist or not
            if (File.Exists(path))
            {
                Console.WriteLine("Exist");
            }
            else
            {
                Console.WriteLine("Not Exist");
            }
            Console.WriteLine();
            //reading the Lines in the file.

            string[] str = File.ReadAllLines(path);
            for (int i = 0; i < str.Length; i++)
            {
                //using the indexs by line by line  in the  file 
                Console.WriteLine(str[i]);
            }
            Console.WriteLine();

            //Read the all text in the File.
            string str1 = File.ReadAllText(path);
            Console.WriteLine(str1);
            //The method is used to make a copy of an existing file
            Console.WriteLine();
            Console.WriteLine("File copy from one file to another file");
            string path1 = @"C:\Users\Sai Indu\KrishnaSai\Krishna.txt";
            string newFilePath = @"C:\Users\Sai Indu\KrishnaSai\Sai.txt";
            //File.Copy(path1, newFilePath);//it works only once in copy.
            string newFileText = File.ReadAllText(newFilePath);
            Console.WriteLine(newFileText);

            Console.WriteLine();

            //The method is used to delete an existing file
            // File.Delete(newFilePath);

            Console.WriteLine();

            Console.WriteLine("Write the content in the file : ");
            string content = "Hi ra how are you, every thing is good? ";
            string filePath = @"C:\Users\Sai Indu\KrishnaSai\WriteText.txt";
            File.WriteAllText(filePath, content);
            Console.WriteLine(File.ReadAllText(filePath));

            Console.WriteLine();
            Console.WriteLine("Appeand the content in the existing content : ");
            string appendContent = "Ya all good Krishna !";
            File.AppendAllText(filePath, appendContent);
            Console.WriteLine(File.ReadAllText(filePath));
            //streamReader
            Console.WriteLine("_____________________________________________");
            string pathFile = @"C:\Users\Sai Indu\KrishnaSai\Krishna.txt";
            StreamReader sr = new StreamReader(pathFile);
            string s = "";
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s + " ");
            }
            Console.WriteLine("___________________________________________");
            //streamWrite
            Console.WriteLine("\nWriting to Narasimha.txt using StreamWriter:");
            string pathFiles = @"C:\Users\Sai Indu\KrishnaSai\Narasimha.txt";

            using (StreamWriter sw = new StreamWriter(pathFiles, true))  // 'true' enables append mode
            {
                sw.WriteLine("Hello Krishna! What are you doing?");
                Console.WriteLine();
            } // `using` ensures StreamWriter is closed properly

            Console.WriteLine("Updated contents of Narasimha.txt:");
            Console.WriteLine(File.ReadAllText(pathFiles));


        }
    }
}

using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using CsvHelper;
using System.Globalization;
using Newtonsoft.Json;


namespace FileIO
{
    public class Program
    {
       
         static void Main(string[] args)
        {
            /////////////////////////////////Employeee Csv/////////////////////////////////////////
          /*  // instal csvhelper in nuget manager
             //Employee csv File 
             List<Employee> empData = new List<Employee>{ 

             new Employee { EmpId = 101, EmpName = "Krishna", EmpSalary = 45333, EmpRole = "Software Developer" },
             new Employee { EmpId = 102, EmpName = "Krishna Sai", EmpSalary = 34443, EmpRole = "Software Engineer" },
             new Employee { EmpId = 103, EmpName = "Np", EmpSalary = 45454, EmpRole = "Software Tester" },
             new Employee { EmpId = 104, EmpName = "Narasimha", EmpSalary = 84848, EmpRole = "Software Traine" }
            };


             string csvPath = @"C:\Users\Sai Indu\source\repos\FileIO\FileIO\csvEmployee.csv";
             //File.Create(csvPath);
             /*  //read data into streamwriter to csvwriter
               using(var sw = new StreamWriter(csvPath))
                   using(var csvWriter=new CsvWriter(sw,CultureInfo.InvariantCulture))//CultureInfo.InvariantCulture ensures that data is formatted consistently
               {
                   csvWriter.WriteRecords(empData);
               }
             */

          /*  using (var reader = new StreamReader(csvPath))
            using (var csvReader = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                var records = csvReader.GetRecords<Employee>();
                foreach (var emp in records)
                {
                    Console.WriteLine($"EpId ={emp.EmpId}, EmpName ={emp.EmpName}, EmpSalary ={emp.EmpSalary}, EmpRole ={emp.EmpRole}");
                }

            }
          */



            ////////////////////////////////////////Student CSV///////////////////////////////////////////////////

            /*      //Student Csv Formate
                  List<Student> stdData = new List<Student>
                  {
                      new Student{StdId=101,StdName="krishna",StdBranch="CSE"},
                      new Student{StdId=102,StdName="sai",StdBranch="CSE"},
                      new Student{StdId=103,StdName="Narasimha",StdBranch="Mech"},
                      new Student{StdId=104,StdName="Np",StdBranch="ECE"}

                  };

                  string csvPathStd = @"C:\Users\Sai Indu\source\repos\FileIO\FileIO\csvStudent.csv";
                  //File.Create(csvPathStd);
                  /*  using(var sw=new StreamWriter(csvPathStd))
                    using (var csvWrite = new CsvWriter(sw, CultureInfo.InvariantCulture))
                    {
                        csvWrite.WriteRecords(stdData);
                    }
                  */
            /* using (var sr = new StreamReader(csvPathStd))
             using (var csvStdReader = new CsvReader(sr,CultureInfo.InvariantCulture))
             {
                 var records = csvStdReader.GetRecords<Student>();
                 foreach (var rec in records)
                 {
                     Console.WriteLine($"StdId ={rec.StdId}, StdName ={rec.StdName}, stdBranch ={rec.StdBranch}");
                 }
             }
            */

            //////////////////////////////////Update the data in csv//////////////////////////////
            List<Student> stdData = new List<Student>
                  {
                      new Student{StdId=101,StdName="krishna",StdBranch="CSE"},
                      new Student{StdId=102,StdName="sai",StdBranch="CSE"},
                      new Student{StdId=103,StdName="Narasimha",StdBranch="Mech"},
                      new Student{StdId=104,StdName="Np",StdBranch="ECE"}

                  };

            string csvPathStdUpdate = @"C:\Users\Sai Indu\source\repos\FileIO\FileIO\csvStdUdate.csv";
            //File.Create(csvPathStdUpdate);
            /*  using(var sw=new StreamWriter(csvPathStdUpdate))
               using (var csvWrite = new CsvWriter(sw, CultureInfo.InvariantCulture))
               {
                   csvWrite.WriteRecords(stdData);
               }
             */

            foreach (Student student in stdData)
            {
                if(student.StdId == 101)
                {
                    student.StdName = "Kowsalya";

                }
            }
            using (var sw = new StreamWriter(csvPathStdUpdate))
            using (var csvWrite = new CsvWriter(sw, CultureInfo.InvariantCulture))
            {
                csvWrite.WriteRecords(stdData);
            }

            using (var sr = new StreamReader(csvPathStdUpdate))
             using (var csvStdReader = new CsvReader(sr,CultureInfo.InvariantCulture))
             {
                 var records = csvStdReader.GetRecords<Student>();
                 foreach (var rec in records)
                 {
                     Console.WriteLine($"StdId ={rec.StdId}, StdName ={rec.StdName}, stdBranch ={rec.StdBranch}");
                 }
             }


            ////////////////////////////////////////Employee Json////////////////////////////////////////////////
            //instal the NewtonSoft.json

            /*    string jsonPath = @"C:\Users\Sai Indu\source\repos\FileIO\FileIO\JsonEmployee.json";
                //File.Create(jsonPath);//it create only once 
                List<Employee> empData = new List<Employee>{

                 new Employee { EmpId = 101, EmpName = "Krishna", EmpSalary = 45333, EmpRole = "Software Developer" },
                 new Employee { EmpId = 102, EmpName = "Krishna Sai", EmpSalary = 34443, EmpRole = "Software Engineer" },
                 new Employee { EmpId = 103, EmpName = "Np", EmpSalary = 45454, EmpRole = "Software Tester" },
                 new Employee { EmpId = 104, EmpName = "Narasimha", EmpSalary = 84848, EmpRole = "Software Traine" }
                };
                //using serilization and deserilization write the data and read the data
                /*
                string jsonData=JsonConvert.SerializeObject(empData,Formatting.Indented); 
                File.WriteAllText(jsonPath,jsonData);
                */
            /* string jsonRead=File.ReadAllText(jsonPath);
             var deserilizationData=JsonConvert.DeserializeObject<List<Employee>>(jsonRead);// <List<Employee>> It create the new List and store the data in this list
             foreach (var emp in deserilizationData)
             {
                 Console.WriteLine($"EmpId ={emp.EmpId}, EmpName ={emp.EmpName}, EmpSalary ={emp.EmpSalary}, EmpRole={emp.EmpRole}");
            }
          */

            ////////////////////////////////Json Student /////////////////////////////////////////////

            /*  string stdPath = @"C:\Users\Sai Indu\source\repos\FileIO\FileIO\JsonStudent.json";
              //File.Create(stdPath);

              List<Student> stdData = new List<Student>
                    {
                        new Student{StdId=101,StdName="krishna",StdBranch="CSE"},
                        new Student{StdId=102,StdName="sai",StdBranch="CSE"},
                        new Student{StdId=103,StdName="Narasimha",StdBranch="Mech"},
                        new Student{StdId=104,StdName="Np",StdBranch="ECE"}

                    };


              /*
              string stdDatajson=JsonConvert.SerializeObject(stdData,Formatting.Indented);
              File.WriteAllText(stdPath,stdDatajson);
              */

            /*  var jsonReader=File.ReadAllText(stdPath);
              var deserilizableData=JsonConvert.DeserializeObject<List<Student>>(jsonReader);
              foreach (var std in deserilizableData)
              {
                  Console.WriteLine($"StdId ={std.StdId}, StdName ={std.StdName}, stdBranch ={std.StdBranch}");

              }
            */




            /*  string path = @"C:\Users\Sai Indu\KrishnaSai\Krishna.txt";
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

              */





        }
    }
}

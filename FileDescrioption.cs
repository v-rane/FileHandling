using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHandling;

namespace FileHandling
{
    public class FileDescription
    {
        public void getFileDescription(string currentDirectory)
        {
            /*
             * @MethodName - getFileDescription
             * @objective - to get files description i.e. name with size
             * @para - string
             * @return - void
             */

            //array filePath will have all files of currentDirectory
            string[] filePath = Directory.GetFiles(currentDirectory);
            //if array filePath has more files then condition is true
            if (filePath.Length > 0)
            {
                //dictionary for taking key as jar file and List of the subDirectories as values
                Dictionary<string, List<string>> fileDescriptionsDic = new Dictionary<string, List<string>>();

                //filePath array is iterated to add files for particular type ,eg. .java is created and List of subdirectories is added 
                foreach (string str in filePath)
                {
                    //if dictionary has filepath then it will add file under it othrwise new List is created and add in it
                    if (fileDescriptionsDic.ContainsKey(Path.GetExtension(str)))
                    {
                        fileDescriptionsDic[Path.GetExtension(str)].Add(str);
                    }
                    else
                    {
                        //in this extention make new list for it and add respective files in that file extension
                        fileDescriptionsDic[Path.GetExtension(str)] = new List<string>();
                        fileDescriptionsDic[Path.GetExtension(str)].Add(str);
                    }
                }
                foreach (string str in fileDescriptionsDic.Keys)
                {
                    //keys put in fileList of fileDescriptionsDic
                    var fileList = fileDescriptionsDic[str];
                    foreach (string file in fileList)
                    {
                        Console.WriteLine($"File Name :{Path.GetFileName(file)}, File Size : {Path.GetFileName(file).Length}kb");
                    }
                    Console.WriteLine("---------------------------------------------------------------------------------------------------");
                }
            }
        }
    }
}


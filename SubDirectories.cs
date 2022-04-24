using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileHandling;
using System.Collections;
using System.IO;

namespace FileHandling
{
    public class SubDirectories
    {
        /*
         * @MethodName - SubDirectories
         * @objective - to print the sub directries of the passed directory name
         * @para - String
         */
        public void getSubDirectries(String workingDirectory)
        {
            //queue to add and remove path 
            Queue<String> directoryQueue = new Queue<String>();
            //enqueue - to add path of the working directory
            directoryQueue.Enqueue(workingDirectory);
            //to check if elements are present or not in queue
            while (directoryQueue.Count > 0)
            {
                //empty the queue and print that path in to currentDirectory
                String currentDirectory = directoryQueue.Dequeue().ToString();
                Console.WriteLine(currentDirectory);

                FileDescription fileDescription = new FileDescription();
                fileDescription.getFileDescription(currentDirectory);
                //to get subdrirectories of the passed path and storing in array
                string[] subDirectories = Directory.GetDirectories(currentDirectory);

                if (subDirectories.Length > 0)
                {
                    //to print all subdirectories in array on console
                    foreach (string subDirectory in subDirectories)
                    {
                        directoryQueue.Enqueue(subDirectory);
                    }
                }
                //if it has more subdirectories then loop will continue
                else
                    continue;
                Console.WriteLine("------------------------------------------------------------------------------------------------------");
            }
           

        }
    }
}

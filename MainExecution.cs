using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    /*
     *@className -  MainExecution
     *@Objective - to pass the directory name
     *@Date - 17-4-22
     *@autherName- Varsha rane
     */
    public class MainExecution
    {
         static void Main(String[] args)
         {
            const string WorkingDirectory = "C:\\Users\\Varsha Rane\\Desktop";
            SubDirectories subDirectories = new SubDirectories();
            //passing Workingdirectory path in getSubDirectories
            subDirectories.getSubDirectries(WorkingDirectory);

         
        }
    }
}

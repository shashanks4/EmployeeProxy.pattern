using System;
namespace EmployeeProxy
{
    //Real object
    public class SharedFolder:ISharedFolder
    {
        public void PerformRWOperations()
        {
            Console.WriteLine("Performing Read Write operation on the Shared Folder");
        } 
    }
}
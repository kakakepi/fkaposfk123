using System.Collections.Generic;
using System.Dynamic;


namespace HW8
{
    internal class Customer : Employee
    {
        public string name;
        List<Project> projectList = new List<Project>();
        public Customer(string name)
        {
            name = name;
            projectList = new List<Project>();
        }
        public bool checkReport(bool isLegit)
        {
            if (isLegit == true)
                return true;
            else{
                return false;
            }
        }
    }
    
}
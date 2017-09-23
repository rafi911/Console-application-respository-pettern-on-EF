using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Advanced_Csharp
{
    public class Program
    {
        
        static void Main(string[] args)
        {

            DataAccessLayer<User> UserDb = new DataAccessLayer<User>();
            DataAccessLayer<Employee> EmployeeDb = new DataAccessLayer<Employee>();

            // add user
            //var isAdd = UserDb.Add(new User() { ID = 1, Name = "Rafi", Age = 23, Email = "rafi4439@gmail.com" });
            
            // add employee
            //var isAdd = EmployeeDb.Add(new Employee() { ID = 2, Name = "John", Email = "john@gmail.com" });
            //if (isAdd)
            //{
            //    Console.WriteLine("new person added Sucessfully");

            //}

            Console.WriteLine("List of Users");
            var listOfUser = UserDb.SelectAll();
            foreach (var user in listOfUser)
            {
                Console.WriteLine("Name : {0}, Age : {1}, Email : {2}",user.Name,user.Age,user.Email);
            }

            Console.WriteLine("List of Employees");
            var listOfEmployees = EmployeeDb.SelectAll();
            foreach (var emp in listOfEmployees)
            {
                Console.WriteLine("Name : {0}, Email : {1}", emp.Name, emp.Email);
            }


        }

       
        
    }
}

using System;
using System.Collections;
using System.Collections.Generic;

namespace ProlificsProjectManager
{
    // CLASS FOR PROJECT PART
    public class Project
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        // LIST TO STORE THE PROJECTS
        public List<Project> Projects = new List<Project>();
        //CONSTRUCTOR FOR METHOD PART
        public Project(int id, string? name, DateTime startdate, DateTime enddate)
        {
            Id = id;
            Name = name;
            StartDate = startdate;
            EndDate = enddate;
        }
        //CONSTRUCTOR FOR MAIN 
        public Project() { }
        //ADD ROLES METHOD
        public void AddProjects()
        {
            Console.WriteLine("\nEnter Project Id \n");
            Id =  System.Convert.ToInt32(Console.ReadLine());
            if (Id < 0)
            {

                throw new Exception("PROJECT ID SHOULD NOT BE NEGATIVE");
            }

            Console.WriteLine("\nEnter Project Name\n");
            Name = Console.ReadLine();
            if (Name == "")
            {

                throw new Exception("PROJECT NAME COULD NOT BE NULL");
            }

            Console.WriteLine("\nEnter Project Start Date\n");
            StartDate = System.Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("\nEnter Project END Date\n");
            EndDate = System.Convert.ToDateTime(Console.ReadLine());
            // OBJECT TO STORE THE USER DATA
            Project ProjectObj = new Project(Id, Name, StartDate, EndDate);
            Projects.Add(ProjectObj);
        }

        //DISPLAY PROJECTS     
        public void DisplayProjects()
        {
            Console.WriteLine("\nPROJECTS ARE\n");
            Console.WriteLine("------------------------------");
            foreach (Project obj in Projects)
            {
                Console.WriteLine("ID: {0}\nName:{1}\nStartDate: {2}\nEndDate :{3}\n ", obj.Id, obj.Name, obj.StartDate, obj.EndDate);
            }
        }
    }

    // CLASS FOR ROLE PART
    public class Role
    {
        public int Id { get; set; }
        public string? Name { get; set; }

        // LIST TO STORE THE ROLES
        public List<Role> Roles = new List<Role>();
        //CONSTRUCTOR FOR METHOD PART
        public Role(int id, string? name)
        {
            Id = id;
            Name = name;
        }
        //CONSTRUCTOR FOR MAIN 
        public Role() { }

        //ADD PROJECTS METHOD
        public void AddRoles()
        {
            Console.WriteLine("\nEnter Role Id \n");
            Id =  System.Convert.ToInt32(Console.ReadLine());
            if (Id < 0)
            {

                throw new Exception("ROLE ID SHOULD NOT BE NEGATIVE");
            }

            Console.WriteLine("\nEnter Role Name\n");
            Name = Console.ReadLine();
            if (Name == "")
            {

                throw new Exception("ROLE NAME COULD NOT BE NULL");
            }

            // OBJECT TO STORE THE USER DATA
            Role RoleObj = new Role(Id, Name);
            Roles.Add(RoleObj);
        }

        //DISPLAY ROLES  
        public void DisplayRoles()
        {
            Console.WriteLine("\nROLES ARE\n");
            Console.WriteLine("------------------------------");
            foreach (Role obj in Roles)
            {
                Console.WriteLine("ID: {0}\nName:{1}\n", obj.Id, obj.Name);
            }
        }
    }


    //CLASS FOR EMPLOYEE PART

    public class Employee
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int Mobile { get; set; }
        public string? Address { get; set; }

        // LIST TO STORE THE EMPLOYESS
        public List<Employee> Employees = new List<Employee>();
        //CONSTRUCTOR FOR METHOD PART
        public Employee(int id, string? firstname, string? lastname, string? email, int mobile, string? address)
        {
            Id = id;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Mobile = mobile;
            Address = address;
        }
        //CONSTRUCTOR FOR MAIN 
        public Employee() { }
        //ADD EMPLOYEES METHOD
        public void AddEmployees()
        {
            Console.WriteLine("\nEnter Employee Id \n");
            Id =  System.Convert.ToInt32(Console.ReadLine());
            if (Id < 0)
            {

                throw new Exception("EMPLOYEE ID SHOULD NOT BE NEGATIVE");
            }

            Console.WriteLine("\nEnter Employee First Name\n");
            FirstName = Console.ReadLine();
            if (FirstName == "")
            {

                throw new Exception("EMPLOYEE FIRST NAME COULD NOT BE NULL");
            }

            Console.WriteLine("\nEnter Employee Last Name\n");
            LastName = Console.ReadLine();
            if (LastName == "")
            {

                throw new Exception("EMPLOYEE LAST NAME COULD NOT BE NULL");
            }

            Console.WriteLine("\nEnter Employee Email\n");
            Email = Console.ReadLine();
            if (Email == "")
            {

                throw new Exception("EMPLOYEE EMAIL COULD NOT BE NULL");
            }

            Console.WriteLine("\nEnter Employee Mobile Number \n");
            Mobile =  System.Convert.ToInt32(Console.ReadLine());
            if (Mobile < 0)
            {

                throw new Exception("EMPLOYEE NUMBER SHOULD NOT BE NEGATIVE");
            }

            Console.WriteLine("\nEnter Employee Address\n");
            Address = Console.ReadLine();
            if (Address == "")
            {

                throw new Exception("EMPLOYEE ADDRESS COULD NOT BE NULL");
            }

            // OBJECT TO STORE THE USER DATA
            Employee EmployeeObj = new Employee(Id, FirstName, LastName, Email, Mobile, Address);
            Employees.Add(EmployeeObj);
        }

        //DISPLAY EMPLOYEES
        public void DisplayEmployees()
        {
            Console.WriteLine("\nEMPLOYEES ARE\n");
            Console.WriteLine("------------------------------");
            foreach (Employee obj in Employees)
            {
                Console.WriteLine("ID: {0}\nFirstName:{1}\nLastName:{2}\nEmail:{3}\nMobile:{4}\nAddress:{5}\n", obj.Id, obj.FirstName, obj.LastName, obj.Email, obj.Mobile, obj.Address);

            }
        }
    }

    //MAIN FUCTION START
    public class Program
    {
        
        public static void Main(string[] args)
        {
            // CREATE OBJECT FOR PROJECT CLASS
            Project ProjectObj = new Project();
            // CREATE OBJECT FOR ROLE CLASS
            Role RoleObj = new Role();
            // CREATE OBJECT FOR EMPLOYEE CLASS
            Employee Employeeobj = new Employee();
            int SelectedOption = 0;

            do
            {
                try
                {
                    //MENU DRIVEN FUCTION
                    System.Console.WriteLine("CHOSE REQUIRE OPTION");
                    System.Console.WriteLine("-------------------------------------------------------------");
                    System.Console.WriteLine("1.ADD PROJECT");
                    System.Console.WriteLine("2.VIEW PROJECTS");
                    System.Console.WriteLine("3.ADD ROLE");
                    System.Console.WriteLine("4.VIEW ROLE");
                    System.Console.WriteLine("5.ADD EMPLOYEE");
                    System.Console.WriteLine("6.VIEW EMPLOYEES");
                    System.Console.WriteLine("7.EXIT");
                    System.Console.WriteLine("ENTER YOUR OPTION:: ");
                    SelectedOption =  System.Convert.ToInt32(Console.ReadLine());

                    switch (SelectedOption)
                    {
                        case 1:
                            ProjectObj.AddProjects();//CALLING FUCTION
                            break;
                        case 2:
                            ProjectObj.DisplayProjects();//CALLING FUCTION
                            break;
                        case 3:
                            RoleObj.AddRoles();//CALLING FUCTION
                            break;
                        case 4:
                            RoleObj.DisplayRoles();//CALLING FUCTION
                            break;
                        case 5:
                            Employeeobj.AddEmployees();//CALLING FUCTION
                            break;
                        case 6:
                            Employeeobj.DisplayEmployees();//CALLING FUCTION
                            break;
                        default:
                            if (SelectedOption >= 8)
                            {
                                Console.WriteLine("\nPLEASE ENTER THE VALUE BETWEEN 1 TO 7 THANK YOU!\n");
                            }
                            break;
                    }
                }
                catch (Exception exp)//EXCEPTION HANDLING
                {
                    System.Console.WriteLine("Message : {0}", exp.Message);
                }

            } while (SelectedOption != 7);


        }

    }
}

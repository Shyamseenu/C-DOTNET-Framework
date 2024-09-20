/* Create an Employee class with following properties
EmployeeName as string
EmployeeID as int
Salary as double

Create another class called EmployeeDAL which has the following methods.
1. Create an ArrayList within this class
2. Define the below methods
a. public bool AddEmployee(Employee e) 
b. public bool DeleteEmployee(int id) 
c. public string SearchEmployee(int id) : Returns the employee name if found else return null 
d. public Employee[] GetAllEmployeesistAll()
Use an ArrayList to store the employees
Write a test program to test all the functionalities. */

using System;
using System.Collections;

class Employee
{
    public string EmployeeName { get; set; }
    public int EmployeeID { get; set; }
    public double Salary { get; set; }

    public Employee(string employeeName, int employeeID, double salary)
    {
        EmployeeName = employeeName;
        EmployeeID = employeeID;
        Salary = salary;
    }

    public override string ToString()
    {
        return $"Employee ID: {EmployeeID}, Name: {EmployeeName}, Salary: {Salary}";
    }
}

class EmployeeDAL
{
    private ArrayList employeeList = new ArrayList();

    public bool AddEmployee(Employee e)
    {
        employeeList.Add(e);
        return true;
    }

    public bool DeleteEmployee(int id)
    {
        foreach (Employee e in employeeList)
        {
            if (e.EmployeeID == id)
            {
                employeeList.Remove(e);
                return true;
            }
        }
        return false;
    }

    public string SearchEmployee(int id)
    {
        foreach (Employee e in employeeList)
        {
            if (e.EmployeeID == id)
            {
                return e.EmployeeName;
            }
        }
        return null;
    }

    public Employee[] GetAllEmployees()
    {
        return (Employee[])employeeList.ToArray(typeof(Employee));
    }
}

class EmployeeTest
{
    static void Main(string[] args)
    {
        EmployeeDAL employeeDAL = new EmployeeDAL();

        // Adding employees
        Employee emp1 = new Employee("John Doe", 101, 50000);
        Employee emp2 = new Employee("Jane Smith", 102, 60000);
        Employee emp3 = new Employee("Emily Johnson", 103, 70000);

        employeeDAL.AddEmployee(emp1);
        employeeDAL.AddEmployee(emp2);
        employeeDAL.AddEmployee(emp3);

        // Searching for an employee
        Console.WriteLine("Searching for employee with ID 102: " + employeeDAL.SearchEmployee(102));

        // Deleting an employee
        Console.WriteLine("Deleting employee with ID 101: " + employeeDAL.DeleteEmployee(101));

        // Listing all employees
        Console.WriteLine("Listing all employees:");
        Employee[] allEmployees = employeeDAL.GetAllEmployees();
        foreach (Employee e in allEmployees)
        {
            Console.WriteLine(e);
        }
    }
}

// See https://aka.ms/new-console-template for more information
using CS_Employee_Dictionary.Models;

Console.WriteLine("Hello, World!");
Dictionary<string, List<Employee>> employees = new Dictionary<string, List<Employee>>();
employees.Add("Director", new List<Employee>()
{
   

   (Director) new () { EmpNo=1,EmpName="D1",Salary = 80000,
    AirFare = 9000,
    MobileAllowance = 8000 },
   (Director) new () { EmpNo = 2,
    EmpName = "D2",
    Salary = 70000,
    AirFare = 5000,
    MobileAllowance = 3000 },
   
   
   
}
 );

employees.Add("Manager", new List<Employee>()
{
(Manager) new () { EmpNo = 3,
    EmpName = "M1",
    Salary = 30000,
    HouseRentAllowance = 9000,
    PetrolAllowance = 7000
   },
   (Manager) new () { EmpNo = 4,EmpName = "M2",
    Salary = 40000,
    HouseRentAllowance = 8000,
    PetrolAllowance = 4000
   }
}
 );

employees.Add("Employee",new List<Employee>()
{
     new ()
   {
       EmpNo = 5,
       EmpName = "E1",
       Salary = 45000
   },
   new()
   {
       EmpNo = 6,
       EmpName = "E2",
       Salary = 30000
   }

}


   );

//Print All Employee
printAllEmployee(employees);



//Print Employee By designation
string Designation = "Director";
printEmployeeByDesignation(employees, Designation);


void printEmployeeByDesignation(Dictionary<string, List<Employee>> employees,string Designation)
{
    switch (Designation)
    {
        case "Director":
            var resD = employees.TryGetValue("Director", out List<Employee> employeesD);
            foreach (var item in employeesD)
            {


                {
                    Console.WriteLine($"EmpNo : {item.EmpNo}  Name : {item.EmpName}  Salary : {item.Salary}  AirFare : {((Director)item).AirFare} MobileAllowance :{((Director)item).MobileAllowance} ");

                }
            }
            break;
        case "Manager":
            var resM = employees.TryGetValue("Manager", out List<Employee> employeesM);
            foreach (var item in employeesM)
            {


                {
                    Console.WriteLine($"EmpNo : {item.EmpNo}  Name : {item.EmpName} Salary : {item.Salary}  HouseRentAllowance : {((Manager)item).HouseRentAllowance} PetrolAllowance :{((Manager)item).PetrolAllowance} ");

                }
            }
            break;
        case "Employee":
            var resE = employees.TryGetValue("Employee", out List<Employee> employees2);

            foreach (var item in employees2)
            {


                {
                    Console.WriteLine($"EmpNo : {item.EmpNo}    EmpName : {item.EmpName}    Salary : {item.Salary}");
                }
            }
            break;
        default:
            Console.WriteLine("");
            break;


    }


}




//print all Employees
void printAllEmployee(Dictionary<string, List<Employee>> employees)
{
    foreach (var i in employees)
    {
        foreach (var j in i.Value)
        {
            Console.WriteLine($"EmpNo : {j.EmpNo}   EmpName :  {j.EmpName}  Salary: {j.Salary}");
        }
    }

}



//PrintAll Employee
//void printAllEmployee(Dictionary<string, List<Employee>> result)
//{
//    var allEmployees = result.Values.ToList();
//    foreach (var item in allEmployees)
//    {
//        Console.Write($"EmpNo {item.E}");
//    }

//}
//if (employees.ContainsKey("Direcor"))
//{
//    Console.WriteLine($"Id : {item.EmpNo}  Name : {item.EmpName}  Salary : {item.Salary}  AirFare : {((Director)item).AirFare} MobileAllowance :{((Director)item).MobileAllowance} ");
//}
//else if (employees.ContainsKey("Manager"))
//{
//    Console.WriteLine($"Id : {item.EmpNo}  Name : {item.EmpName} Salary : {item.Salary}  HouseRentAllowance : {((Manager)item).HouseRentAllowance} PetrolAllowance :{((Manager)item).PetrolAllowance} ");

using System;

class Program
{
    
    public struct HiringDate
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }

        public HiringDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }

        
        public override string ToString()
        {
            return $"{Day:D2}/{Month:D2}/{Year}";
        }

        
        public int CompareTo(HiringDate other)
        {
            if (Year != other.Year) return Year.CompareTo(other.Year);
            if (Month != other.Month) return Month.CompareTo(other.Month);
            return Day.CompareTo(other.Day);
        }
    }

    
    public class Employee : IComparable<Employee>
    {
        
        public int ID { get; set; }
        public double Salary { get; set; }
        public HiringDate HireDate { get; set; }
        public string Gender { get; set; }

       
        public Employee(int id, double salary, HiringDate hireDate, string gender)
        {
            ID = id;
            Salary = salary;
            HireDate = hireDate;
            Gender = gender;
        }

        public override string ToString()
        {
            return $"ID: {ID}, Salary: {Salary:C}, Hire Date: {HireDate}, Gender: {Gender}";
        }

        
        public int CompareTo(Employee other)
        {
            return HireDate.CompareTo(other.HireDate);
        }
    }

    static void Main(string[] args)
    {
        
        Console.Write("Enter the number of employees: ");
        int size = int.Parse(Console.ReadLine());

        
        Employee[] employees = new Employee[size];

        for (int i = 0; i < size; i++)
        {
            Console.WriteLine($"\nEnter details for employee {i + 1}:");

            
            Console.Write("ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine());

            Console.Write("Hire Day: ");
            int day = int.Parse(Console.ReadLine());

            Console.Write("Hire Month: ");
            int month = int.Parse(Console.ReadLine());

            Console.Write("Hire Year: ");
            int year = int.Parse(Console.ReadLine());

            HiringDate hireDate = new HiringDate(day, month, year);

            Console.Write("Gender (M/F): ");
            string gender = Console.ReadLine();

            employees[i] = new Employee(id, salary, hireDate, gender);
        }

        Array.Sort(employees);

        Console.WriteLine("\nEmployees sorted by hire date:");
        foreach (var employee in employees)
        {
            Console.WriteLine(employee);
        }
    }
}

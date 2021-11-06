namespace Enumerations
{
    public class Employee
    {
        public Employee(EmployeeTypeEnum typeAsEnum, EmployeeType type)
        {
            TypeAsEnum = typeAsEnum;
            Type = type;
        }

        public EmployeeTypeEnum TypeAsEnum { get; set; }
        public EmployeeType Type { get; set; }
        public decimal Bonus { get; internal set; }
    }
}
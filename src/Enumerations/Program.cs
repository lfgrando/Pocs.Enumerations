using System.Collections.Generic;

namespace Enumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee(EmployeeTypeEnum.Manager, EmployeeType.Manager),
                new Employee(EmployeeTypeEnum.Servant, EmployeeType.Servant),
                new Employee(EmployeeTypeEnum.AssistantToTheRegionalManager, EmployeeType.AssistantToTheRegionalManager)
            };

            var employeeProcessor = new EmployeeProcessor();
            foreach (var employee in employees)
            {
                employeeProcessor.ProcessBonus(employee);
                employeeProcessor.ProcessBonusAsEnum(employee);
            }            
        }
    }
}
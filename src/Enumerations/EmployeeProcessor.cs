using System;

namespace Enumerations
{
    public class EmployeeProcessor
    {
        public void ProcessBonus(Employee employee)
        {
            employee.Bonus = employee.Type.BonusSize;
            Console.WriteLine($"{nameof(employee.Type)} {employee.Type.DisplayName} Bonus: {employee.Bonus}");
        }

        public void ProcessBonusAsEnum(Employee employee)
        {
            switch (employee.TypeAsEnum)
            {
                case EmployeeTypeEnum.Manager:
                    employee.Bonus = 1000m;
                    break;
                case EmployeeTypeEnum.Servant:
                    employee.Bonus = 0.01m;
                    break;
                case EmployeeTypeEnum.AssistantToTheRegionalManager:
                    employee.Bonus = 1.0m;
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(employee));
            }

            Console.WriteLine($"{nameof(employee.TypeAsEnum)} {employee.TypeAsEnum} Bonus: {employee.Bonus}");
        }
    }
}
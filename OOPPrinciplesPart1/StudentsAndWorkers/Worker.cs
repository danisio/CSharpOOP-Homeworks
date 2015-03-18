namespace StudentsAndWorkers
{
using System.Text;

    public class Worker : Human
    {
        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay, int workDaysPerWeek)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
            this.WorkDaysPerWeek = workDaysPerWeek;
        }

        public decimal WeekSalary { get; set; }

        public decimal WorkHoursPerDay { get; set; }

        public int WorkDaysPerWeek { get; set; }

        public decimal MoneyPerHour()
        {
            decimal moneyPerHour = this.WeekSalary / this.WorkDaysPerWeek / this.WorkHoursPerDay;

            return moneyPerHour;
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            result.Append(base.ToString());
            result.AppendFormat(" --> {0:C2} per hour", this.MoneyPerHour());

            return result.ToString();
        }
    }
}

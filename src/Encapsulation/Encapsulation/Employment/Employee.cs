using System;

namespace Encapsulation.Employment
{
    public class Employee
    {

        private string _firstName = "Unknown";
        private string _lastName = "Unknown";
        private double _monthlySalary;
        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public double MonthlySalary
        {
            get { return _monthlySalary; }
            set
            {
                if (value >= 0)
                    _monthlySalary = value;
            }
        }

        public Employee(string firstName, string lastName, double monthlySalary)
        {
            FirstName = string.IsNullOrWhiteSpace(firstName) ? "Unknown" : firstName;
            LastName = string.IsNullOrWhiteSpace(lastName) ? "Unknown" : lastName;

            MonthlySalary = monthlySalary < 0 ? 0.0 : monthlySalary;
        }

        public void RaiseSalary(int raisePercentage)
        {
            if (raisePercentage <= 20)
            {
                double raiseAmount = _monthlySalary * (raisePercentage / 100.0);
                _monthlySalary += raiseAmount;
            }
        }

        public double GetYearlySalary()
        {
            return _monthlySalary * 12;
        }
    }
}

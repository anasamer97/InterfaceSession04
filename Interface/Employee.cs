using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	internal class Employee : ICloneable
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Salary { get; set; }

		public Employee()
		{

		}
		public Employee(Employee employee)
		{
			Id = employee.Id;
			Name = employee.Name;
			Salary = employee.Salary;
		}

		public object Clone()
		{
			return new Employee(this);

		}

		public override string ToString()
		{
			return $"ID:{Id}::Name{Name}::Salary:{Salary}";
		}
	}
}

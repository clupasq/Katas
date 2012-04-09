using System;

namespace Algorithm
{
	public class Person
	{
		public string Name { get; set; }
		public DateTime BirthDate { get; set; }

		public bool IsOlderThan(Person person2)
		{
			return BirthDate > person2.BirthDate;
		}
	}
}
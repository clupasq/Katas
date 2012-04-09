using System;

namespace Algorithm
{
	public class Pair
	{
		public Person Person1 { get; set; }
		public Person Person2 { get; set; }
		public TimeSpan AgeDifference { get { return Person2.BirthDate - Person1.BirthDate; } }

		public Pair(Person person1, Person person2)
		{
			if (person1.IsOlderThan(person2))
			{
				Person1 = person2;
				Person2 = person1;
			}
			else
			{
				Person1 = person1;
				Person2 = person2;
			}
		}

		public Pair()
		{
			Person1 = Person2 = null;
		}
	}
}
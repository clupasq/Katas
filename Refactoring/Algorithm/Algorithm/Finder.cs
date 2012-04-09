using System;
using System.Collections.Generic;
using System.Linq;

namespace Algorithm
{
	public class Finder
	{
		private readonly List<Person> _person;

		public Finder(List<Person> person)
		{
			_person = person;
		}

		public Pair FindClosest()
		{
			return Find(pairs => pairs.OrderBy(p => p.AgeDifference).FirstOrDefault());
		}

		public Pair FindFurthest()
		{
			return Find(pairs => pairs.OrderByDescending(p => p.AgeDifference).FirstOrDefault());
		}

		public Pair Find(Func<IEnumerable<Pair>, Pair> pairSelectionLambda)
		{
			var availableDistinctPairs = GetDistinctPairs();

			return pairSelectionLambda(availableDistinctPairs) ?? new Pair();
		}

		private IEnumerable<Pair> GetDistinctPairs()
		{
			for (var i = 0; i < _person.Count - 1; i++)
				for (var j = i + 1; j < _person.Count; j++)
					yield return new Pair(_person[i], _person[j]);
		}
	}
}
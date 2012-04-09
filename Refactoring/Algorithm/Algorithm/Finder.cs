using System.Collections.Generic;

namespace Algorithm
{
    public class Finder
    {
        private readonly List<Thing> _p;

        public Finder(List<Thing> p)
        {
            _p = p;
        }

        public Pair Find(FindType findType)
        {
            var tr = new List<Pair>();

            for(var i = 0; i < _p.Count - 1; i++)
            {
                for(var j = i + 1; j < _p.Count; j++)
                {
                    var r = new Pair();
                    if(_p[i].BirthDate < _p[j].BirthDate)
                    {
                        r.Person1 = _p[i];
                        r.Person2 = _p[j];
                    }
                    else
                    {
                        r.Person1 = _p[j];
                        r.Person2 = _p[i];
                    }
                    r.AgeDifference = r.Person2.BirthDate - r.Person1.BirthDate;
                    tr.Add(r);
                }
            }

            if(tr.Count < 1)
            {
                return new Pair();
            }

            var answer = tr[0];

            foreach(var result in tr)
            {
                switch(findType)
                {
                    case FindType.Closest:
                        if(result.AgeDifference < answer.AgeDifference)
                        {
                            answer = result;
                        }
                        break;

                    case FindType.Furthest:
                        if(result.AgeDifference > answer.AgeDifference)
                        {
                            answer = result;
                        }
                        break;
                }
            }

            return answer;
        }
    }
}
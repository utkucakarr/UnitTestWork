using System;
using System.Collections.Generic;
using System.Linq;

namespace Demo
{
    public class Grouper
    {
        private int _groupCount;

        public Grouper(int groupCount)
        {
            _groupCount = groupCount;
        }

        public List<List<Measurement>> group(List<Measurement> measurements)
        {
            var groups = new List<List<Measurement>>();

            for (int i = 0; i < measurements.Count;)
            {
                var group = measurements.Skip(i).Take(_groupCount).ToList();

                groups.Add(group);

                i += _groupCount;
            }


            return groups;
        }
    }
}
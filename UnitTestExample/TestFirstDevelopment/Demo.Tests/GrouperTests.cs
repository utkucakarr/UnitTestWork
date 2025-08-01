using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Demo.Tests
{
    [TestClass]
    public class GrouperTests
    {
        private List<Measurement> CreateListOfMeasurement(int count)
        {
            var measurement = new List<Measurement>();

            for (int i = 0; i < count; i++)
            {
                measurement.Add(new Measurement
                {
                    Max = 10,
                    Min = 1
                });
            }
            return measurement;
        }

        [TestMethod]
        public void When_list_with_one_element_is_to_be_grouped_by_one_number_of_groups_must_be_one()
        {
            var measurements = new List<Measurement>()
            {
                new Measurement
                {
                    Max = 10,
                    Min = 1
                }
            };

            var grouper = new Grouper(1);
            var groups = grouper.group(measurements);

            Assert.AreEqual(1, groups.Count);
        }

        [TestMethod]
        // Altı elemanlı liste 3'erli gruplanmak istendiğinde eleman sayısı 2 olmalıdır
        public void When_list_with_six_element_is_to_be_grouped_by_two_number_of_groups_must_be_three()
        {
            var measurements = new List<Measurement>()
            {
                new Measurement
                {
                    Max = 10,
                    Min = 1
                },
                new Measurement
                {
                    Max = 10,
                    Min = 1
                },
                new Measurement
                {
                    Max = 10,
                    Min = 1
                },
                new Measurement
                {
                    Max = 10,
                    Min = 1
                },
                new Measurement
                {
                    Max = 10,
                    Min = 1
                },
                new Measurement
                {
                    Max = 10,
                    Min = 1
                }
            };

            var grouper = new Grouper(2);
            var groups = grouper.group(measurements);

            Assert.AreEqual(3, groups.Count);
        }

        public void When_list_with_fifty_element_is_to_be_grouped_by_ten_number_of_groups_must_be_five()
        {
            var measurements = CreateListOfMeasurement(50);

            var grouper = new Grouper(10);
            var groups = grouper.group(measurements);

            Assert.AreEqual(5, groups.Count);
        }
    }
}
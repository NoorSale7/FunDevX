using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    public class Assignment
    {
        public int Find(List<int> numbers) {
            int result = 0;
            foreach (var item in numbers)
            {
                int count = numbers.Count(x => x == item);

                if (count == 1) {
                    result = item;
                    break;
                }
            }

            return result;
        }
    }
}

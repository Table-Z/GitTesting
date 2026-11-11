using System;
using System.Collections.Generic;
using System.Text;

namespace GitTesting
{
    public class Josefine
    {
        private int _age;

        public int Age { get; set; }

        public string Name { get; set; }

        public Josefine(int age)
        {
            Age = age;
        }

        public void HaveBirtday()
        {
            Age++;
        }

        public string Birthday()
        {
            return $"Happy Birthday";
        }
    }
}

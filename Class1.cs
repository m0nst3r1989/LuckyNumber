using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumbers
{
    internal class Month
    {
        public Month()
        {
            BirthMonth = 0;
        }
        public int BirthMonth { get; set; }
    }
    internal class Color
    {
        public Color()
        {
            FavoriteColor = 0;
        }
        public int FavoriteColor { get; set; }
    }
    public class Day
    {
        public Day()
        {
            BirthDay = 0;
        }
        public int BirthDay { get; set; }
    }
    internal class Year
    {
        // constructor
        public Year()
        {
            BirthYear = 0;
        }

        public int BirthYear { get; set; }
    }
}

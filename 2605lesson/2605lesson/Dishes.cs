using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2605lesson
{
    [Flags]
    public enum Dishes
    {
        WONT = 0,
        FIRST = 1,
        MAIN = 2,
        DESSERT = 4,
        SURPRISE = 8
    }
}

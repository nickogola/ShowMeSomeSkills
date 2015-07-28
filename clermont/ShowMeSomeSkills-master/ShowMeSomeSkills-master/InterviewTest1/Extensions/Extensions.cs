using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewTest.Model
{
    public static class Extensions
    {
        public static string Format(this decimal value, params object[] args)
        {
            return String.Format(value.ToString(), args);
        }
    }
}

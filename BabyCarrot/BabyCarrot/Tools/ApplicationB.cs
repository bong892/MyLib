using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BabyCarrot.Tools
{
    public static class ApplicationB
    {
        public static string Root
        {
            get
            {
                return AppDomain.CurrentDomain.BaseDirectory;               
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject_IT111
{
    class Validation
    {
        public static bool ContainsValue(string text)
        {
            // return false if text boxes do not contain text
            if (string.IsNullOrWhiteSpace(text) ||
                string.IsNullOrEmpty(text))
            {
                return false;
            }
            ;

            // return true if text boxes contain text
            return true;
        }
    }
}

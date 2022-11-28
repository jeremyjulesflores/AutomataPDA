using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataPDA.Checker
{
    public interface PDAChecker
    {
        /// <summary>
        /// Checks if given string input is accepted in the PDA
        /// </summary>
        /// <param name="input">String input</param>
        /// <returns>boolean true if accepted and false if not</returns>
        public bool check(string input);
    }
}

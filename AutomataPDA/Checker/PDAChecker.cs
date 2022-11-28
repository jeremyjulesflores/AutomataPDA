using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomataPDA.Checker
{
    public interface PDAChecker
    {
        public bool check(string input);
    }
}

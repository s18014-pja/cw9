using System;
using System.Collections.Generic;
using System.Text;

namespace cw9
{
    public class Dept
    {
        public int Deptno { get; set; }
        public string Dname { get; set; }
        public string Loc { get; set; }
        
        public override string ToString()
        {
            return Dname + " (" + Deptno + ")";
        }
    }
}
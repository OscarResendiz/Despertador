using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DespertadorNET
{
    class CCancion
    {
        public string Path;
        public override string ToString()
        {
            string s="";
            int i, n,pos=0;
            n = Path.Length;
            for (i = n-1; i >=0; i--)
            {
                if (Path[i] == '\\')
                {
                    pos = i;
                    break;
                }
            }
            s = Path.Substring(pos + 1);
            return s;
        }
    }
}

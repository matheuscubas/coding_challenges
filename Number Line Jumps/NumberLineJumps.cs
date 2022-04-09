using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{
    /*
     * Complete the 'kangaroo' function below.
     *
     * The function is expected to return a STRING.
     * The function accepts following parameters:
     *  1. INTEGER x1
     *  2. INTEGER v1
     *  3. INTEGER x2
     *  4. INTEGER v2
     */

    public static string kangaroo(int x1, int v1, int x2, int v2)
    {
      while(x1 != v1)
      {
        if(x1 > x2 && v1 > v2) return "NO";
        if(x2 > x1 && v2 > v1) return "NO";
        if(x1 > x2 && v1 > v2) return "NO";
        if(x1 > x2 && v1 > v2) return "NO";
        if(x1 != x2 && v1 == v2) return "NO";
        
        x1 += v1;
        x2 += v2;
        
        if(x1 == x2) return "YES";
      }
      return "YES";
    }

}

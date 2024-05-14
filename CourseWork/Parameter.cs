using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;
public class Parameter
{
    public List<Node> Binds;
    
    public Parameter(List<Node> binds)
    {
        Binds = binds;
    }
}

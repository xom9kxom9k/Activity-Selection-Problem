using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;

public class Manager
{
    private Parameter? _parameter;
    private Implement? _realization;
    public void Step()
    {
        _realization = new();
        
        Storage storage = new();
        storage.AddBid(_realization);
    }
}

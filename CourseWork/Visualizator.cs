using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;

public class Visualizator
{
    private State? _status;
    public void SetStatus(State status)
    {
        _status = status;
    }
    public void Draw()
    {
        if (_status != null) 
        {
            return;
        }

        //отрисовка задачи
    }
}

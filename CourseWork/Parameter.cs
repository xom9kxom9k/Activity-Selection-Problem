using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;
/// <summary>
/// Класс - параметр
/// </summary>
public class Parameter
{
    /// <summary>
    /// Список заявок
    /// </summary>
    public List<Node> Binds;
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="binds"></param>
    public Parameter(List<Node> binds)
    {
        Binds = binds;
    }
}

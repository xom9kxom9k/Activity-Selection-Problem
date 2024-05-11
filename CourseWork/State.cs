using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;

public class State
{
    private Implement? _realization;
    /// <summary>
    /// Количество зявок
    /// </summary>
    public int CountBids { get; private set; }
    /// <summary>
    /// Время всех заявок
    /// </summary>
    public int Time {  get; private set; }
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="realization"></param>
    /// <param name="countBids"></param>
    /// <param name="time"></param>
    private State(Implement? realization, int countBids, int time)
    {
        _realization = realization;
        CountBids = countBids;
        Time = time;
    }
}

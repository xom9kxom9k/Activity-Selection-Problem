using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;
/// <summary>
/// Класс - состояние
/// </summary>
public class State
{
    public List<Node> Binds;
    public List<Node> SelectedBinds;

    public int Result => SelectedBinds.Count;
    public bool IsCompleted { get; private set; }

    /// <summary>
    /// Передача данных через конструктор
    /// </summary>
    /// <param name="binds"></param>
    /// <param name="selected"></param>
    /// <param name="isCompleted"></param>
    public State(List<Node> binds, List<Node> selected, bool isCompleted)
    {
        Binds = binds;
        SelectedBinds = selected;
        IsCompleted = isCompleted;
    }
}

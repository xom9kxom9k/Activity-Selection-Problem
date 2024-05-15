using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;
/// <summary>
/// Класс - реализатор
/// </summary>
public class Implement
{
    public bool IsStart;
    public bool IsCompleted;

    public List<Node> Binds;
    public List<Node> SelectedBinds;

    public int lastNode;


    /// <summary>
    /// Конструтор 
    /// </summary>
    public Implement(List<Node> binds)
    {
        Binds = binds;
        SelectedBinds = new List<Node>();
        IsStart = true;
        IsCompleted = false;
        lastNode = 0;
    }

    /// <summary>
    /// Сортировка для реализации задачи
    /// </summary>
    /// <returns></returns>
    public bool Step()
    {
        // 1 шаг
        if (IsStart)
        {
            Binds.Sort((a, b) =>
                a.StartBid.CompareTo(b.StartBid) != 0
                    ? a.StartBid.CompareTo(b.StartBid)
                    : a.EndBid.CompareTo(b.EndBid));
            SelectedBinds.Add(Binds[0]);
            lastNode = 0;
            IsStart = false;
            return true;
        }
        // остальные шаги
        for (int i = lastNode + 1; i < Binds.Count; i++)
        {
            if (Binds[i].StartBid >= SelectedBinds.Last().EndBid)
            {
                SelectedBinds.Add(Binds[i]);
                lastNode = i;
                return true;
            }
        }
        // последний шаг
        IsCompleted = true;
        return false;
    }

    public State GetState()
    {
        return new State(new List<Node>(Binds), new List<Node>(SelectedBinds), IsCompleted);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProtoBuf;
namespace CourseWork;
/// <summary>
/// Класс - состояние
/// </summary>
[ProtoContract]
[Serializable]
public class State
{

    [ProtoMember(1)] public List<Node> Binds = new();
    [ProtoMember(2)] public List<Node> SelectedBinds = new();

    public int Result => SelectedBinds.Count;
    [ProtoMember(3)] public bool IsCompleted { get; private set; } = false;
    public State()
    {
        Binds = new List<Node>();
        SelectedBinds = new List<Node>();
        IsCompleted = false;
    }
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

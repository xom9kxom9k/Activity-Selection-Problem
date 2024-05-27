using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;
[ProtoContract]
[Serializable]
public class StateList
{
    [ProtoMember(1)]
    public List<State> States;

    public StateList()
    {
        States = new List<State>();
    }
    public StateList(List<State> states) : this()
    {
        States = states;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;

public class Manager
{
    public Implement Implement;
    public Manager(Parameter parameter)
    {
        Implement = new Implement(parameter.Binds);
    }

    public Storage StartAlgo()
    {
        Storage storage = new Storage();
        State state = Implement.GetState();
        storage.AddState(state);
        do
        {
            Implement.Step();
            state = Implement.GetState();
            storage.AddState(state);
        } while (!Implement.IsCompleted);
        return storage;
    }
}

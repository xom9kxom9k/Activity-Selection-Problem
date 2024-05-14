using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;

public class Manager
{
    /// <summary>
    /// Объект класса реализатора
    /// </summary>
    public Implement Implement;
    /// <summary>
    /// Конструктор
    /// </summary>
    /// <param name="parameter"></param>
    public Manager(Parameter parameter)
    {
        Implement = new Implement(parameter.Binds);
    }
    /// <summary>
    /// Запись в объект-хранилище
    /// </summary>
    /// <returns></returns>
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

using ProtoBuf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;
/// <summary>
/// Класс - хранилище
/// </summary>
public class Storage
{
    private List<State> states;

    public int StatesCount => states.Count;
    public bool IsCompleted => CurrentStateIndex == states.Count - 1;
    public int CurrentStateIndex { get; private set; }

    public Storage()
    {
        states = new List<State>();
        CurrentStateIndex = 0;
    }
    /// <summary>
    /// Шаг вперед
    /// </summary>
    /// <returns></returns>
    public bool NextState()
    {
        CurrentStateIndex += 1;
        if (CurrentStateIndex >= StatesCount)
        {
            CurrentStateIndex = StatesCount - 1;
            return false;
        }

        return true;
    }
    /// <summary>
    /// Шаг назад
    /// </summary>
    /// <returns></returns>
    public bool PrevState()
    {
        CurrentStateIndex -= 1;
        if (CurrentStateIndex < 0)
        {
            CurrentStateIndex = 0;
            return false;
        }

        return true;
    }

    public State? GetCurrentState()
    {
        return GetState(CurrentStateIndex);
    }

    /// <summary>
    /// Добавление новой записи
    /// </summary>
    /// <param name="state"></param>
    /// <returns></returns>
    public bool AddState(State state)
    {
        if (state.IsCompleted)
        {
            return false;
        }

        states.Add(state);

        return true;
    }

    public State? GetState(int index)
    {
        if (index >= 0 && index < states.Count)
        {
            return states[index];
        }

        return null;
    }

    public State? GetFirstState()
    {
        if (states.Count == 0)
        {
            return states[0];
        }

        return null;
    }

    public State? GetLastState()
    {
        if (states.Count == 0)
        {
            return states[StatesCount - 1];
        }

        return null;
    }
    public bool SaveState(string filename)
    {
        
        try 
        {
            using var file = File.Create(filename);
            Serializer.Serialize(file, new StateList(states));
            return true;
        }
        catch (Exception)
        {
            return false;
        }
    }

    public bool LoadState(string filename)
    {
        try { 
            StateList tmpStates;
            using (var file = File.OpenRead(filename))
            {
                tmpStates = Serializer.Deserialize<StateList>(file);
                states = tmpStates.States;
                CurrentStateIndex = 0;
                return true;
            }
        }
        catch (Exception) 
        {
            return false;
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;

public class Visualizator
{
    private State? _status;

    public void Draw(Graphics g, State state, Size size)
    {
        if (_status != null)
        {
            return;
        }
        List<Node> binds = new List<Node>(state.SelectedBinds);
        
        
        Pen penLine = new(Color.Black, 5);
        Pen penBid = new(Color.Red, 2);
        Pen penSelectedBid = new(Color.Green, 3);

        g.DrawLine(penLine, 20, 20, size.Width - 20, 20);

        for (int i = 0; i < state.Binds.Count; i++)
        {
            g.DrawLine(binds.Contains(state.Binds[i])? penSelectedBid: penBid,
                20 + (size.Width - 40) / 100 * state.Binds[i].StartBid,
                25 + i * 15,
                20 + (size.Width - 40) / 100 * state.Binds[i].EndBid,
                25 + i * 15);
            if (binds.Contains(state.Binds[i]))
            {
                binds.Remove(state.Binds[i]);
            }
        }
    }
}
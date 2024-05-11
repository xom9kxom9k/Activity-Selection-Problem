using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseWork;

public class Storage
{
    private List<Implement>? _collection;
    public Storage()
    {
        _collection = new();
    }
    /// <summary>
    /// Метод добавления новой записи
    /// </summary>
    /// <param name="bid"></param>
    public void AddBid(Implement bid)
    {
        _collection?.Add(bid);
    }
}

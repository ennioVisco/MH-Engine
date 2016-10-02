using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH_Engine.Models.Interfaces.Board
{
    /// <summary>                                                             
    /// A basic definition for a thread of the in-game board (i.e. forum).
    /// It is contained in a <see cref="IBoardCategory"/>.
    /// It contains a set of <see cref="IBoardPost"/>
    /// and is owned by an <see cref="IUser"/>.
    /// </summary>
    interface IBoardThread
    {
        string Name { get; set; }
        IBoardCategory Category { get; set; }
        IUser Author { get; set; }
        DateTime CreationDate { get; set; }
        IBoardPost LastPost { get; set; }
        bool Important { get; set; }
    }
}

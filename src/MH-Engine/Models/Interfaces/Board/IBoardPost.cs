using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH_Engine.Models.Interfaces.Board
{
    /// <summary>                                                             
    /// A basic definition for a post of the in-game board (i.e. forum).
    /// It is contained in a <see cref="IBoardThread"/>.
    /// </summary>
    interface IBoardPost
    {
        IBoardThread Thread { get; set; }
        IUser Author { get; set; }
        DateTime CreationDate { get; set; }
    }
}

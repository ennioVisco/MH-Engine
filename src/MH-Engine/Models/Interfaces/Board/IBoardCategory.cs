using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH_Engine.Models.Interfaces.Board
{
    /// <summary>                                                             
    /// A basic definition for a category of the in-game board (i.e. forum).
    /// It contains a set of <see cref="IBoardThread"/>s.
    /// </summary>
    interface IBoardCategory
    {
        string Name { get; set; }
        Purpose Purpose { get; set; }
    }
}

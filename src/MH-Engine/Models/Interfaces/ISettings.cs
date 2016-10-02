using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH_Engine.Models.Interfaces
{
    /// <summary>                                                             
    /// A set of properties that the <see cref="IUser"/>. manages, in order to
    /// personalize the playing environment.
    /// </summary>
    interface ISettings
    {
        int SoundLevel { get; set; }
        string OwlTrack { get; set; }
    }
}

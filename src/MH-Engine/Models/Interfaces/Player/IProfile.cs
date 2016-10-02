using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH_Engine.Models.Interfaces.Player
{
    /// <summary>                                                             
    /// These are the set of properties on which is funded the history
    /// and behaviour of the in-game <see cref="ICharacter"/>.
    /// </summary>
    interface IProfile
    {
        string AvatarUrl { get; set; }
        string MusicUrl { get; set; }
        string BackgroundImageUrl { get; set; }
        string BackgroundDescriptionText { get; set; }
        string CompanionAvatarUrl { get; set; }
        string CompanionDescriptionText { get; set; }
    }
}

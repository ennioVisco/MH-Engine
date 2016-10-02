using System.Collections.Generic;

namespace MH_Engine.Models.Interfaces.Chat
{
    /// <summary>                                                             
    /// The basic definition of a chat room, which is a place where users can
    /// chat with other users by playing a role game.
    /// It is always reachable by at least one <see cref="IChatCategory"/>.
    /// </summary>
    public interface IChatRoom
    {
        IEnumerable<ApplicationUser> Users { get; set; }
        string RoomName { get; set; }
    }
}

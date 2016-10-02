using System.Collections.Generic;

namespace MH_Engine.Models.Interfaces.Chat
{
    /// <summary>                                                             
    /// The basic definition of a chat category, which is a room without that 
    /// has the role of a router to other chat categories or 
    /// <see cref="IChatRoom"/>s.
    /// </summary>
    interface IChatCategory
    {
        ICollection<string> ImageUrls { get; set; }
        IDictionary<Coordinates, string> Description { get; set; }

    }
}

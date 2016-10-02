using Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MH_Engine.Models.Interfaces
{
    /// <summary>                                                             
    /// The basic definition of a user, with basic properties needed from 
    /// an authentication perspective.
    /// </summary>
    interface IUser
    {
        string Email { get; set; }
        string Password { get; set; }
        DateTime SubscriptionDate { get; set; }
        DateTime LastVisit { get; set; }
        bool FirstTime { get; set; }
        bool Online { get; set; }


        //Role Role { get; set; }
    }
}

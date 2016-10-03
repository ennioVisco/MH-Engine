using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using MH_Engine.Models;
using MH_Engine.Services;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;

namespace MH_Engine.Controllers
{
    [Authorize]
    public class ChatController : Controller
    {
        private readonly SignInManager<ApplicationUser> _signInManager;
        private readonly ChatManager _chatManager;
        private readonly ILogger _logger;

        public ChatController(ILoggerFactory loggerFactory,
                              SignInManager<ApplicationUser> signInManager,
                              ChatManager chatManager)
        {
            _signInManager = signInManager;
            _chatManager = chatManager;
            _logger = loggerFactory.CreateLogger<ChatController>();
        }

        // POST: /Chat/SendMessage/{roomId}
        [HttpPost("{roomId}")]
        public async Task<IActionResult> SendMessage(int roomId, string message)
        {
            if (_signInManager.IsSignedIn(User))
            {
                //if authorized
                    //storeMessage
                    return Ok();
            }

            return BadRequest();
            
        }

        // GET: /Chat/ShowMessage
        public async Task<IActionResult> ShowMessages(int roomId)
        {
            return Ok();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using capstone.Data;
using capstone.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace capstone.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JusticeLeagueMemberController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public JusticeLeagueMemberController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IEnumerable<JusticeLeagueMember> Get()
        {
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;

            if (userId == null) {
                return _context.JusticeLeagueMembers;
            }
            return _context.JusticeLeagueMembers.Where(m => m.UserId == userId);
        }

        [HttpPost]
        public JusticeLeagueMember Post([FromBody]JusticeLeagueMember member)
        {
            member.UserId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            _context.Add(member);
            _context.SaveChanges();

            return member;
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using whatsappProject.Models;
/*
namespace whatsappProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class invitationsController : ControllerBase
    {
        private readonly IUserService _context;

        public invitationsController(IUserService context)
        {
            _context = context;
        }

        // GET: api/invitations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Invitation>>> GetInvitation()
        {
          if (_context.Invitation == null)
          {
              return NotFound();
          }
            return await _context.Invitation.ToListAsync();
        }

        // GET: api/invitations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Invitation>> GetInvitation(int id)
        {
          if (_context.Invitation == null)
          {
              return NotFound();
          }
            var invitation = await _context.Invitation.FindAsync(id);

            if (invitation == null)
            {
                return NotFound();
            }

            return invitation;
        }

        // PUT: api/invitations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInvitation(int id, Invitation invitation)
        {
            if (id != invitation.id)
            {
                return BadRequest();
            }

            _context.Entry(invitation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InvitationExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/invitations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Invitation>> PostInvitation(Invitation invitation)
        {
          if (_context.Invitation == null)
          {
              return Problem("Entity set 'whatsappProjectContext.Invitation'  is null.");
          }
            _context.Invitation.Add(invitation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetInvitation", new { id = invitation.id }, invitation);
        }

        // DELETE: api/invitations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInvitation(int id)
        {
            if (_context.Invitation == null)
            {
                return NotFound();
            }
            var invitation = await _context.Invitation.FindAsync(id);
            if (invitation == null)
            {
                return NotFound();
            }

            _context.Invitation.Remove(invitation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool InvitationExists(int id)
        {
            return (_context.Invitation?.Any(e => e.id == id)).GetValueOrDefault();
        }
    }
}
*/
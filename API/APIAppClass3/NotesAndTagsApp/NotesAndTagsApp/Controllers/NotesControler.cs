using Microsoft.AspNetCore.Mvc;
using NotesAndTagsApp.Models;

namespace NotesAndTagsApp.Controllers
{
	public class NotesControler : Controller
	{
		[Route("api/[Controller]")]
		public IActionResult Get()
		{
			try
			{
				var notesDb = StaticDb.Notes;
				var NotesDto = notesDb.Select(note => new NoteDto
				{
					Priority = note.Priority,
					Text = note.Text,
					User = $"{note.Users.FirstName}{note.Users.LastName}",
					Tags = note.Tags.Select(tag => tag.Name).ToList()
				}).ToList();
				return Ok(NotesDto);
			}
			catch (Exception)
			{
				return StatusCode(StatusCodes.Status500InternalServerError,"Error");
			}
		}
		[HttpGet("{id}")]
		public IActionResult GeetNoteById([FromRoute]int id)
		{
			try
			{
				if (id < 0)
				{
					return BadRequest("Error");
				};
				var noteDb =StaticDb.Notes.FirstOrDefault(note => note.Id == id);
				if (noteDb == null)
				{

					return BadRequest($"Error {id}");
				}
				_ = new NoteDto
				{
					Priority = noteDb.Priority,
					Text = noteDb.Text,
					User = $"{noteDb.Users.FirstName}{noteDb.Users.LastName}",
					Tags = noteDb.Tags.Select(tag => tag.Name).ToList()
				};
				return Ok(NoteDto);
			}
			catch  
			{
				return StatusCode(StatusCodes.Status500InternalServerError, "Error");

			}
		}
	}
}

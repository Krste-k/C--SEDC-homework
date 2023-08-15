using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NotesAndTagsApp.DTOs;
using NotesAndTagsApp.Models;
using System.Security.Cryptography.X509Certificates;

namespace NotesAndTagsApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotesController : ControllerBase
    {
        [HttpGet] //https://localhost:7056/api/notes
        public IActionResult Get()
        {
            try
            {
                var notesDb = StaticDb.Notes;

                var notesDTO = notesDb.Select(note => new NoteDto
                {
                    Priority = note.Priority,
                    Text = note.Text,
                    User = $"{note.User.FirstName} {note.User.LastName}",
                    Tags = note.Tags.Select(tag => tag.Name).ToList()
                }).ToList();

                return Ok(notesDTO);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred, please contact admin.");
            }
        }

        [HttpGet("{id}")] //https://localhost:7056/api/notes/1
        public IActionResult GetNoteById([FromRoute] int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("The id can not be negative!");
                }

                var noteDb = StaticDb.Notes.FirstOrDefault(note => note.Id == id);

                if (noteDb is null)
                {
                    return NotFound($"Note with id: {id} does not exist");
                }

                var noteDTO = new NoteDto
                {
                    Priority = noteDb.Priority,
                    Text = noteDb.Text,
                    User = $"{noteDb.User.FirstName} {noteDb.User.LastName}",
                    Tags = noteDb.Tags.Select(tag => tag.Name).ToList()
                };

                return Ok(noteDTO);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred, please contact admin.");
            }
        }

        [HttpGet("findById")] //https://localhost:7056/api/notes/GetNoteFromId?id=1
        public IActionResult GetNoteFromId([FromQuery] int id)
        {
            try
            {
                if (id <= 0)
                {
                    return BadRequest("The id can not be negative!");
                }

                var noteDb = StaticDb.Notes.FirstOrDefault(note => note.Id == id);

                if (noteDb is null)
                {
                    return NotFound($"Note with id: {id} does not exist");
                }

                var noteDTO = new NoteDto
                {
                    Priority = noteDb.Priority,
                    Text = noteDb.Text,
                    User = $"{noteDb.User.FirstName} {noteDb.User.LastName}",
                    Tags = noteDb.Tags.Select(tag => tag.Name).ToList()
                };

                return Ok(noteDTO);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "An error occurred, please contact admin.");
            }
        }

        [HttpGet("User /{userId}")] //https://localhost:7056/api/notes/user/1
		public IActionResult GetNoteByUser([FromRoute] int userId)
        {
            var userNotes = StaticDb.Notes.Where(Note => Note.User.Id == userId).Select(note => new NoteDto
            {
                Priority = note.Priority, 
                Text = note.Text,
                User = $"{note.User.FirstName} {note.User.LastName}",
                Tags = note.Tags.Select(note => note.Name).ToList()

            });
            return Ok(userNotes);
         
        }

		[HttpPost] //https://localhost:7056/api/notes
		public IActionResult AddNote([FromBody] AddNoteDto addNoteDto)
        {
            var userDb = StaticDb.Users.FirstOrDefault(user => user.Id == addNoteDto.UserId);
            if(User is null)
            {
                return NotFound($"User with id:{addNoteDto.UserId} was not found!");
            }

            var tags = new List<Tag>();
            foreach (int tagId in addNoteDto.TagIds)
            {
                var tag = StaticDb.Tags.FirstOrDefault(tag =>tag.Id == tagId);
                if (tag == null)
                {
                    return NotFound($"Tags with id {tagId} was not found");
                }

                tags.Add(tag);
            }

            var noteDb = new Note
            {
                Id = ++StaticDb.NoteId,
                Text = addNoteDto.Text,
                Priority = addNoteDto.Priority,
                UserId = userDb.Id,
                User = userDb,
                Tags = tags

                };

            StaticDb.Notes.Add(noteDb);
            return StatusCode(StatusCodes.Status201Created,"Note Created!s");
        }

		[HttpDelete("{id}")] //https://localhost:7056/api/notes/1
		public IActionResult DeliteById([FromRoute] int id) 
        {
            try
            {

                if (id <= 0)
                {
                    return BadRequest( $"The id can not be negative");
                }
                var noteDb = StaticDb.Notes.FirstOrDefault(note => note.Id == id);
                if (noteDb == null)
                { 
                    return NotFound($"Note with Id: {id} not found");
                }
                StaticDb.Notes.Remove(noteDb);
                return Ok(noteDb);
            }
            catch(Exception ex) { }
            {

            }
        return BadRequest();
        }

        [HttpPut]
        public IActionResult UpdateNote([FromBody] UpdateNoteDto updateNoteDto)
        {
            var noteDb = StaticDb.Notes.FirstOrDefault(note => note.Id == updateNoteDto.Id);
			var userDb = StaticDb.Notes.FirstOrDefault(note => note.Id == updateNoteDto.UserId);

            var newTags = new List<Tag>();
            foreach(int tagId in updateNoteDto.TagsIds)
            {
                var tag  = StaticDb.Tags.FirstOrDefault(tag => tag.Id == tagId);
                if(tag is null)
                {
                    return NotFound($"Tags with Id:{tagId} was not found");
                }
                newTags.Add(tag);
            }
			noteDb.Text = updateNoteDto.Text;
            noteDb.Priority = updateNoteDto.Priority;
			noteDb.Tags = newTags;



			return StatusCode(StatusCodes.Status204NoContent, "NoteUpdated");
		}
    }
}

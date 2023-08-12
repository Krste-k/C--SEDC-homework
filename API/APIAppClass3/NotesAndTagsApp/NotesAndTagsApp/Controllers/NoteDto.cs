using NotesAndTagsApp.Models.Enums;

namespace NotesAndTagsApp.Controllers
{
	internal class NoteDto
	{
		public string Text { get; set; }
		public PriorityEnum Priority { get; set; }

		public string User { get; set; }
		public TagsAttribute Tags { get; set; }
	}
}
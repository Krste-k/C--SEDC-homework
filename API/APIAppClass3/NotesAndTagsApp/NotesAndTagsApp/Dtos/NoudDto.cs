using NotesAndTagsApp.Models;

namespace NotesAndTagsApp.Dtos
{
	public class NoudDto
	{
		public string Text { get; set; }	
		public PropertyEnum Property { get; set; }
		public List<Tag> Tags { get; set; }
	}
}

﻿using NotesAndTagsApp.Models.Enums;

namespace NotesAndTagsApp.DTOs
{
	public class UpdateNoteDto
	{
		public int Id { get; set; }
		public string Text { get; set; }	
		public Priority Priority { get; set; }
		public List <int> TagsIds { get; set; }

		public int UserId { get; set; }
	}
}

﻿using NotesAndTagsApp.Models.Enums;
using NotesAndTagsApp.Models;

namespace NotesAndTagsApp
{
    public static class StaticDb
    {

        public static List<User> Users = new List<User>()
        {
            new User
            {
                FirstName = "Krste",
                LastName = "Krstevski",
                UserName = "Kco",
                Password = "1234"
            }
            ,
			   new User
			{
				FirstName = "Marko",
				LastName = "Krstevski",
				UserName = "Mako",
				Password = "10000"
			}
		};

        public static List<Tag> Tags = new List<Tag>
        {
             new Tag(){ Id = 1, Name = "HomeWork", Color = "cyan"},
             new Tag(){ Id = 2, Name = "SEDC", Color = "blue"},
             new Tag(){ Id = 3,Name = "Healthy", Color = "orange"},
             new Tag(){ Id = 4, Name = "water", Color = "blue"},
             new Tag(){ Id = 5, Name = "exercise", Color = "blue"},
             new Tag(){ Id = 6, Name = "Fit", Color = "yellow"}

        };


        public static List<Note> Notes = new List<Note>()
        {
            new Note() { 
                Id = 1, 
                Text = "Do Homework", 
                Priority = PriorityEnum.Low, 
                Tags = new List<Tag>()
                {
                    Tags[0],
                    Tags[1]
,
                },
                Users = Users[0]
            },
            new Note() { 
                Id = 2, 
                Text = "Drink more Water", 
                Priority = PriorityEnum.High, 
                Tags = new List<Tag>()
                {
					Tags[2],
					Tags[3]
				},
				Users = Users[0]

			},
            new Note(){ 
                Id = 3, 
                Text = "Go to the gym", 
                Priority = PriorityEnum.Medium, 
                Tags = new List<Tag>()
                {
					Tags[4],
					Tags[5]
				},
				Users = Users[1]

			}
		};
    }
}

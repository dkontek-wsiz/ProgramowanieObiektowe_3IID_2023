﻿using Lab2.Interfaces;

namespace Lab2.Lab6
{
    public class Book : IEntity<long>, ICreationTime
    {
        public long Id { get; set; }
        public DateTime CreationTime { get; set; } = DateTime.Now;
        public string Title { get; set; }
        public string Author { get; set; }
        public DateTime PublishDate { get; set; }
    }
}

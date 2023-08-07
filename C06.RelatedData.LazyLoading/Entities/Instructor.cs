﻿namespace EF015.QueryData.Entities
{
    public class Instructor : Entity
    {
        public string? FName { get; set; }
        public string? LName { get; set; }

        public int OfficeId { get; set; }
        public virtual Office? Office { get; set; }

        public virtual ICollection<Section> Sections { get; set; } = new List<Section>();
    }
}

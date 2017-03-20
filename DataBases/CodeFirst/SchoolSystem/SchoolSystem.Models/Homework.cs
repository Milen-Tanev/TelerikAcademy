namespace Models
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Homework
    {
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(500)]
        public string Content { get; set; }
        public DateTime? TimeSent { get; set; }

        public int StudentNumber { get; set; }
        public virtual Student Student { get; set; }

        public int CourseNumber { get; set; }
        public virtual Course Course { get; set; }
    }
}

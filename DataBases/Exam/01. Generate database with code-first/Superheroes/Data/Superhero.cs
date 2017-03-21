namespace Superheroes.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public class Superhero
    {
        private ICollection<Fraction> fractions;
        private ICollection<Power> powers;

        public Superhero()
        {
            this.fractions = new HashSet<Fraction>();
            this.powers = new HashSet<Power>();
        }
        public int Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(60)]
        public string Name { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        [Index(IsUnique =true)]
        public string SecretIdentity { get; set; }

        public int CityId { get; set; }
        [Required]
        public virtual City City { get; set; }

        //enums cannot be null - no Required needed
        public Alignment HeroAlignment { get; set; }

        [Required]
        public string Story { get; set; }

        public virtual ICollection<Fraction> Fractions
        {
            get { return this.fractions; }
            set { this.fractions = value; }
        }

        public virtual ICollection<Power> Powers
        {
            get { return this.powers; }
            set { this.powers = value; }
        }
    }
}

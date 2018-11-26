namespace MVCFriends
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Friend
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Surname { get; set; }

        [Required]
        [StringLength(30)]
        public string FirstName { get; set; }

        [StringLength(30)]
        public string TelNo { get; set; }

        [StringLength(30)]
        public string Email { get; set; }

        [Column("Country of Origin")]
        [StringLength(30)]
        public string Country_of_Origin { get; set; }
    }
}

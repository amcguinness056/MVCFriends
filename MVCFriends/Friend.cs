namespace MVCFriends
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Net.Http;

    public partial class Friend
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Surname Required")]
        [StringLength(30)]
        public string Surname { get; set; }

        [Required(ErrorMessage ="Firstname Required")]
        [StringLength(30)]
        public string FirstName { get; set; }
        
        [RegularExpression("^[0-9]{11}", ErrorMessage ="Please enter a valid phone number")]
        public string TelNo { get; set; }

        [StringLength(30)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Column("Country of Origin")]
        [StringLength(30)]
        public string Country_of_Origin { get; set; }
    }
}

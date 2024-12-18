﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] //Autoincrement id
        public int UserId { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(20, ErrorMessage = "Name cannot exceed 20 characters")]
        public string Name { get; set; }

        [StringLength(50, ErrorMessage = "Last name cannot exceed 50 characters")]
        [MinLength(1, ErrorMessage = "Name cannot be an empty string")]
        public string? LastName { get; set; }
        [MinLength(1, ErrorMessage = "Name cannot be an empty string")]

        public string? Category { get; set; }

        [Range(100000000, 99999999999, ErrorMessage = "Phone number must be between 9 and 11 digits.")]
        public int? PhoneNumber { get; set; }
        [MinLength(1, ErrorMessage = "Name cannot be an empty string")]


        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string? Email { get; set; }



    }
}

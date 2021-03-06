﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Reading_Corner.Entities
{
    public class ReadingRecord
    {
        public int ID { get; set; }

        public int StudentID { get; set; }
        
        public Student Student { get; set; }
        
        [Display(Name = "Log Date")]

        [DataType(DataType.Date)]

        public DateTime LogDate { get; set; }

        [Display(Name = "Book Title")]
        public string Name { get; set; }
        public int Minutes { get; set; }
        public int Pages { get; set; }
    }
}

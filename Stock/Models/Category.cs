﻿using System.ComponentModel.DataAnnotations;

namespace Stock.Models
{

    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Walor { get; set; }
        public string Kurs { get; set; }
        public float KursFloat { get; set; }
        public float Zmiana { get; set; }


    }
}

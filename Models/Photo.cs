﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;

namespace PhotoMap.Models
{
    public partial class Photo
    {
        public Guid PhotoRowguid { get; set; }
        public Guid? UserRowguid { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string PhotoPath { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? CreatedAt { get; set; }

        public virtual User UserRowgu { get; set; }
    }
}
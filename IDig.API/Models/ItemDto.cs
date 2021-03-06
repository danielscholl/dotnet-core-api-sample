﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemInfo.API.Models
{
    public class ItemDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Active { get; set; }
        public int NumberofChildren
        {
            get
            {
                return Children.Count;
            }
        }
        public ICollection<ItemDto> Children { get; set; } = new List<ItemDto>();
    }
}

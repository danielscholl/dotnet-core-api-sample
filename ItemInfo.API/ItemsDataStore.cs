using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ItemInfo.API.Models;

namespace ItemInfo.API
{ 
    public class ItemsDataStore
    {

        public static ItemsDataStore Current { get; } = new ItemsDataStore();

        public List<ItemDto> Items { get; set; }

        public ItemsDataStore()
        {
            Items = new List<ItemDto>()
            {
                new ItemDto()
                {
                    Id = 1,
                    Name = "Item 1",
                    Description = "Test Case 1",
                    Active = false,
                    Children = new List<ItemDto>()
                    {
                        new ItemDto
                        {
                            Id = 1,
                            Name = "Child 1",
                            Description = "Test Case 1",
                            Active = true
                        },
                        new ItemDto
                        {
                            Id = 2,
                            Name = "Child 2",
                            Description = "Test Case 2",
                            Active = true
                        }
                    }
                },

                new ItemDto()
                {
                    Id = 2,
                    Name = "Item 2",
                    Description = "Test Case 4",
                    Active = true
                },

                new ItemDto()
                {
                    Id = 3,
                    Name = "Item 3",
                    Description = "Test Case 3",
                    Active = false
                }
            };

        }
    }
}

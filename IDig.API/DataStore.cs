using ItemInfo.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ItemInfo.API
{
    public class DataStore
    {

        public static DataStore Current { get; } = new DataStore();

        public List<DigDto> Digs { get; set; }

        public DataStore()
        {
            Digs = new List<DigDto>()
            {
                new DigDto() {
                    Id = 1,
                    Name = "Smart City",
                    Title = "A way to show how our IoT platform can interact with smart city devices to simplify your life",
                    Description= "<p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/></p><p><span>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</span><br/></p>",
                    Theme = COLORS.RED,
                    TeamName = "CloudItUp",
                    Active = true,
                    Tags = new List<string>()
                    {
                        "SmartCity",
                        "IoT",
                        "Smart Lighting"
                    },
                    Digs = new List<int>()
                },
                new DigDto() {
                    Id = 2,
                    Name = "Connected Home",
                    Title = "A cool smart home of the future.",
                    Description= "<p>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.<br/></p><p><span>It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout. It is a long established fact that a reader will be distracted by the readable content of a page when looking at its layout.</span><br/></p>",
                    Theme = COLORS.GREEEN,
                    TeamName = "CloudItUp",
                    Active = true,
                    Tags = new List<string>()
                    {
                        "Connected Home",
                        "IoT",
                        "Camera"
                    }
                }
            };
        }
    }
}

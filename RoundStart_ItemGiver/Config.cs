using Exiled.API.Interfaces;
using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Enums;
using PlayerRoles;

namespace ItemGiver
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        public bool Debug { get; set; } = false;

        public List<Group> Groups { get; set; } = new List<Group>
        {
            new Group
            {
                Name = "Group1",
                Tag = "VIP",
                Color = "red",
                SteamIds = new List<string>
                {
                    "76561198012345678",  // Пример Steam ID64 игрока
                    "76561198087654321"
                },
                Items = new List<string>
                {
                    "KeycardO5",  // O5-Level Keycard
                    "Medkit"      // Medical Kit
                }
            },
            new Group
            {
                Name = "Group2",
                Tag = "Supporter",
                Color = "blue",
                SteamIds = new List<string>
                {
                    "76561198011223344"
                },
                Items = new List<string>
                {
                    "GunCOM15",   // COM-15 Pistol
                    "Radio"       // Radio Device
                }
            }
        };

        public List<RoleTypeId> BlacklistedRoles { get; set; } = new List<RoleTypeId>
        {
            RoleTypeId.Scp049,
            RoleTypeId.Scp079,
            RoleTypeId.Scp096,
            RoleTypeId.Scp106,
            RoleTypeId.Scp173,
            RoleTypeId.Scp939,
            RoleTypeId.Scp3114
        };
    }

    public class Group
    {
        public string Name { get; set; } = "NewGroup";

        public string Tag { get; set; } = "Player";

        public string Color { get; set; } = "white";

        public List<string> SteamIds { get; set; } = new List<string>();  // Определение SteamIds

        public List<string> Items { get; set; } = new List<string>();  // Определение Items
    }
}
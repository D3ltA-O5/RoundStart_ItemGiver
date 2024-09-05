using Exiled.API.Features;
using Exiled.Events.EventArgs;
using System;
using System.Linq;
using UnityEngine;

namespace ItemGiver
{
    public class RoundStart_ItemGiver : Plugin<Config>
    {
        public override string Name => "RoundStart_ItemGiver";
        public override string Author => "D3ltA_O5";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(8, 11, 0);

        public static RoundStart_ItemGiver Instance { get; private set; }

        public override void OnEnabled()
        {
            Instance = this;
            base.OnEnabled();

            Log.Info("ItemGiverPlugin is being enabled...");
            Exiled.Events.Handlers.Server.RoundStarted += OnRoundStarted;
        }

        public override void OnDisabled()
        {
            Log.Info("ItemGiverPlugin is being disabled...");
            Exiled.Events.Handlers.Server.RoundStarted -= OnRoundStarted;
            base.OnDisabled();
        }

        private void OnRoundStarted()
        {
            foreach (var group in Config.Groups)
            {
                foreach (var player in Player.List)
                {
                    // Извлечение чистого Steam ID без префиксов и суффиксов
                    string steamId = player.UserId;

                    if (steamId.Contains('@'))
                    {
                        steamId = steamId.Split('@')[0]; // Удаление суффикса @steam или другого
                    }

                    Log.Info($"Checking player {player.Nickname} with Steam ID {steamId} for group '{group.Name}'.");

                    // Проверка на нахождение игрока в списке заблокированных ролей
                    if (Config.BlacklistedRoles.Contains(player.Role.Type))
                    {
                        Log.Info($"Player {player.Nickname} with role {player.Role.Type} is blacklisted, skipping item giving.");
                        continue;
                    }

                    if (group.SteamIds.Contains(steamId))
                    {
                        // Установка тега и цвета
                        player.RankName = group.Tag;
                        player.RankColor = group.Color;

                        Log.Info($"Assigning tag '{group.Tag}' with color '{group.Color}' to player {player.Nickname}.");

                        foreach (var itemName in group.Items)
                        {
                            if (Enum.TryParse(itemName, out ItemType itemType))
                            {
                                player.AddItem(itemType);
                                Log.Info($"Given item '{itemType}' to player {player.Nickname}.");
                            }
                            else
                            {
                                Log.Warn($"Invalid item name '{itemName}' in config for group '{group.Name}'.");
                            }
                        }
                    }
                    else
                    {
                        Log.Info($"Player {player.Nickname} with Steam ID {steamId} is not in the group '{group.Name}', skipping.");
                    }
                }
            }
        }
    }
}
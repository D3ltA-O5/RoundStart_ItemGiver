[README на русском](README.ru.md)

# RoundStart_ItemGiver

**RoundStart_ItemGiver** is a plugin for [SCP: Secret Laboratory](https://store.steampowered.com/app/700330/SCP_Secret_Laboratory) using the EXILED framework. This plugin allows server administrators to automatically assign specific items to players at the start of each round based on their Steam IDs, while providing customization options for group tags and colors.

## 🎉 Features

- **Automatic Item Assignment**: Grants specific items to players at the start of each round based on their Steam IDs.
- **Configurable Player Groups**: Allows defining groups of players with different items and roles assigned.
- **Role-Based Restrictions**: SCP players do not receive any items.
- **Custom Tags and Colors**: Set custom tags and colors for players, which will be displayed in the player list.
- **Round-Based Limitations**: Ensures that each player can receive items only once per round.

## 🚀 Installation Instructions

1. **Download** the latest release of `RoundStart_ItemGiver.dll` from the [Releases](https://github.com/D3ltA-O5/SCP-SL-RoundStart_ItemGiver/releases) page.
2. **Place** the `RoundStart_ItemGiver.dll` file into your server's `EXILED/Plugins` directory.
3. **Create** or modify the configuration file in your server's `EXILED/Configs` directory.

## 📋 Configuration

The configuration file `RoundStart_ItemGiver.yml` allows you to customize the plugin's behavior. Below is a breakdown of the available options:

- **is_enabled**: Enable or disable the plugin (default: `true`).
- **debug**: Enable or disable debug mode for additional logging (default: `false`).
- **groups**: Define groups of players by their Steam IDs and assign them specific items and roles.
- **blacklisted_roles**: List of roles that are excluded from receiving items.

Refer to the example configuration file included in the repository for detailed setup instructions.

## 📋 Requirements

- **EXILED Framework**: This plugin requires EXILED version 8.11.0 or higher. Make sure your server is up-to-date.

## ⚠️ Important Notes

- This plugin is designed to enhance gameplay by automatically assigning items to players based on server administrator configurations.
- It is important to keep your EXILED framework and server up-to-date to avoid any compatibility issues.

## ✅ What's New

- **v1.0.0**: Initial release of the **RoundStart_ItemGiver** plugin.
  - Added functionality for automatic item assignment at the start of each round.
  - Support for custom player tags and colors.

## 📧 Contact and Support

For any questions, issues, or suggestions, please open an issue on the [GitHub repository](https://github.com/D3ltA-O5/SCP-SL-RoundStart_ItemGiver) or DM me in discord my ds: cyberco.

## 📜 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

---

Thank you for using **RoundStart_ItemGiver**! Enjoy customizing your SCP: SL server!

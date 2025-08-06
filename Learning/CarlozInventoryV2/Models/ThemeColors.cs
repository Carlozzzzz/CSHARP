using System.Drawing;

namespace CarlozInventoryV2.Models
{
    public static class ThemeColors
    {
        public static Color GetPanelHeaderColor(Themes theme)
        {
            switch (theme)
            {
                case Themes.LightMode: return Color.DarkGray;
                case Themes.DarkMode: return Color.Black;
                case Themes.ClassicMode: return Color.FromArgb(64, 64, 64);
                default: return SystemColors.Control;
            }
        }

        public static Color GetPanelBodyCOlor(Themes theme)
        {
            switch (theme)
            {
                case Themes.LightMode: return SystemColors.ButtonHighlight;
                case Themes.DarkMode: return Color.FromArgb(64, 64, 64);
                case Themes.ClassicMode: return SystemColors.AppWorkspace;
                default: return SystemColors.Control;
            }
        }

        public static Color GetButtonBackColor(Themes theme)
        {
            switch (theme)
            {
                case Themes.LightMode: return Color.White;
                case Themes.DarkMode: return Color.FromArgb(45, 45, 45);
                case Themes.ClassicMode: return Color.LightGray;
                default: return SystemColors.Control;
            }
        }

        public static Color GetForeColor(Themes theme, Color backColor)
        {
            // If the background is dark, use white; otherwise, use black
            int brightness = (backColor.R + backColor.G + backColor.B) / 3;
            return brightness < 128 ? Color.White : Color.Black;
        }
    }
}
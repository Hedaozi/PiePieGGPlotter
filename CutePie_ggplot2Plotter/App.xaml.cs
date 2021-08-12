using System.Collections.Generic;
using System.Windows;
using ControlzEx.Theming;
using System.Windows.Media;

namespace CutePie_ggplot2Plotter
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public static readonly List<string> Cpus = Utils.DetectEquipment.GetCPUNames();
        public static readonly List<string> Gpus = Utils.DetectEquipment.GetGPUNames();
        public static readonly int CPUIndex = Cpus.Count - 1;
        public static readonly int GPUIndex = Gpus.Count - 1;

        public UI.MainPages.DataPage dataPage = new UI.MainPages.DataPage();
        public UI.MainPages.PlotPage plotPage = new UI.MainPages.PlotPage();
        public UI.MainPages.MapPage mapPage = new UI.MainPages.MapPage();
        public UI.MainPages.REnvPage rEnvPage = new UI.MainPages.REnvPage();

        public string BaseColor { get; set; }
        public string ColorScheme { get; set; }

        public void ChangeBaseColor(string baseColor, string colorScheme)
        {
            ThemeManager.Current.ChangeTheme(this, baseColor, colorScheme);
            BaseColor = baseColor;

            bool dark = baseColor == "Dark";
            Resources["IdealForeBrush"] = new SolidColorBrush(!dark ? Colors.Black : Colors.White);
            Resources["NavigatorMouseOverBrush"] = new SolidColorBrush((dark ? Color.FromRgb(63, 63, 63) : Color.FromRgb(247, 247, 247)));
        }

        public void ChangeColorScheme(string baseColor, string colorScheme)
        {
            ThemeManager.Current.ChangeTheme(this, baseColor, colorScheme);
            ColorScheme = colorScheme;

            Theme theme = ThemeManager.Current.GetTheme(baseColor, colorScheme);
            Resources["AccentBaseBrush"] = new SolidColorBrush(theme.PrimaryAccentColor);
        }

        public void ChangeFontFamily(FontFamily fontFamily)
        {
            Resources["GlobalFontFamily"] = fontFamily;
        }
    }
}

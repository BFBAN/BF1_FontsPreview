using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BF1_FontsPreview
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            List<Font> fonts = new List<Font>();

            fonts.Add(new Font() { DTFontName = "ARHeitiMediumB5-0dc1118f", DTFontFamily = "Fonts/#ARHeitiMediumB5" });
            fonts.Add(new Font() { DTFontName = "Asiajunggothic-c10f28b5", DTFontFamily = "/Fonts/#Asia중고딕" });
            fonts.Add(new Font() { DTFontName = "BFHead-Light-13e795ad", DTFontFamily = "/Fonts/#BFHead" });
            fonts.Add(new Font() { DTFontName = "BFHead-Regular-2ae49698", DTFontFamily = "/Fonts/#BFHead Regular" });

            fonts.Add(new Font() { DTFontName = "BFText-Bold-e3002166", DTFontFamily = "/Fonts/#BFText Bold" });
            fonts.Add(new Font() { DTFontName = "BFText-Light-b5ca7eb2", DTFontFamily = "/Fonts/#BFText Light" });
            fonts.Add(new Font() { DTFontName = "BFText-Regular-37d995da", DTFontFamily = "/Fonts/#BFText" });
            fonts.Add(new Font() { DTFontName = "BFText-Regular-SC-19cf572c", DTFontFamily = "/Fonts/#BFText-Regular-SC" });

            fonts.Add(new Font() { DTFontName = "DFP_sougeitai_W5-d813b437", DTFontFamily = "/Fonts/#DFP_sougeitai_W5" });
            fonts.Add(new Font() { DTFontName = "FuturaMaxiBook-AR-b175aa25", DTFontFamily = "/Fonts/#Noto Kufi Arabic" });
            fonts.Add(new Font() { DTFontName = "FuturaMaxiBook-JP-d50af3c6", DTFontFamily = "/Fonts/#HGGothicE" });
            fonts.Add(new Font() { DTFontName = "FuturaMaxiBook-TC-c3bf1e0d", DTFontFamily = "/Fonts/#FuturaMaxiBook-TC" });

            fonts.Add(new Font() { DTFontName = "FuturaMaxiStd-Book-ee00ffa1", DTFontFamily = "/Fonts/#Futura Maxi Std Book" });
            fonts.Add(new Font() { DTFontName = "FuturaMaxiStd-Light-a0a07b55", DTFontFamily = "/Fonts/#Futura Maxi Std Light" });
            fonts.Add(new Font() { DTFontName = "Purista-Medium-12682148", DTFontFamily = "/Fonts/#Purista" });
            fonts.Add(new Font() { DTFontName = "Purista-SemiBold-7bc23464", DTFontFamily = "/Fonts/#Purista SemiBold" });

            ListBox_FontsPreView.ItemsSource = fonts;

            TextBox_FontsPreView.SelectionStart = TextBox_FontsPreView.Text.Length;
        }
    }

    public class Font
    {
        public string DTFontName { get; set; }
        public string DTFontFamily { get; set; }
    }
}

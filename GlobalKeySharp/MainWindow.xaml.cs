using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace GlobalKeySharp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private static pfnKeyBoardEvent _OnKeyBoardEvent;

        private void OnMainLoaded(object sender, RoutedEventArgs e)
        {
            _OnKeyBoardEvent = new pfnKeyBoardEvent(OnKeyBoardEvent);
            GlobalKeySharpApi.SetGlobalKeyListner(Marshal.GetFunctionPointerForDelegate(_OnKeyBoardEvent));
        }

        private void OnKeyBoardEvent(uint KeyCode, bool bPressed)
        {
            if (!bPressed)
            {
                return;
            }
            Dispatcher.Invoke(() =>
            {
                if (KeyCode == 'Q')//Q is Pre
                {
                    Console.WriteLine("退出SteamVR: ");
                }
                else if (KeyCode == 'S')
                {
                    Console.WriteLine("启动SteamVR: ");
                }

                if (Keyboard.IsKeyDown(Key.LeftCtrl) || Keyboard.IsKeyDown(Key.RightCtrl))
                {

                }
            });

        }

    }
}

# GlobalKeySharp
Global key hook, Non conflict hotkey, Keyboard Nonitor 

Tips: 
1. This is a keyboard hook library running on Windows.
2. This library also suport programs that using C++. 
3.The demo is a x86 application. you can use x64 if you like.

Usage steps (C#):
1. Download and run the solusion, if you can run the demo, next step.
2. Copy "GlobalKeySharpApi.cs" to your own project.
3. Copy "GlobalKeyboard.dll" to your .exe directory.
4. See the demo code "MainWindow.xaml.cs"

private static pfnKeyBoardEvent _OnKeyBoardEvent;
 private void OnMainLoaded(object sender, RoutedEventArgs e)
{
   _OnKeyBoardEvent = new pfnKeyBoardEvent(OnKeyBoardEvent);
   GlobalKeySharpApi.SetGlobalKeyListner(Marshal.GetFunctionPointerForDelegate(_OnKeyBoardEvent));
}
private void OnKeyBoardEvent(uint KeyCode, bool bPressed)
{
   Dispatcher.Invoke(() =>
     {//Do Any thing you like!
     });
}

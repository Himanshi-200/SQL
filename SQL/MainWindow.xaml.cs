using Microsoft.Data.Sqlite;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using MongoDB.Driver.Core.Configuration;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;




// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace SQL
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private async void LaunchToolkitButton_Click(object sender, RoutedEventArgs e)
        {
            // Either open the app if already instealled or the Microsoft Store

            var isToolkitAvailable = await Windows.System.Launcher.QueryUriSupportAsync(new Uri("uwpct://controls?sample=datagrid"), Windows.System.LaunchQuerySupportType.Uri);

            if (isToolkitAvailable == LaunchQuerySupportStatus.Available)
            {
                await Windows.System.Launcher.LaunchUriAsync(new Uri("uwpct://controls?sample=datagrid"));
            }
            else
            {
                await Windows.System.Launcher.LaunchUriAsync(new Uri(@"ms-windows-store://pdp/?ProductId=9NBLGGH4TLCQ"));
            }
        }
    }
}

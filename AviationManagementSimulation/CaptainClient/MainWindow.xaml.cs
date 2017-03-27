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
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;
namespace CaptainClient
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        IRemotingService remoteobj;
        public MainWindow()
        {
            
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            TcpClientChannel chan = new TcpClientChannel();
            ChannelServices.RegisterChannel(chan, false);
            //   ChannelServices.RegisterChannel(new TcpClientChannel(),false);
            remoteobj = (IRemotingService)Activator.GetObject(typeof(IRemotingService),
        "tcp://localhost:9999/serverMethod", null);
        }
    }
}

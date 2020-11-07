using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// ������������ �� ������� �������� "������ ��������" ��. �� ������ https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Lab1
{
    /// <summary>
    /// ������ ��������, ������� ����� ������������ ���� �� ���� ��� ��� �������� ������ ������.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        Random rand;
        public MainPage()
        {
            this.InitializeComponent();
            rand = new Random();
        }

        private void TextBox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private byte[] GetRandomBytes(int n)
        {
            var randomBytes = new byte[n];
            rand.NextBytes(randomBytes);
            return randomBytes;
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            byte[] rgb = GetRandomBytes(3);

            //�������� ��������� �������� ������� �� 3 ��������� ������
            var randomColorBrush = new SolidColorBrush(Color.FromArgb(255, rgb[0], rgb[1], rgb[2]));

            TextBox1.BorderBrush = randomColorBrush;
            TextBox1.Foreground = randomColorBrush;
        }
    }
}

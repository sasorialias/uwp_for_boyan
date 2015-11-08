﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using App1.Components;

//“空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409 上有介绍

namespace App1
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void button_Click(object sender, RoutedEventArgs e)
        {
            var file = await FileManage.SelectSingleFile();
            Player.Play(file);
        }

        private void buttonPlay_Click(object sender, RoutedEventArgs e)
        {
            Player.Play();
        }

        private void buttonPause_Click(object sender, RoutedEventArgs e)
        {
            Player.Pause();
        }

        private void buttonStop_Click(object sender, RoutedEventArgs e)
        {
            Player.Stop();
        }
    }
}

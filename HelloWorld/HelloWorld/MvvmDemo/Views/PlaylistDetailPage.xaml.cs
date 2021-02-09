﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWorld.MvvmDemo.Models;
using HelloWorld.MvvmDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.MvvmDemo.Views
{
    public partial class PlaylistDetailPage : ContentPage
    {
        private PlaylistViewModel _playlist;

        public PlaylistDetailPage(PlaylistViewModel playlist)
        {
            _playlist = playlist;

            InitializeComponent();

            title.Text = _playlist.Title;
        }
    }
}

using System;
using HelloWorld.MvvmDemo.Models;
using HelloWorld.MvvmDemo.ViewModels;
using HelloWorld.MvvmDemo.Views;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Tests
{
    [TestClass]
    public class PlaylistViewModelTests
    {
        private PlaylistsViewModel _viewModel;
        private Mock<IPageService> _pageService;

        public void Setup()
        {
            _pageService = new Mock<IPageService>();
            _viewModel = new PlaylistsViewModel(_pageService.Object);
        }

        [TestMethod]
        public void AddPlaylist_WhenCalled_TheNewPlaylistShouldBeInTheList()
        {
            _viewModel.AddPlaylistCommand.Execute(null);
            Assert.AreEqual(1, _viewModel.Playlists.Count);
        }

        [TestMethod]
        public void SelectPlaylist_WhenCalled_TheSelectedItemShoudBeDeselected()
        {
            var playlist = new PlaylistViewModel();
            _viewModel.Playlists.Add(playlist);


            _viewModel.SelectPlaylistCommand.Execute(playlist);

            Assert.IsNull(_viewModel.SelectedPlaylist);
        }

        [TestMethod]
        public void SelectPlayList_WhenCalled_IsfavoritePropertyOfPlayListIsToggled()
        {
            var playlist = new PlaylistViewModel();
            _viewModel.Playlists.Add(playlist);
            _viewModel.SelectPlaylistCommand.Execute(playlist);

            Assert.IsTrue(playlist.IsFavorite);
        }

        [TestMethod]
        public void SelectPlaylist_WHenCalled_ShouldNavigateUserToPlaylistDetailPage()
        {
            var playlist = new PlaylistViewModel();
            _viewModel.Playlists.Add(playlist);
            _viewModel.SelectPlaylistCommand.Execute(playlist);

            _pageService.Verify(p => p.PushAsync(It.IsAny< PlaylistDetailPage >()));
        }
    }
}
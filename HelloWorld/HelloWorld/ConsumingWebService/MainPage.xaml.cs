﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HelloWorld.ConsumingWebService
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }

    public partial class MainPage : ContentPage
    {
        private const string Url = "https://jsonplaceholder.typicode.com/posts";
        private HttpClient _client = new HttpClient();
        private ObservableCollection<Post> _posts;
        public MainPage()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            var content = await _client.GetStringAsync(Url);
            var posts = JsonConvert.DeserializeObject<List<Post>>(content);
            _posts = new ObservableCollection<Post>(posts);
            postsListView.ItemsSource = _posts;
            base.OnAppearing();

        }

        async void OnAdd(object sender, System.EventArgs e)
        {
            var post = new Post() { Title = "Title " + DateTime.Now.Ticks };
            _posts.Insert(0, post);

            var content = JsonConvert.SerializeObject(post);
            await _client.PostAsync(Url, new StringContent(content));

        }

        async void OnUpdate(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            post.Title += " UPDATED";
            var content = JsonConvert.SerializeObject(post);
            await _client.PutAsync(Url + "/" + post.Id, new StringContent(content));
        }

        void OnDelete(object sender, System.EventArgs e)
        {
            var post = _posts[0];
            _posts.Remove(post);
            _client.DeleteAsync(Url + "/" + post.Id);
        }
    }
}
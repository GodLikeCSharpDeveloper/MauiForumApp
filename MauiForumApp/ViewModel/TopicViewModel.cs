using CommunityToolkit.Mvvm.Input;
using MauiForumApp.Models;
using MauiForumApp.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiForumApp.View;

namespace MauiForumApp.ViewModel
{
    public partial class TopicViewModel : BaseViewModel
    {
        TopicService topicService;
        public ObservableCollection<TopicModel> TopicList { get; } = new();
        public TopicViewModel(TopicService topicService)
        {
            Title = "List of topics";
            this.topicService = topicService;
            
        }

        [RelayCommand]
        async Task GetTopicsAsync()
        {
            if (IsBusy) return;
            try
            {
                IsBusy = true;
                var topic = await topicService.GenerateInfo(10);
                foreach (var topicItem in topic)
                {
                    TopicList.Add(topicItem);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
                

            }
            finally
            {
                IsBusy = false;
            }
        }
        [RelayCommand]
        async Task GoToDetailsAsync(TopicModel topic)
        {
            if (topic is null)
                return;

           await Shell.Current.GoToAsync(nameof(DetailsPage), true, new Dictionary<string, object>
                {
                    {"Topic", topic }
                });
         }

    }
}

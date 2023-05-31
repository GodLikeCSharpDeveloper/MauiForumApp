using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using MauiForumApp.Models;

namespace MauiForumApp.ViewModel
{
    [QueryProperty("Topic", "Topic")]
    public partial class DetailsPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        TopicModel topic;

        public DetailsPageViewModel()
        {
            
        }
    }
}

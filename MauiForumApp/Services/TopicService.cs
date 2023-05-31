using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MauiForumApp.Models;

namespace MauiForumApp.Services
{
    public class TopicService
    {
       List<TopicModel> Topics = new();
        StringBuilder StringBuild = new StringBuilder();
        public async Task<List<TopicModel>> GenerateInfo(int number)
        {
            foreach (var topic in Faker.Lorem.Paragraphs(4))
            {
                var result = StringBuild.Append(topic.ToString());

            }
            for (int i = 0; i < number; i++)
            {
                Topics.Add(new TopicModel
                {
                    Id = i,
                    TopicTitle = Faker.Lorem.GetFirstWord(),
                    TopicContent = StringBuild.ToString(),
                    TopicReleaseDate = Faker.RandomNumber.Next(1, 100).ToString(),
                    TopicUpdateDate = Faker.RandomNumber.Next(1, 100).ToString(),
                });
            }
            return Topics;
            //TODO DATABASE CONTENT POG POG PogChamp

        }
    }
}

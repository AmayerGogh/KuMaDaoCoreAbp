using Abp.Dependency;
using Abp.Events.Bus;
using Abp.Events.Bus.Handlers;
using KuMaDaoCoreAbp.Authorization.Users;
using System;
using System.Collections.Generic;
using System.Text;

namespace KuMaDaoCoreAbp.Articles
{
   

    public class ArticleEventData : EventData
    {
        public Article Article { get; set; }
    }
    public class ArticleCreatedEventData:ArticleEventData
    {
        public  User CreatorUser { get; set; }
    }


    public class ArticleCompletedEventData : ArticleEventData
    {
        public User CompletorUser { get; set; }
    }



    public class ArticleWriter : IEventHandler<ArticleEventData>, ITransientDependency
    {
        public void HandleEvent(ArticleEventData eventData)
        {
            if (eventData is ArticleCreatedEventData)
            {

            }else if(eventData is ArticleCompletedEventData)
            {

            }
           
        }
    }
    //第二种方式
    public class ArticleWriter2 : IEventHandler<ArticleCreatedEventData>, IEventHandler<ArticleCompletedEventData>, ITransientDependency
    {
        public void HandleEvent(ArticleCompletedEventData eventData)
        {
            throw new NotImplementedException();
        }

        public void HandleEvent(ArticleCreatedEventData eventData)
        {
            throw new NotImplementedException();
        }
    }

}

﻿using System.Collections.Generic;
using EPiServer.Commerce.Catalog.ContentTypes;
using EPiServer.Core;

namespace CommerceTraining.Models.ViewModels
{
    public class PageViewModel<T> where T : PageData
    {

        // ToDo: rootChildren nodes (lab C)


        public IEnumerable<NodeContent> topLevelCategories { get; set; }
        public virtual XhtmlString MainBodyStartPage { get; set; }

        public PageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
        }

        public T CurrentPage
        {
            get;
            set;
        }
    }
}
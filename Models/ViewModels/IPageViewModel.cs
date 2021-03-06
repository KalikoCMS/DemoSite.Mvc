﻿namespace DemoSite.Models.ViewModels {
    using System.Collections.Generic;
    using KalikoCMS.Core;

    public interface IPageViewModel<out T> where T : CmsPage {
        T CurrentPage { get; }
        DemoSite CurrentSite { get; }
        IEnumerable<CmsPage> TopMenu { get; set; }
    }
}
﻿namespace SocialMedia.Core.Customs.Base
{
    public interface IPagedList
    {
        #region Data
        int Currentpage { get; set; }
        int TotalPages { get; set; }
        int PageSize { get; set; }
        int TotalRows { get; set; }
        #endregion

        #region Computed
        bool HasPreviousPage { get; }
        bool HasNextPage { get; }
        int? NextPageNumber { get; }
        int? PreviousPageNumber { get; }
        #endregion
    }
}

using System.Collections.Generic;

namespace wow.ApiLibrary.Models
{
	/// <summary>
	/// Class ApiPagedList.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public class LeadApiPagedList
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="ApiPagedList{T}"/> class.
		/// </summary>
		/// <param name="collection">The collection.</param>
		/// <param name="pageCount">The page count.</param>
		/// <param name="totalItemCount">The total item count.</param>
		/// <param name="pageIndex">Index of the page.</param>
		/// <param name="pageNumber">The page number.</param>
		/// <param name="pageSize">Size of the page.</param>
		/// <param name="hasPreviousPage">if set to <c>true</c> [has previous page].</param>
		/// <param name="hasNextPage">if set to <c>true</c> [has next page].</param>
		/// <param name="isFirstPage">if set to <c>true</c> [is first page].</param>
		/// <param name="isLastPage">if set to <c>true</c> [is last page].</param>
		/// <param name="firstItemOnPage">The first item on page.</param>
		/// <param name="lastItemOnPage">The last item on page.</param>
		public LeadApiPagedList (List<Lead> data, int pageCount, int totalItemCount, int pageIndex, int pageNumber, int pageSize,
		                        bool hasPreviousPage, bool hasNextPage, bool isFirstPage, bool isLastPage,
		                        int firstItemOnPage, int lastItemOnPage)
		{
			Data = data;
			LastItemOnPage = lastItemOnPage;
			FirstItemOnPage = firstItemOnPage;
			IsLastPage = isLastPage;
			IsFirstPage = isFirstPage;
			HasNextPage = hasNextPage;
			HasPreviousPage = hasPreviousPage;
			PageSize = pageSize;
			PageNumber = pageNumber;
			PageIndex = pageIndex;
			TotalItemCount = totalItemCount;
			PageCount = pageCount;
		}

		/// <summary>
		/// Gets the data.
		/// </summary>
		/// <value>The data.</value>
		public List<Lead> Data { get; private set; }

		/// <summary>
		/// Gets the page count.
		/// </summary>
		/// <value>The page count.</value>
		public int PageCount { get; private set; }

		/// <summary>
		/// Gets the total item count.
		/// </summary>
		/// <value>The total item count.</value>
		public int TotalItemCount { get; private set; }

		/// <summary>
		/// Gets the index of the page.
		/// </summary>
		/// <value>The index of the page.</value>
		public int PageIndex { get; private set; }

		/// <summary>
		/// Gets the page number.
		/// </summary>
		/// <value>The page number.</value>
		public int PageNumber { get; private set; }

		/// <summary>
		/// Gets the size of the page.
		/// </summary>
		/// <value>The size of the page.</value>
		public int PageSize { get; private set; }

		/// <summary>
		/// Gets a value indicating whether this instance has previous page.
		/// </summary>
		/// <value><c>true</c> if this instance has previous page; otherwise, <c>false</c>.</value>
		public bool HasPreviousPage { get; private set; }

		/// <summary>
		/// Gets a value indicating whether this instance has next page.
		/// </summary>
		/// <value><c>true</c> if this instance has next page; otherwise, <c>false</c>.</value>
		public bool HasNextPage { get; private set; }

		/// <summary>
		/// Gets a value indicating whether this instance is first page.
		/// </summary>
		/// <value><c>true</c> if this instance is first page; otherwise, <c>false</c>.</value>
		public bool IsFirstPage { get; private set; }

		/// <summary>
		/// Gets a value indicating whether this instance is last page.
		/// </summary>
		/// <value><c>true</c> if this instance is last page; otherwise, <c>false</c>.</value>
		public bool IsLastPage { get; private set; }

		/// <summary>
		/// Gets the first item on page.
		/// </summary>
		/// <value>The first item on page.</value>
		public int FirstItemOnPage { get; private set; }

		/// <summary>
		/// Gets the last item on page.
		/// </summary>
		/// <value>The last item on page.</value>
		public int LastItemOnPage { get; private set; }
	}

}

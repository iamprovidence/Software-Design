﻿namespace Pagination.Interfaces
{
    /// <summary>
    /// Determines in which way pagination should be build
    /// </summary>
    public interface IBuildStrategy
    {
        /// <summary>
        /// Build pagination
        /// </summary>
        /// <param name="pagination">
        /// Pagination model with data
        /// </param>
        /// <returns>
        /// The class that can create HTML elements
        /// </returns>
        Microsoft.AspNetCore.Mvc.Rendering.TagBuilder Build(Pagination pagination);
    }
}

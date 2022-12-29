using System;

using Microsoft.Extensions.Logging;
using System.Diagnostics;
using WebDriverTests.Model;

namespace WebDriverTests.Service
{
    public static class SearchCreate
    {
        private static readonly ILoggerFactory _loggerFactory = new LoggerFactory();
        private static readonly ILogger _logger = _loggerFactory.CreateLogger("CustomCategory");

        private static string _searchString = "Куртка";

        public static Search CreateSearchWithCredentialsString()
        {
            var search = new Search(_searchString);
            _logger.LogInformation("Search created with credentials string");
            return search;
        }

        public static Search CreateSearchWithEmptyString()
        {
            var search = new Search("");
            _logger.LogInformation("Search created with empty string");
            return search;
        }
    }
}
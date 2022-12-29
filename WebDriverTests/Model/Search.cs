using System;

namespace WebDriverTests.Model
{
    public class Search
    {
        private string _searchString;

        public string SearchString
        {
            get 
            { 
                return _searchString; 
            }
            set 
            { 
                _searchString = value; 
            }
        }

        public Search(string searchString)
        {
            _searchString = searchString;
        }  
    }
}

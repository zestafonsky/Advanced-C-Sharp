using System;
using System.Collections.Generic;
using System.Text;

namespace FileSystem.Library
{
    public class FindedProgressArgs : EventArgs
    {
        public string FoundName { get; internal set; }
    }

    public class FilteredFindedProgressArgs : EventArgs
    {
        public string FoundName { get; internal set; }

        public bool StopSearch { get; set; }

        public bool Exclude { get; set; }
    }
}

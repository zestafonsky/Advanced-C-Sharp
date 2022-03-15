using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace FileSystem.Library
{
    public interface IFileSystemVisitor: IEnumerable<string>
    {
        event EventHandler<FindedProgressArgs> FileFinded;
        event EventHandler<FindedProgressArgs> DirectoryFinded;
        event EventHandler<FilteredFindedProgressArgs> FilteredFileFinded;
        event EventHandler<FilteredFindedProgressArgs> FilteredDirectoryFinded;
        event EventHandler Start;
        event EventHandler Finish;
    }

    public class FileSystemVisitor : IFileSystemVisitor
    {
        private readonly IFileProvider _fileProvider;
        private string _startAddress;
        private Func<string, bool> _searchPredicate;

        public event EventHandler Start;
        public event EventHandler Finish;

        public event EventHandler<FindedProgressArgs> FileFinded;
        public event EventHandler<FindedProgressArgs> DirectoryFinded;

        public event EventHandler<FilteredFindedProgressArgs> FilteredFileFinded;
        public event EventHandler<FilteredFindedProgressArgs> FilteredDirectoryFinded;

        private bool StopSerach { get; set; }

        public FileSystemVisitor(IFileProvider fileProvider, string startingaddress, Func<string, bool> searchPredicate)
        {
            _fileProvider = fileProvider;
            _startAddress = startingaddress;
            _searchPredicate = searchPredicate;
        }

        public IEnumerable<string> FindFiles()
        {
            Start?.Invoke(this, null);

            var fileList = _fileProvider.GetFiles(_startAddress)
                .Where((s) =>
                {
                    if (_fileProvider.DirectoryExists(s))
                    {
                        DirectoryFinded?.Invoke(this, new FindedProgressArgs { FoundName = s });
                        return CheckConditions(s, true);
                    }
                    else
                    {
                        FileFinded?.Invoke(this, new FindedProgressArgs { FoundName = s });
                        return CheckConditions(s);
                    }
                }).TakeWhile((f) =>
                {
                    if (StopSerach == true)
                    {
                        return false;
                    }
                    else
                        return true;
                }).ToList();
            Finish?.Invoke(this, null);
            StopSerach = false;
            return fileList;
        }

        private bool CheckConditions(string s, bool isdir = false)
        {
            if (_searchPredicate.Invoke(s))
            {
                var args = new FilteredFindedProgressArgs();
                args.FoundName = s;
                if (isdir)
                {
                    FilteredDirectoryFinded?.Invoke(this, args);
                }
                else
                {
                    FilteredFileFinded?.Invoke(this, args);
                }
                StopSerach = args.StopSearch;

                if (args.Exclude)
                {
                    return false;
                }
                return true;
            }
            else
                return false;
        }

        private IEnumerable<string> _fileList { get { return FindFiles(); } }

        public IEnumerator<string> GetEnumerator()
        {
            foreach (var file in _fileList)
            {
                yield return file;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return _fileList.GetEnumerator();
        }
    }
}

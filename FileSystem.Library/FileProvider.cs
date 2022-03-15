using System.IO;

namespace FileSystem.Library
{
    public interface IFileProvider
    {
        string[] GetFiles(string path);
        bool DirectoryExists(string path);  
    }

    public class FileProvider : IFileProvider
    {
        public bool DirectoryExists(string path)
        {
           return Directory.Exists(path);
        }

        public string[] GetFiles(string path)
        {
            return Directory.GetFileSystemEntries(path, "*.*", SearchOption.AllDirectories);
        }
    }
}

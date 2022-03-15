using System;
using System.Collections.Generic;
using System.IO;

namespace FileSystemVisitor
{
    public  class Finder
    {
        public List<string> Files = new List<string>();
        public delegate void MyEventHandler();
        public event MyEventHandler Started;
        public event MyEventHandler Finishied;
        public void OnStarted()
        {
            if (Started !=null)
            { 
                Started();
            }
        }
        public void OnFinished()
        {
            if (Finishied != null)
            {
                Finishied();
            }
        } 
        public  void GetFiles(string dir, string extension)
        {
            DirectoryInfo[] dirs = new DirectoryInfo(dir).GetDirectories();
            foreach (var item in dirs)
            {
                Files.Add(item.Name);
                GetFiles(item.FullName, extension);
            }

            FileInfo[] files = new DirectoryInfo(dir).GetFiles(extension);
            foreach (var item in files)
            {
                Files.Add(item.Name);
            }
        }
    }
}

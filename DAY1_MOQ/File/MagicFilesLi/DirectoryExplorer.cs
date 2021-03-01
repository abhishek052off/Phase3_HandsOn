using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MagicFilesLi
{
    public interface IDirectoryExplorer

    {

        ICollection<string> GetFiles(string path);

    }


    public class DirectoryExplorer : IDirectoryExplorer

    {
        

        //public DirectoryExplorer(IDirectoryExplorer directory)
        //{
        //    _directory = directory;
        //}

        public ICollection<string> GetFiles(string path)

        {

            string[] files = Directory.GetFiles(path);

            return files;

        }

    }


}

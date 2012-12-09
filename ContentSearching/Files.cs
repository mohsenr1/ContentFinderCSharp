using System;
using System.Collections.Generic;

using System.Text;

namespace ContentSearching
{
    class Files
    {
        private string filePath;
        private string fileContent;

        public string Path
        {
            get { return filePath; }
            set { filePath = value; }
        }

        public string Content
        {
            get { return fileContent; }
            set { fileContent = value; }
        }
    }
}

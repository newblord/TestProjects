using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseEngineerDBTool.DesignPatterns.Models
{
    public class NewFile
    {
        public string ProjectName { get; set; }
        public string FolderName { get; set; }
        public string FileName { get; set; }
        public string FileContent { get; set; }
        public string FilePath { get; set; }
        public string OutputPath { get; set; }
        public int Start { get; set; }
        public int Length { get; set; }
    }
}

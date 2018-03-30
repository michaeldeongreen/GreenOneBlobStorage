using GreenOneBlobStorage.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenOneBlobStorage.Services
{
    public class FileService
    {
        public byte[] ConvertToBytes(string file)
        {
            byte[] bytes = File.ReadAllBytes(file);
            return bytes;
        }

        public string GetFileNameOnly(string file)
        {
            string name = Path.GetFileName(file);
            return name;
        }

        public string GetFileExtension(string file)
        {
            string extension = Path.GetExtension(file);
            return extension;
        }

        public string WriteBytesToFile(string path, Document document)
        {
            string file = $"{path}\\{document.Name}";
            File.WriteAllBytes(file, document.Bytes);
            return file;
        }
    }
}

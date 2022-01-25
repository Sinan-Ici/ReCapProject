using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        public string Update(IFormFile file, string filePath, string root);//Yeni dosya, eski dosyanın kayıt dizini, yeni kayıt dizini
        public string Upload(IFormFile file, string root);
        public void Delete(string filePath);
    }
}

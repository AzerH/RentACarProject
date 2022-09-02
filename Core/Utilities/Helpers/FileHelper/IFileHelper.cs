using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Helpers.FileHelper
{
    public interface IFileHelper
    {
        string Update(IFromFile file, string root);
        void Delete(string filePath);
        string Update(IFromFile file, string filePath, string root);

    }
}

using Microsoft.AspNetCore.Http;

namespace Baselayer.Filters
{
    public static class CheckExtensionFile
    {
        public static bool ImageFile(IFormFile file)
        {
            var extension = "." + file.FileName.Split('.')[file.FileName.Split('.').Length - 1];
            return (extension == ".jpg" || extension == ".png" || extension == ".jpeg" || extension == ".svg"); // Change the extension based on your need
        }

        public static bool Size(IFormFile file, int LengthfilterByte)
        {
            if (file.Length > LengthfilterByte)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

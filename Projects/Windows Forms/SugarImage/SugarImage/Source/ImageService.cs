using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace SugarImage.Source
{
    class ImageService
    {
        const string IMAGE_SERVICE_URI = "https://dummyimage.com/{0}x{1}/{2}/{3}&text={4}";

        public ImageService()
        {

        }

        public async Task<Image> Generate(int width, int height, string background = "cccccc", string foreground = "000000", string text = "")
        {
            using (var client = new WebClient())
            {
                client.Headers["User-Agent"] = "SugarImage Utility ~ v1.0";

                return await Task.Factory.StartNew(() =>
                {
                    using (var stream = new MemoryStream(client.DownloadData(string.Format(IMAGE_SERVICE_URI, width, height, background, foreground, text))))
                        return new Bitmap(stream);
                });
            }
        }
    }
}

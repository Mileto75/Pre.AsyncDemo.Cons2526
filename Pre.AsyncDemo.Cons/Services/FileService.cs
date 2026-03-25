using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pre.AsyncDemo.Cons.Services
{
    public class FileService
    {
        public void CreateLargeFile()
        {
            //create a large file 1Gb on the desktop
            long filesize = 1024 * 1024 * 1024; //1Gb
            long chunkSize = 1024 * 1024; //1Mb
            long bytesWritten = 0;
            byte[] randomBytes = new byte[chunkSize];
            //path to file
            string pathToDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string pathToFile = Path.Combine(pathToDesktop, "largeFile.txt");
            Random random = new Random();
            //fill it with random stuff
            using (FileStream fileStream = new(pathToFile, FileMode.OpenOrCreate, FileAccess.Write))
            {
                //loop and fill the file until 1Gb
                while (bytesWritten < filesize)
                {
                    //generate random byte[]
                    random.NextBytes(randomBytes);
                    //write to file
                    fileStream.Write(randomBytes);
                    bytesWritten += chunkSize;
                }
            }
        }
    }
}

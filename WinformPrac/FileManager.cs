using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinformPrac
{
    class FileManager
    {
        Byte[] size = new byte[1024];
        int pos;

        public void copy()
        {
            BinaryReader rd = new BinaryReader(File.Open("test.csv", FileMode.Open));
            BinaryWriter rw = new BinaryWriter(File.Open("test_copy.csv", FileMode.Create));

            long size = new FileInfo("test.csv").Length;
                
            while(pos < size)
            {

            }


        }
    }
}

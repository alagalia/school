using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stacksAndQueues
{
    public static class IOManager
    {
        public static void TraverseDirectory(string path)
        {
            /// my way 

            DirectoryInfo firstDirectory = new DirectoryInfo(path);
            //var ican = firstDirectory.GetAccessControl();
            if (!firstDirectory.ToString().Contains("$RECYCLE.BIN") && !firstDirectory.ToString().Contains("System Volume Information"))
            {
                DirectoryInfo[] allDirectories = firstDirectory.GetDirectories();

                Console.WriteLine(path);

                foreach (var filess in firstDirectory.GetFiles())
                {
                    Console.WriteLine(firstDirectory.ToString() + "\\" + filess.Name);
                }

                if (allDirectories.Count() > 0)
                {
                    foreach (var dir in allDirectories)
                    {
                        if (!dir.ToString().Contains("$RECYCLE.BIN") && !dir.ToString().Contains("System Volume Information"))
                        {
                            DirectoryInfo nextDir = new DirectoryInfo(path + "\\" + dir.ToString());

                            IOManager.TraverseDirectory(path + "\\" + dir.ToString());
                        }

                    }
                }
            }
            
        }
    }
}

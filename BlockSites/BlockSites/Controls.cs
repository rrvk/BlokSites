using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlokSites
{
    class Controls
    {
        public void blockSite(String site)
        {
            using (StreamWriter w = File.AppendText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts")))
            {
                w.WriteLine();
                w.WriteLine("127.0.0.1 " + site);
            }
        }

        /**
         * String site -> dat is de site die word geblokeerd
         * Boolean empty -> als dat true is worden alle lege lijnen gewist in de host file
         */
        public void deBlockSite(String site, Boolean empty)
        {
            // voor het inlezen
            String line;
            // voor het uitlezen
            ArrayList outPut = new ArrayList();
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts"));
                //Read the first line of text
                line = sr.ReadLine();
                //Continue to read until you reach end of file
                while (line != null)
                {
                    if (empty)
                    {
                        if (!line.Equals(""))
                        {
                            if (!line.Equals("127.0.0.1 " + site))
                            {
                                outPut.Add(line);
                            }
                        }
                    }
                    else{
                        if (!line.Equals("127.0.0.1 " + site))
                        {
                            outPut.Add(line);
                        }
                    }
                    line = sr.ReadLine();
                }
                //close the file
                sr.Close();
                // Write the string to a file.
                System.IO.StreamWriter file = new System.IO.StreamWriter(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "drivers/etc/hosts"));
                foreach(String outL in outPut){
                    file.WriteLine(outL);
                }
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}

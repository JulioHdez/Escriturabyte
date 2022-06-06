using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace EscrituraByte
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = null;
            byte[] buffer = new byte[81];


            //Variable
            int nbytes = 0, car;


            try
            {
                //file stream se usa cuando necesitemos utilizar bytes, se puede utilizar junto al filewriter 

                //crear el flujo

                //crear fs, como crear una instancia
                //                                  crear               tipo
                fs = new FileStream("text.txt" , FileMode.Create , FileAccess.Write);

                Console.WriteLine("Escriba el texto que desea almacenar en el archivo: ");

                //Recolecta de escritura               
                while ((car = Console.Read()) != '\r' && (nbytes <buffer.Length))
                {
                    buffer[nbytes] = (byte)car;
                    nbytes++;
                }

                fs.Write(buffer, 0 , nbytes);
            }

            catch(IOException e)
            {
                Console.Error.WriteLine(e.Message);
            }

            finally
            {
                //Por si algo sale mal
                if (fs != null) fs.Close();
            }
        }
    }
}

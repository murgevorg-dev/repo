// See https://aka.ms/new-console-template for more information
using System.IO;
using System.Text;
string key = "key";
string path = "C:\\Users\\user\\Desktop\\myfile.txt";
if (!File.Exists(path))
{
    Console.WriteLine("File  does not exist");
}
else
{ 
    FileStream fs = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.None);
    
    BinaryReader reader = new BinaryReader(fs);

    byte[] data = reader.ReadBytes((int)fs.Length);

    foreach (byte b in data)
    {
      
        string binary = Convert.ToString(b, 2).PadLeft(8, '0');
        foreach (char c in binary)
        {
           
            Console.WriteLine(c);
        }
        
            //Console.Write(binary + " ");
    }
    

}


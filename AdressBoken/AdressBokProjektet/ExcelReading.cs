using System.IO;

namespace AdressBokProjektet
{
    public class ExcelReading
    {
        public string ReadData(string reader)
        {
            var filePath = @"C:\Users\martinl\Desktop\Kodprojekt\Adressapp\AdressbookData.xlsx";
            var lines = File.ReadAllLines(filePath);

            foreach (var line in lines)
            {
                reader += line;
            }

            return reader;
        }
        

    }
}

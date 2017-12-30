using ExcelLibrary.SpreadSheet;

namespace AdressBokProjektet
{
    public class ExcelWriting : Form1
    {
        Persons person1 = new Persons();
        Form1 formen = new Form1();
        public void WriteData()
        {
            string file = @"C:\Users\martinl\source\repos\AdressBoken\newdoc.xls";
            Workbook workbook = new Workbook();
            Worksheet worksheet = new Worksheet("First Sheet");
            worksheet.Cells[0, 0] = new Cell(formen);
            worksheet.Cells[0, 1] = new Cell(person1.LastName);
            worksheet.Cells[0, 2] = new Cell(person1.Adress);
            worksheet.Cells.ColumnWidth[0, 1] = 3000;
            workbook.Worksheets.Add(worksheet);
            workbook.Save(file);

            Workbook book = Workbook.Load(file); Worksheet sheet = book.Worksheets[0];

            for (int rowIndex = sheet.Cells.FirstRowIndex; rowIndex <= sheet.Cells.LastRowIndex; rowIndex++)
            {
                Row row = sheet.Cells.GetRow(rowIndex);
                for (int colIndex = row.FirstColIndex; colIndex <= row.LastColIndex; colIndex++)
                {
                    Cell cell = row.GetCell(colIndex);
                }
            }

        }

    }
}

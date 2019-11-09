using ExcelDataReader;

using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject
{

    public class Datacollection
    {
        public int rowNumber { get; set; }
        public string colName { get; set; }
        public string colValue { get; set; }
    }


    class ExcelLib
    {
        //    ArrayList dataCol = new ArrayList();

        //    public void PopulateInCollection(string fileName)
        //    {
        //        DataTable table = ExcelToDataTable(fileName);

        //        //Iterate through the rows and columns of the Table
        //        for (int row = 1; row <= table.Rows.Count; row++)
        //        {
        //            for (int col = 0; col <= table.Columns.Count; col++)
        //            {
        //                Datacollection dtTable = new Datacollection()
        //                {
        //                    rowNumber = row,
        //                    colName = table.Columns[col].ColumnName,
        //                    colValue = table.Rows[row - 1][col].ToString()
        //                };
        //                //Add all the details for each row
        //                dataCol.Add(dtTable);
        //            }
        //        }
        //    }
        //public static DataTable ExcelToDataTable(string fileName)
        //{
        //    //open file and returns as Stream
        //    FileStream stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
        //    //Createopenxmlreader via ExcelReaderFactory
        //    IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream); //.xlsx
        //                                                                                   //Set the First Row as Column Name
        //                                                                                   //  excelReader.IsFirstRowAsColumnNames = true;
        //                                                                                   //Return as DataSet
        //                                                                                   // DataSet result = excelReader.AsDataSet();
        //                                                                                   //Get all the Tables
        //   // DataTableCollection table = result.Tables;
        //    //Store it in DataTable
        //    //DataTable resultTable = table["Sheet1"];

        //    //return
        //   // return resultTable;
        //}
    }
}

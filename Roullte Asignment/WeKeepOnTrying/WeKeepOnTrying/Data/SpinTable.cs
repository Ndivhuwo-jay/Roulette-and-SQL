using System.Data;
using WeKeepOnTrying.Models;

namespace WeKeepOnTrying.DataBAse
{
    public class SpinTable
    {
        
        public void CreateSpinTable(SpinModel spinModel)
        {
            DataTable spinTable = new DataTable("SpinTable");
            DataColumn dataColumn;
            DataRow dataRow;

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(Int32);
            dataColumn.ColumnName = "Id";
            dataColumn.Caption = "Spin_Id";
            dataColumn.ReadOnly = false;
            dataColumn.Unique = true;
            dataColumn.AutoIncrement = true;
            dataColumn.AutoIncrementSeed = 1;
            dataColumn.AutoIncrementStep = 1;
            spinTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(int);
            dataColumn.ColumnName = "Value";
            dataColumn.Caption = "Spin_Value";
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            spinTable.Columns.Add(dataColumn);


            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(string);
            dataColumn.ColumnName = "Number_Type";
            dataColumn.Caption = "Spin_Number_Type";
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            spinTable.Columns.Add(dataColumn);

            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(bool);
            dataColumn.ColumnName = "EvenOrOdd";
            dataColumn.Caption = "Spin_EvenOrOdd";
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            spinTable.Columns.Add(dataColumn);


            dataColumn = new DataColumn();
            dataColumn.DataType = typeof(string);
            dataColumn.ColumnName = "Color";
            dataColumn.Caption = "Spin_Color";
            dataColumn.ReadOnly = false;
            dataColumn.Unique = false;
            spinTable.Columns.Add(dataColumn);

            DataColumn[] PrimaryKeyColumns = new DataColumn[1];
            PrimaryKeyColumns[0] = spinTable.Columns["Id"];
            spinTable.PrimaryKey = PrimaryKeyColumns;

            var dataset = new DataSet();
            dataset.Tables.Add(spinTable);

            dataRow = spinTable.NewRow();
            dataRow["Value"] = spinModel.getValue;
            dataRow["Color"] = spinModel.getColor;
            dataRow["EvenOrOdd"] = spinModel.getisEven;
            dataRow["Number_Type"] = spinModel.numbertpe;
            spinTable.Rows.Add(dataRow);

            string Createsql = " CREATE TABLE Spin_Table( Id INTEGER PRIMARY KEY AUTOINCREMENT,value INTEGER NOT NULL,Color text NOT NULL,Numbertpe text NOT NULL,EvenOrOdd text NOT NULL)";


        }


    }

    
}

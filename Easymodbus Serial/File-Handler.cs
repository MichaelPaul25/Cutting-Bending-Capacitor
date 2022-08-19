using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Windows.Forms;
using System.IO;
using Easymodbus_Serial.Properties;

namespace Easymodbus_Serial
{
    class File_Handler
    {
        public static void SaveProduct(string _product_name, int[] _value)
        {
            if (_product_name == string.Empty)
            {
                MessageBox.Show("Please Fill Product Name");
                return;
            }
            try
            {
                string filename = _product_name + ".ini";
                string path = Application.StartupPath + "/Product/" + filename;
                StreamWriter sw = new StreamWriter(path);
                for (int i = 0; i < _value.Length; i++)
                {
                    sw.WriteLine(_value[i]);
                }
                
                sw.Close();

                Settings.Default.vision_roi_x = _value[0];
                Settings.Default.vision_roi_y = _value[1];
                Settings.Default.vision_roi_w = _value[2];
                Settings.Default.vision_roi_h = _value[3];
                Settings.Default.vision_filter_min = _value[4];
                Settings.Default.vision_filter_max = _value[5];
                Settings.Default.vision_area = _value[6];
                Settings.Default.Save();
                //MessageBox.Show("Save Successfully");
            }
            catch (Exception e)
            {

            }
        }

        public static string[] PopulateProduct()
        {
            string[] _results = new string[1];
            string paths = Application.StartupPath + "/Product/";
            if (Directory.Exists(paths))
            {
                try
                {
                    string[] files = Directory.GetFiles(paths, "*.ini");
                    string[] _result = new string[files.Length];
                    for (int i = 0; i < files.Length; i++)
                    {
                        _result[i] = Path.GetFileNameWithoutExtension(files[i]);
                    }
                    return _result;
                }
                catch (Exception ex)
                {
                    return _results;
                }
            }
            else
            {
                return _results;
            }

        }

        public static void SaveToCSV(DataGridView DGV, string _product_name)
        {
            string filename = _product_name + ".csv";
            string path = Application.StartupPath + "/Product/" + filename;
            try
            {
                //MessageBox.Show("Data will be exported and you will be notified when it is ready.");
                if (File.Exists(filename))
                {
                    try
                    {
                        File.Delete(filename);
                    }
                    catch (IOException ex)
                    {
                        MessageBox.Show("It wasn't possible to write the data to the disk." + ex.Message);
                    }
                }
                int columnCount = DGV.ColumnCount;
                string columnNames = "";
                string[] output = new string[DGV.RowCount + 1];
                for (int i = 0; i < columnCount; i++)
                //for (int i = 0; i < 11; i++)
                {
                    if (i == 2)
                    {
                        columnNames += DGV.Columns[i].Name.ToString();
                    }
                    else
                        columnNames += DGV.Columns[i].Name.ToString() + ",";
                }
                output[0] += columnNames;
                for (int i = 1; (i - 1) < DGV.RowCount - 1; i++)
                {
                    //for (int j = 0; j < 8; j++)
                    for (int j = 0; j < 3; j++)
                    {
                        if (j == 2)
                        {
                            output[i] += DGV.Rows[i - 1].Cells[j].Value.ToString();
                        }
                        else
                            output[i] += DGV.Rows[i - 1].Cells[j].Value.ToString() + ",";

                    }
                }
                System.IO.File.WriteAllLines(path, output, System.Text.Encoding.UTF8);
                MessageBox.Show("Save Successfully");
            }
            catch 
            {
                return;
            }

        }

        public static void LoadcsvData(string _product_name, DataGridView dtGrid, DataTable dtTable, int _indexRow)
        {
            try
            {
                dtGrid.Columns.Clear();
                dtGrid.DataSource = null;
                dtTable.Rows.Clear();
                dtTable.Columns.Clear();

                string filename = _product_name + ".csv";
                string filePath = Application.StartupPath + "/Product/" + filename;

                string[] lines;
                lines = System.IO.File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    //first line to create header
                    string firstLine = lines[0];
                    string[] headerLabels = new string[5];
                    headerLabels = firstLine.Split(',');

                    foreach (string headerWord in headerLabels)
                    {
                        dtTable.Columns.Add(new DataColumn(headerWord));
                    }

                    //And then Data
                    for (int i = 1; i < lines.Length - 1; i++)
                    {
                        String[] dataWords = new String[5];
                        dataWords = lines[i].Split(',');
                        DataRow dr = dtTable.NewRow();
                        int columnIndex = 0;
                        foreach (String headerWord in headerLabels)
                        {
                            dr[headerWord] = dataWords[columnIndex++];
                        }
                        dtTable.Rows.Add(dr);
                    }
                    headerLabels = Array.Empty<string>();
                }
                if (dtTable.Rows.Count > 0)
                {
                    dtGrid.DataSource = dtTable;
                }
                _indexRow = lines.Length - 1;
            }
            catch 
            { return; }
        }

        public static int[] LoadProduct(string _product_name)
        {
            int[] _results = new int[1];
            string filename = _product_name + ".ini";
            string path = Application.StartupPath + "/Product/" + filename;
            try
            {
                string[] lines = File.ReadAllLines(path);
                Settings.Default.vision_roi_x = Convert.ToInt32(lines[0]);
                Settings.Default.vision_roi_y = Convert.ToInt32(lines[1]);
                Settings.Default.vision_roi_w = Convert.ToInt32(lines[2]);
                Settings.Default.vision_roi_h = Convert.ToInt32(lines[3]);
                Settings.Default.vision_filter_min = Convert.ToInt32(lines[4]);
                Settings.Default.vision_filter_max = Convert.ToInt32(lines[5]);
                Settings.Default.vision_area = Convert.ToInt32(lines[6]);


                int[] _result = new int[lines.Length];

                for (int i = 0; i < _result.Length; i++)
                {
                    _result[i] = Convert.ToInt32(lines[i]);
                }

                return _result;
            }
            catch (Exception ex)
            {
                return _results;
            }
        }

    }
}

using System;
using System.Data;
using System.Windows.Forms;
using System.IO;
using ClosedXML.Excel;
using System.Drawing;

namespace CafeManagement.Utils
{
    public class exportExcel
    {
        public void Export(System.Data.DataTable dt, string sheetName)
        {
            if (dt == null || dt.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel Files|*.xlsx",
                    Title = "Save Excel File",
                    FileName = $"{sheetName}_{DateTime.Now:yyyyMMdd_HHmmss}.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (var workbook = new XLWorkbook())
                    {
                        var worksheet = workbook.Worksheets.Add(sheetName);

                        // Export headers
                        for (int i = 0; i < dt.Columns.Count; i++)
                        {
                            worksheet.Cell(1, i + 1).SetValue(dt.Columns[i].ColumnName);
                        }

                        // Export data
                        for (int i = 0; i < dt.Rows.Count; i++)
                        {
                            for (int j = 0; j < dt.Columns.Count; j++)
                            {
                                var value = dt.Rows[i][j];
                                var cell = worksheet.Cell(i + 2, j + 1);

                                // Handle null values
                                if (value == null || value == DBNull.Value)
                                {
                                    cell.SetValue(string.Empty);
                                    continue;
                                }

                                // Handle different data types
                                if (value is decimal decimalValue)
                                {
                                    cell.SetValue(decimalValue);
                                }
                                else if (value is double doubleValue)
                                {
                                    cell.SetValue(doubleValue);
                                }
                                else if (value is float floatValue)
                                {
                                    cell.SetValue(floatValue);
                                }
                                else if (value is DateTime dateValue)
                                {
                                    cell.SetValue(dateValue);
                                }
                                else
                                {
                                    cell.SetValue(value.ToString());
                                }

                                // Format numbers and dates
                                if (value is decimal || value is double || value is float)
                                {
                                    cell.Style.NumberFormat.Format = "#,##0";
                                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Right;
                                }
                                else if (value is DateTime)
                                {
                                    cell.Style.NumberFormat.Format = "dd/MM/yyyy";
                                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                                }
                                else
                                {
                                    cell.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Left;
                                }
                            }
                        }

                        // Format header
                        var headerRange = worksheet.Range(1, 1, 1, dt.Columns.Count);
                        headerRange.Style.Font.Bold = true;
                        headerRange.Style.Fill.BackgroundColor = XLColor.LightGray;
                        headerRange.Style.Border.OutsideBorder = XLBorderStyleValues.Medium;
                        headerRange.Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                        headerRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        // Format data
                        var dataRange = worksheet.Range(1, 1, dt.Rows.Count + 1, dt.Columns.Count);
                        dataRange.Style.Border.OutsideBorder = XLBorderStyleValues.Thin;
                        dataRange.Style.Border.InsideBorder = XLBorderStyleValues.Thin;
                        dataRange.Style.Alignment.Vertical = XLAlignmentVerticalValues.Center;

                        // Auto-fit columns
                        worksheet.Columns().AdjustToContents();

                        // Save the file
                        workbook.SaveAs(saveFileDialog.FileName);
                        MessageBox.Show("Xuất file Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Có lỗi khi xuất file Excel: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
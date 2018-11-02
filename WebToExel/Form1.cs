using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace WebToExel
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void textBox_web_TextChanged(object sender, EventArgs e)
    {

    }

    private void BindGrid(List<Currency> list)
    {
      dataGridView1.DataSource = new BindingSource(new BindingList<Currency>(list),null);
      dataGridView1.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
      dataGridView1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
      dataGridView1.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
    }

    private void button_Scrap_Click(object sender, EventArgs e)
    {
      if (!System.Uri.IsWellFormedUriString(textBox_web.Text, UriKind.Absolute))
      {
        MessageBox.Show("URL error.");
        this.ActiveControl = textBox_web;
      }
      else
      {
        BindGrid(new ScrapWeb(textBox_web.Text).table);
        this.ActiveControl = button_ToExel;
      }
    }

    private void button_ToExel_Click(object sender, EventArgs e)
    {
    var xlApp=new Excel.Application();

      xlApp.Workbooks.Add();
      var xlSheet = xlApp.ActiveSheet as Excel.Worksheet;
      xlApp.Visible = true;
      xlSheet.Cells[1, "A"] = "Kodas";
      xlSheet.Cells[1, "B"] = "Valiuta";
      xlSheet.Cells[1, "C"] = "Kodas";
      
      for (int i = 0; i < dataGridView1.Rows.Count; i++)
      {
        xlSheet.Cells[i + 2,"A"] = dataGridView1.Rows[i].Cells[0].Value.ToString();
        xlSheet.Cells[i + 2,"B"] = dataGridView1.Rows[i].Cells[1].Value.ToString();
        xlSheet.Cells[i + 2,"C"] = dataGridView1.Rows[i].Cells[2].Value.ToString();
      }

      xlSheet.Range["A1", "C"+(dataGridView1.Rows.Count+1)].AutoFormat(Format:
        Excel.XlRangeAutoFormat.xlRangeAutoFormatColor2);
    }
  }
}

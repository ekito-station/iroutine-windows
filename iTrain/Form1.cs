using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iTrain
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddButtonClicked(object sender, EventArgs e)
        {
            scoreDataSet.scoreDataTable.AddscoreDataTableRow(
                DateTime.Parse(this.date.Text),
                int.Parse(this.sitUp.Text),
                int.Parse(this.backExtension.Text),
                int.Parse(this.pushUp.Text),
                int.Parse(this.shuttleRun.Text)
            );
        }

        private void RemoveButtonClicked(object sender, EventArgs e)
        {
            int row = this.scoreDataGrid.CurrentRow.Index;
            this.scoreDataGrid.Rows.RemoveAt(row);
        }

        private void FormShown(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            string day = dt.ToString("yyyy/MM/dd");
            this.date.Text = day;

            scoreDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

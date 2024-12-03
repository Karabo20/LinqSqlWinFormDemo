using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
`
namespace LinqSqlWinFormDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DataClasses1DataContext data = new DataClasses1DataContext();
            var results = from workers in data.Peoples
                          where workers.Name == "Donald"
                          select workers;


            dataGridView1.DataSource = results;
        }
    }
}

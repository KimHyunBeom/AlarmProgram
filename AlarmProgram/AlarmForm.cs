using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlarmProgram
{
    public partial class AlarmForm : Form
    {
        public AlarmForm()
        {
            InitializeComponent();

            var dataSource = new string[] { "오전", "오후" };
            comboBox1.DataSource = dataSource;
        }
    }
}

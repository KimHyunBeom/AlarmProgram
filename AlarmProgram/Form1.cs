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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //메뉴 알람 관리 항목의 알람 추가 버튼 클릭 시
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            new AlarmForm().ShowDialog();
        }
        //메뉴 일정 관리 항목의 일정 추가 버튼 클릭시
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            new ScheduleForm().ShowDialog();
        }
    }
}

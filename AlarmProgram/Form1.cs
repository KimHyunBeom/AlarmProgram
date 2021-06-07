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

            //속성
            DataTable dt1 = new DataTable();
            dt1.Columns.Add("일정 이름");
            dt1.Columns.Add("시작일");
            dt1.Columns.Add("종료일");
            dt1.Columns.Add("남은 시간");
            //열 선언
            DataRow dr1 = dt1.NewRow();
            //dt.Rows.Add(dr);

            dt1.AcceptChanges();

            this.dataGridView1.DataSource = dt1;

            //속성
            DataTable dt2 = new DataTable();
            dt2.Columns.Add("알람 이름");
            dt2.Columns.Add("알람 시간");
            dt2.Columns.Add("남은 시간");
            //열 선언
            DataRow dr2 = dt1.NewRow();
            //dt.Rows.Add(dr);

            dt2.AcceptChanges();

            this.dataGridView2.DataSource = dt2;
        }

        private void ScheduleDataTable()
        {
            /*
            DataTable dt = new DataTable();
            dt.Columns.Add("일정 이름");
            dt.Columns.Add("시작일");
            dt.Columns.Add("종료일");
            dt.Columns.Add("남은 시간");

            DataRow dr = dt.NewRow();
            dt.Rows.Add(dr);

            dt.AcceptChanges();

            this.dataGridView1.DataSource = dt;
            */
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

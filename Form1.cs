using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            doSom();
        }
        public void doSom()
        {
            DataGridViewTextBoxColumn column0 = new DataGridViewTextBoxColumn();
            column0.Name = "Num";
            column0.HeaderText = "№";

            DataGridViewTextBoxColumn column1 = new DataGridViewTextBoxColumn();
            column1.Name = "A";
            column1.HeaderText = "A1";

            DataGridViewTextBoxColumn column2 = new DataGridViewTextBoxColumn();
            column2.Name = "B";
            column2.HeaderText = "B1";

            DataGridViewTextBoxColumn column3 = new DataGridViewTextBoxColumn();
            column3.Name = "C";
            column3.HeaderText = "C1";

            Table1.Columns.AddRange(column0,column1,column2,column3);

            DataGridViewCell Num = new DataGridViewTextBoxCell();
            DataGridViewCell A = new DataGridViewTextBoxCell();
            DataGridViewCell B = new DataGridViewTextBoxCell();
            DataGridViewCell C = new DataGridViewTextBoxCell();

            Num.Value = "Here ";
            A.Value = "will";
            B.Value = "be";
            C.Value = "realized";

            DataGridViewRow row0 = new DataGridViewRow();
            row0.Cells.AddRange(Num, A , B , C);
            //Table1.Rows.Add(row0);

            DataGridViewCell Num0 = new DataGridViewTextBoxCell();
            DataGridViewCell A0 = new DataGridViewTextBoxCell();
            DataGridViewCell B0 = new DataGridViewTextBoxCell();
            DataGridViewCell C0 = new DataGridViewTextBoxCell();

            Num.Value = "opportunity";
            A.Value = "to input";
            B.Value = "values wich";
            C.Value = "you will input from buttons in program";

            DataGridViewRow row1 = new DataGridViewRow();
            row1.Cells.AddRange(Num0, A0, B0, C0);
            Table1.Rows.AddRange(row0 ,row1);

        }
    }
}

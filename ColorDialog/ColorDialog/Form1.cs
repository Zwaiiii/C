using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorDialog {
    public partial class Form1 : Form {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            colorDialog1.ShowDialog(); 
            this.BackColor = colorDialog1.Color;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog(); // 컬러 선택을 위해 색 대화상자 띄움
            button1.BackColor = colorDialog1.Color; // 버튼의 배경 색
            button2.BackColor = colorDialog1.Color;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace speedsheet
{
    public partial class ParamMapForm : Form
    {
        public ParamMapForm(Excel.Range cellRange)
        {
            this.range = cellRange;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //WebRequest request = WebRequest.Create("http://dumbsocket.herokuapp.com");
            string response = "['cool', 'story', 'bro']";

            Excel.Range columnRange = this.range.Columns;
            int cols = columnRange.Count;
            string[] props = JsonConvert.DeserializeObject<string[]>(response);
            for (int i = 1; i <= cols; i++)
            {
                Label new_label = new Label();
                ComboBox new_combo_box = new ComboBox();

                new_label.Text = "Param for Col " + i;
                new_label.Location = new Point(30, new_combo_box.Bottom + (i * 30));
                new_label.AutoSize = true;

                object props_clone = props.Clone();
                new_combo_box.DataSource = props_clone;
                new_combo_box.AutoCompleteSource = AutoCompleteSource.ListItems;
                new_combo_box.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                new_combo_box.Location = new Point(new_label.Width + 12, new_label.Top - 3);

                this.Controls.Add(new_label);
                this.Controls.Add(new_combo_box);

                this.CenterToScreen();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public Excel.Range range { get; set; }

        private void gobtn_click(object sender, EventArgs e)
        {
            this.Close();
            //iterate over range and bind to websocket for selected param.
        }
    }
}

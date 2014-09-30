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
        public ParamMapForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //WebRequest request = WebRequest.Create("http://dumbsocket.herokuapp.com");
            string response = "{props: ['cool', 'story', 'bro']}";
            dynamic resOjb = JsonConvert.DeserializeObject(response);
            Array props = resOjb.props;
            int cols = 5;
            for (int i = cols; i <= 5; i++)
            {
                Label new_label = new Label();
                new_label.Text = "Param for Col #{i}";
                ComboBox new_combo_box = new ComboBox();
                new_combo_box.DataSource = props;
                this.Controls.Add(new_label);
                this.Controls.Add(new_combo_box);
            }
        }
    }
}

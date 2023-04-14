using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace form
{
    public partial class CallAPI : Form
    {
        public CallAPI()
        {
            InitializeComponent();
        }

        private void CallAPI_Load(object sender, EventArgs e)
        {

        }

        private async void GetALL_Click(object sender, EventArgs e)
        {
          var responce = await  RestHelper.GetALL();
            txtResponce.Text = RestHelper.BeautifyJson(responce);
        }

        private async void Post_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.Post(txtName.Text, txtEmail.Text);
            txtResponce.Text = RestHelper.BeautifyJson(responce);
        }

        private async void Get_Click(object sender, EventArgs e)
        {
            var responce = await RestHelper.Get(txtID.Text);
            txtResponce.Text = RestHelper.BeautifyJson(responce);
        }
    }
}

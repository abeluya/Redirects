/*
 * Created by Abraham Oviedo
 * April, 2018
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Redirects
{
    public partial class LoadingForm : Form
    {

        public LoadingForm()
        {
            InitializeComponent();
        }

        public LoadingForm(bool hide, bool browser)
        {
            InitializeComponent();
            this.Enabled = false;
            if (!browser)
            {
                this.lblBrowser.Visible = false;
            }
            else
            {
                this.lblBrowser.Visible = true;
            }

            if (hide)
            {
                this.pgrBar.Visible = false;
            }
            else
            {
                this.pgrBar.Visible = true;
            }
            

        }

    }
}

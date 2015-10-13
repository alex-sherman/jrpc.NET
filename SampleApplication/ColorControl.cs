using jrpc.NET;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleApplication
{
    public partial class ColorControl : Form
    {
        struct LEDColor
        {
            public byte r;
            public byte g;
            public byte b;
            public LEDColor(int r, int g, int b)
            {
                this.r = (byte)r;
                this.g = (byte)g;
                this.b = (byte)b;
            }
        }
        SocketProxy proxy;
        public ColorControl()
        {
            InitializeComponent();
            proxy = new SocketProxy(50001);
            List<string> animations = proxy.call<List<string>>("GetAnimations");
            this.comboBox1.Items.AddRange(animations.ToArray<object>());
            this.trackBar1.Scroll += new System.EventHandler(this.updateColorTrackBar);
            this.trackBar2.Scroll += new System.EventHandler(this.updateColorTrackBar);
            this.trackBar3.Scroll += new System.EventHandler(this.updateColorTrackBar);
            colorRadio_CheckedChanged(null, null);
        }

        private void updateColorTrackBar(object sender, EventArgs e)
        {
            LEDColor color = new LEDColor(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            if (sender == colorRadio)
                proxy.call("LerpRange", JObject.FromObject(color), 0, 23, 100, 5);
            else
                proxy.call("SetRange", JObject.FromObject(color), 0, 23);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
                proxy.call("StopAnimation");
            else
                proxy.call("StartAnimation", comboBox1.SelectedItem);
        }

        private void colorRadio_CheckedChanged(object sender, EventArgs e)
        {
            flatColorBox.Visible = false;
            animationBox.Visible = false;
            if (colorRadio.Checked)
            {
                proxy.call("StopAnimation");
                flatColorBox.Visible = true;
                updateColorTrackBar(sender, null);
            }
            if (animationRadio.Checked)
            {
                comboBox1_SelectedIndexChanged(null, null);
                animationBox.Visible = true;
            }
        }
    }
}

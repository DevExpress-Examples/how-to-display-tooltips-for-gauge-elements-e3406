using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Input;
using DevExpress.Xpf.Gauges;

namespace DXGauges_ShowTooltips {

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }


        private void circularGaugeControl1_MouseMove(object sender, MouseEventArgs e) {
                CircularGaugeHitInfo hitInfo = 
                circularGaugeControl1.CalcHitInfo(e.GetPosition(circularGaugeControl1));

            if (hitInfo.InNeedle) {
                tooltip_text.Text = "Value: " + hitInfo.Needle.Value.ToString("n2");
                tooltip.Placement = PlacementMode.Mouse;

                tooltip.IsOpen = true;
            }
            else {
                tooltip.IsOpen = false;
            }

        }

        private void circularGaugeControl1_MouseLeave(object sender, MouseEventArgs e) {
            tooltip.IsOpen = false;
        }

    }
}

using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Forms;

namespace TestSecondWindow
{
    public static class Extension
    {
        public static void CenterWindowOnScreen(Window w, Screen s)
        {
            double dpiWidthFactor = 1.0;
            double dpiHeightFactor = 1.0;
            try
            {
                System.Windows.Media.Matrix m = PresentationSource.FromVisual(w).CompositionTarget.TransformToDevice;
                dpiWidthFactor = m.M11;
                dpiHeightFactor = m.M22;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex.Message, "Extension.CenterWindowOnScreen");
            }

            w.WindowStartupLocation = System.Windows.WindowStartupLocation.Manual;

            w.Left = s.Bounds.Location.X / dpiWidthFactor;
            w.Top = s.Bounds.Location.Y / dpiHeightFactor;
            w.Width = s.Bounds.Size.Width / dpiWidthFactor;
            w.Height = s.Bounds.Size.Height / dpiHeightFactor;
            w.WindowState = WindowState.Maximized;

        }
    }


}

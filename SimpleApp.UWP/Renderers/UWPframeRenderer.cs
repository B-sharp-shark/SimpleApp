using SimpleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using AHM.UWP.Renderers;
using Windows.UI;

[assembly: ExportRenderer(typeof(RoundedEntry), typeof(UWPframeRenderer))]
namespace AHM.UWP.Renderers
{
    public class UWPframeRenderer:EntryRenderer
    {
        public UWPframeRenderer()
        {
            
        }
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);
            if (Control != null)
            {
                RoundedEntry entry = Element as RoundedEntry;
                Control.BorderThickness = new Windows.UI.Xaml.Thickness(entry.BorderWidth);// new SolidColorBrush(Windows.UI);
            }
        }
    }
}

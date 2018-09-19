using System;

using UIKit;
using XamarinCalculator;

namespace XamarinCalculator.iOS
{
    public partial class ViewController : UIViewController
    {
        string sign = "";


        public ViewController(IntPtr handle) : base(handle)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            // Perform any additional setup after loading the view, typically from a nib.
        }

        partial void Plus_TouchUpInside(UIButton sender)
        {
            sign = "+";
        }



        partial void Minus_TouchUpInside(UIButton sender)
        {
            sign = "-";
        }

        partial void Mul_TouchUpInside(UIButton sender)
        {
            sign = "*";
        }


        partial void Dev_TouchUpInside(UIButton sender)
        {
            sign = "/";
        }

        partial void Res_TouchUpInside(UIButton sender)
        {
            LabelRes.Text = Calc.Calulate(Convert.ToDouble(TextOne.Text), Convert.ToDouble(TextTwo.Text), sign).ToString();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.		
        }
    }
}

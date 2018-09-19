// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace XamarinCalculator.iOS
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        UIKit.UIButton Button { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Dev { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel LabelRes { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Minus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Mul { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton plus { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton Res { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextOne { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UITextField TextTwo { get; set; }

        [Action ("Dev_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Dev_TouchUpInside (UIKit.UIButton sender);

        [Action ("Minus_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Minus_TouchUpInside (UIKit.UIButton sender);

        [Action ("Mul_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Mul_TouchUpInside (UIKit.UIButton sender);

        [Action ("Plus_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Plus_TouchUpInside (UIKit.UIButton sender);

        [Action ("Res_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void Res_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (Dev != null) {
                Dev.Dispose ();
                Dev = null;
            }

            if (LabelRes != null) {
                LabelRes.Dispose ();
                LabelRes = null;
            }

            if (Minus != null) {
                Minus.Dispose ();
                Minus = null;
            }

            if (Mul != null) {
                Mul.Dispose ();
                Mul = null;
            }

            if (plus != null) {
                plus.Dispose ();
                plus = null;
            }

            if (Res != null) {
                Res.Dispose ();
                Res = null;
            }

            if (TextOne != null) {
                TextOne.Dispose ();
                TextOne = null;
            }

            if (TextTwo != null) {
                TextTwo.Dispose ();
                TextTwo = null;
            }
        }
    }
}
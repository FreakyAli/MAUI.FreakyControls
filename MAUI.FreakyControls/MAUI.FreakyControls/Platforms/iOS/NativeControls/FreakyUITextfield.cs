﻿using Foundation;
using Microsoft.Maui.Platform;
using ObjCRuntime;
using UIKit;

namespace Maui.FreakyControls.Platforms.iOS.NativeControls
{
    public class FreakyUITextfield : MauiTextField
    {
        public bool AllowCopyPaste { get; set; } = true;

        public override bool CanPerform(Selector action, NSObject withSender)
        {
            if (action.Name == "paste:" || action.Name == "copy:" || action.Name == "cut:")
                return AllowCopyPaste;
            return base.CanPerform(action, withSender);
        }
    }
}
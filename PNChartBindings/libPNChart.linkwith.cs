using System;
using MonoTouch.ObjCRuntime;

[assembly: LinkWith (
    "libPNChart.a",
    LinkTarget.ArmV7 | LinkTarget.ArmV7s | LinkTarget.Simulator,
    Frameworks = "Foundation,UIKit,CoreGraphics,QuartzCore",
    ForceLoad = true
)]

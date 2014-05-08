using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.CoreAnimation;

namespace PNChart {

    [BaseType (typeof (NSObject))]
    public partial interface PNColor {

        [Export ("imageFromColor:")]
        UIImage ImageFromColor (UIColor color);
    }

    [Model, Protocol, BaseType (typeof (NSObject))]
    public partial interface PNChartDelegate {

        [Export ("userClickedOnLinePoint:lineIndex:")]
        void UserClickedOnLine (PointF point, int lineIndex);

        [Export ("userClickedOnLineKeyPoint:lineIndex:andPointIndex:")]
        void UserClickedOnLinePoint (PointF point, int lineIndex, int pointIndex);

        [Export ("userClickedOnBarCharIndex:")]
        void UserClickedOnBar(int barIndex);
    }

    [BaseType (typeof(UILabel))]
    public partial interface PNChartLabel {

        [Export("initWithFrame:")]
        IntPtr Constructor(RectangleF frame);

    }

    [BaseType (typeof (UIView))]
    public partial interface PNLineChart {

        [Export("initWithFrame:")]
        IntPtr Constructor(RectangleF frame);

        [Export ("strokeChart")]
        void StrokeChart ();

        [Export ("delegate", ArgumentSemantic.Retain)]
        PNChartDelegate Delegate { get; set; }

        [Export ("xLabels", ArgumentSemantic.Retain)]
        string [] XLabels { get; set; }

        [Export ("yLabels", ArgumentSemantic.Retain)]
        string [] YLabels { get; set; }

        [Export ("chartData", ArgumentSemantic.Retain)]
        PNLineChartData [] ChartData { get; set; }

        [Export ("pathPoints", ArgumentSemantic.Retain)]
        NSMutableArray PathPoints { get; set; }

        [Export ("xLabelWidth")]
        float XLabelWidth { get; set; }

        [Export ("yValueMax")]
        float YValueMax { get; set; }

        [Export ("yValueMin")]
        float YValueMin { get; set; }

        [Export ("yLabelNum")]
        int YLabelNum { get; set; }

        [Export ("yLabelHeight")]
        float YLabelHeight { get; set; }

        [Export ("chartCavanHeight")]
        float ChartCavanHeight { get; set; }

        [Export ("chartCavanWidth")]
        float ChartCavanWidth { get; set; }

        [Export ("chartMargin")]
        float ChartMargin { get; set; }

        [Export ("showLabel")]
        bool ShowLabel { get; set; }
    }

    public delegate PNLineChartDataItem LCLineChartDataGetter(uint item);

    [BaseType (typeof (NSObject))]
    public partial interface PNLineChartData {

        [Export ("color", ArgumentSemantic.Retain)]
        UIColor Color { get; set; }

        [Export ("itemCount")]
        uint ItemCount { get; set; }

        [Export ("getData", ArgumentSemantic.Copy)]
        LCLineChartDataGetter GetData { get; set; }
    }

    [BaseType (typeof (NSObject))]
    public partial interface PNLineChartDataItem {

        [Export ("y")]
        float Y { get; }

        [Static, Export ("dataItemWithY:")]
        PNLineChartDataItem DataItemWithY (float y);
    }

    [BaseType (typeof (UIView))]
    public partial interface PNBar {

        [Export ("initWithFrame:")]
        IntPtr Constructor(RectangleF frame);

        [Export ("rollBack")]
        void RollBack();

        [Export ("grade")]
        float Grade { get; set; }

        [Export ("chartLine")]
        CAShapeLayer ChartLine { get; set; }

        [Export ("barColor")]
        UIColor BarColor { get; set; }

        [Export ("barRadius")]
        float BarRadius { get; set; }

    }

    public delegate NSString PNyLabelFromatter (float yLabelValue);

    [BaseType (typeof (UIView))]
    public partial interface PNBarChart {

        [Export ("initWithFrame:")]
        IntPtr Constructor(RectangleF frame);

        [Export ("strokeChart")]
        void StrokeChart ();

        [Export ("xLabels", ArgumentSemantic.Retain)]
        string [] XLabels { get; set; }

        [Export ("yLabels", ArgumentSemantic.Retain)]
        string [] YLabels { get; set; }

        [Export ("yValues", ArgumentSemantic.Retain)]
        NSNumber [] YValues { get; set; }

        [Export ("xLabelWidth")]
        float XLabelWidth { get; set; }

        [Export ("yValueMax")]
        int YValueMax { get; set; }

        [Export ("strokeColor", ArgumentSemantic.Retain)]
        UIColor StrokeColor { get; set; }

        [Export ("strokeColors", ArgumentSemantic.Retain)]
        UIColor [] StrokeColors { get; set; }

        [Export ("yChartLabelWidth")]
        float YChartLabelWidth { get; set; }

        [Export ("yLabelFormatter", ArgumentSemantic.Copy)]
        PNyLabelFromatter YLabelFormatter { get; set; }

        [Export ("chartMargin")]
        float ChartMargin { get; set; }

        [Export ("showLabel")]
        bool ShowLabel { get; set; }

        [Export ("showChartBorder")]
        bool ShowChartBorder { get; set; }

        [Export ("chartBottomLine")]
        CAShapeLayer ChartBottomLine { get; set; }

        [Export ("chartLeftLine")]
        CAShapeLayer ChartLeftLine { get; set; }

        [Export ("barRadius")]
        float BarRadius { get; set; }

        [Export ("barWidth")]
        float BarWidth { get; set; }

        [Export ("labelMarginTop")]
        float LabelMarginTop { get; set; }

        [Export ("barBackgroundColor", ArgumentSemantic.Retain)]
        UIColor BarBackgroundColor { get; set; }

        [Export ("labelTextColor")]
        UIColor LabelTextColor { get; set; }

        [Export ("labelFont")]
        UIFont LabelFont { get; set; }

        [Export ("xLabelSkip")]
        int XLabelSkip { get; set; }

        [Export ("yLabelSum")]
        int YLabelSum { get; set; }

        [Export ("yMaxValue")]
        float YMaxValue { get; set; }

        [Export ("delegate", ArgumentSemantic.Retain)]
        PNChartDelegate Delegate { get; set; }
    }

    [BaseType (typeof (UIView))]
    public partial interface PNCircleChart {

        [Export ("strokeChart")]
        void StrokeChart ();

        [Export ("initWithFrame:andTotal:andCurrent:andClockwise:andShadow:")]
        IntPtr Constructor (RectangleF frame, NSNumber total, NSNumber current, bool clockwise, bool hasBackgroundShadow);

        [Export ("strokeColor", ArgumentSemantic.Retain)]
        UIColor StrokeColor { get; set; }

        [Export ("labelColor", ArgumentSemantic.Retain)]
        UIColor LabelColor { get; set; }

        [Export ("total", ArgumentSemantic.Retain)]
        NSNumber Total { get; set; }

        [Export ("current", ArgumentSemantic.Retain)]
        NSNumber Current { get; set; }

        [Export ("lineWidth", ArgumentSemantic.Retain)]
        NSNumber LineWidth { get; set; }

        [Export ("clockwise")]
        bool Clockwise { get; set; }

        [Export ("circle", ArgumentSemantic.Retain)]
        CAShapeLayer Circle { get; set; }

        [Export ("circleBG", ArgumentSemantic.Retain)]
        CAShapeLayer CircleBG { get; set; }
    }

    [BaseType (typeof (NSObject))]
    public partial interface PNPieChartDataItem {

        [Static, Export ("dataItemWithValue:color:")]
        PNPieChartDataItem From(float value, UIColor color);

        [Static, Export ("dataItemWithValue:color:description:")]
        PNPieChartDataItem From(float value, UIColor color, string description);

        [Export ("value")]
        float Value { get; }

        [Export ("color")]
        UIColor Color { get; }

        [Export ("description")]
        string DataDescription { get; }
    }

    [BaseType (typeof (UIView))]
    public partial interface PNPieChart {

        [Export ("initWithFrame:items:")]
        IntPtr Constructor(RectangleF frame, PNPieChartDataItem[] items);

        [Export ("items")]
        PNPieChartDataItem[] Items { get; }

        [Export ("descriptionTextFont")]
        UIFont DescriptionTextFont { get; set; }

        [Export ("descriptionTextColor")]
        UIColor DescriptionTextColor { get; set; }

        [Export ("descriptionTextShadowColor")]
        UIColor DescriptionTextShadowColor { get; set; }

        [Export ("descriptionTextShadowOffset")]
        SizeF DescriptionTextShadowOffset { get; set; }

        [Export ("duration")]
        double Duration { get; set; }

        [Export ("strokeChart")]
        void StrokeChart ();
    }
}


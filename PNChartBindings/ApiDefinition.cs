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
        void LineIndex (PointF point, int lineIndex);

        [Export ("userClickedOnLineKeyPoint:lineIndex:andPointIndex:")]
        void LineIndex (PointF point, int lineIndex, int pointIndex);
    }

    [BaseType (typeof (UIView))]
    public partial interface PNLineChart {

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
    public partial interface PNBarChart {

        [Export ("strokeChart")]
        void StrokeChart ();

        [Export ("xLabels", ArgumentSemantic.Retain)]
        string [] XLabels { get; set; }

        [Export ("yLabels", ArgumentSemantic.Retain)]
        string [] YLabels { get; set; }

        [Export ("yValues", ArgumentSemantic.Retain)]
        float [] YValues { get; set; }

        [Export ("xLabelWidth")]
        float XLabelWidth { get; set; }

        [Export ("yValueMax")]
        int YValueMax { get; set; }

        [Export ("strokeColor", ArgumentSemantic.Retain)]
        UIColor StrokeColor { get; set; }

        [Export ("strokeColors", ArgumentSemantic.Retain)]
        PNColor [] StrokeColors { get; set; }

        [Export ("barBackgroundColor", ArgumentSemantic.Retain)]
        UIColor BarBackgroundColor { get; set; }

        [Export ("showLabel")]
        bool ShowLabel { get; set; }
    }

    [BaseType (typeof (UIView))]
    public partial interface PNCircleChart {

        [Export ("strokeChart")]
        void StrokeChart ();

        [Export ("initWithFrame:andTotal:andCurrent:andClockwise:")]
        IntPtr Constructor (RectangleF frame, NSNumber total, NSNumber current, bool clockwise);

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

    public delegate PNLineChartDataItem LCLineChartDataGetter(uint item);
}


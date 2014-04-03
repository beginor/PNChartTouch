using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using PNChart;
using System.Drawing;

namespace PNChartDemos {

    public partial class DemoViewController : UIViewController {

        public DemoViewController(IntPtr handle) : base(handle) {
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender) {
            var viewController = segue.DestinationViewController;
            if (segue.Identifier == "LineChart") {
                viewController.Title = "Line Chart Demo";
                // init a new line chart instance
                var lineChart = new PNLineChart(new RectangleF(0, 135, 320, 200)) {
                    BackgroundColor = UIColor.Clear,
                };
                // set x labels
                lineChart.XLabels = new [] { @"SEP 1",@"SEP 2",@"SEP 3",@"SEP 4",@"SEP 5",@"SEP 6",@"SEP 7" };
                // init first line data
                var data01Arrr = new [] { 60.1f, 160.1f, 126.4f, 262.2f, 186.2f, 127.2f, 176.2f };
                var data01 = new PNLineChartData();
                data01.Color = PNColor.Grey;
                data01.ItemCount = (uint)lineChart.XLabels.Length;
                data01.GetData = index =>  PNLineChartDataItem.DataItemWithY(data01Arrr[index]);
                // init second line data.
                var data02Arrr = new [] { 20.1f, 180.1f, 26.4f, 202.2f, 126.2f, 167.2f, 276.2f };
                var data02 = new PNLineChartData();
                data02.Color = PNColor.LightBlue;
                data02.ItemCount = (uint)lineChart.XLabels.Length;
                data02.GetData = index =>  PNLineChartDataItem.DataItemWithY(data02Arrr[index]);
                // set chart data
                lineChart.ChartData = new [] { data01, data02 };
                // stroke chart
                lineChart.StrokeChart();
                // add to destination view controller
                viewController.View.AddSubview(lineChart);
            }
            if (segue.Identifier == "BarChart") {
                viewController.Title = "Bar Chart Demo";
                // init a new bar chart instance
                var barChart = new PNBarChart(new RectangleF(0, 135, 320, 200)) {
                    BackgroundColor = UIColor.Clear
                };

                barChart.XLabels = new [] { @"SEP 1",@"SEP 2",@"SEP 3",@"SEP 4",@"SEP 5",@"SEP 6",@"SEP 7" };
                barChart.YValues = new NSNumber[] { 1, 24, 12, 18, 30, 10, 21 };
                barChart.StrokeColors = new [] { UIColor.Green, UIColor.Green, UIColor.Red, UIColor.Green, UIColor.Green, UIColor.Yellow, UIColor.Green };
                barChart.StrokeChart();

                viewController.View.AddSubview(barChart);
            }
            if (segue.Identifier == "CircleChart") {
                viewController.Title = "Circle Chart Demo";
                var circleChart = new PNCircleChart(new RectangleF(0, 60, 320, 200), NSNumber.FromFloat(100f), NSNumber.FromFloat(60f), true) {
                    BackgroundColor = UIColor.Clear
                };
                circleChart.StrokeColor = UIColor.Green;
                circleChart.StrokeChart();

                viewController.View.AddSubview(circleChart);
            }
            base.PrepareForSegue(segue, sender);
        }
    }

    public class LineChartDelegate : PNChartDelegate {

        public override void UserClicked(PointF point, int lineIndex) {
        }

    }
}

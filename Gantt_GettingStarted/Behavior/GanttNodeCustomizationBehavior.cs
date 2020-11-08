
namespace Gantt_GettingStarted
{
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Interactivity;
    using System.Windows.Media;

    class GanttNodeCustomizationBehavior:Behavior<Border>
    {
        public static Random r = new Random();

        public static string[] nodeColors = new string[]
                                                {
                                                    "#FFFF0094", "#FFA500FF", "#FF00AAAD", "#FF8CBE21", "#FFA55100",
                                                    "#FFE771BD", "#FFF79608", "#FF18A2E7", "#FFE71400", "#FF319A31"
                                                };

        /// <summary>
        /// Called when [attached].
        /// </summary>
        protected override void OnAttached()
        {
            this.AssociatedObject.Loaded += new RoutedEventHandler(AssociatedObject_Loaded);
        }

        /// <summary>
        /// Handles the Loaded event of the AssociatedObject control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.RoutedEventArgs"/> instance containing the event data.</param>
        void AssociatedObject_Loaded(object sender, RoutedEventArgs e)
        {
            var name = ((e.OriginalSource as Border).DataContext as Item).Name;
            Border node = sender as Border;
            if (name == "Design Spec")
            {
                node.Background = (Brush)new BrushConverter().ConvertFromString(nodeColors[0]);
                node.BorderBrush = node.Background;
            }
            else if (name == "Requirement Spec")
            {
                node.Background = (Brush)new BrushConverter().ConvertFromString(nodeColors[1]);
                node.BorderBrush = new SolidColorBrush(Colors.Black); ;
            }
            else if (name == "Defining UI Design")
            {
                node.Background = (Brush)new BrushConverter().ConvertFromString(nodeColors[2]);
                node.BorderBrush = new SolidColorBrush(Colors.Black); ;
            }
            else if (name == "Completing Overall Graphics design")
            {
                node.Background = (Brush)new BrushConverter().ConvertFromString(nodeColors[3]);
                node.BorderBrush = new SolidColorBrush(Colors.Black); ;
            }
            else if (name == "Development Plan")
            {
                node.Background = (Brush)new BrushConverter().ConvertFromString(nodeColors[4]);
                node.BorderBrush = new SolidColorBrush(Colors.Black); ;
            }
            else if (name == "Self Testing")
            {
                node.Background = (Brush)new BrushConverter().ConvertFromString(nodeColors[5]);
                node.BorderBrush = new SolidColorBrush(Colors.Black); ;
            }
            
        }

        /// <summary>
        /// Called when [detaching].
        /// </summary>
        protected override void OnDetaching()
        {
            this.AssociatedObject.Loaded -= new RoutedEventHandler(AssociatedObject_Loaded);
        }
    }
}

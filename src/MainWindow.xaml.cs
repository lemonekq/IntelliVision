using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
namespace IntelliVision
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void NavigationChanged(object sender, RoutedEventArgs e)
        {
            // Neutral: #FF1B1E1E
            // Active: #FF333838

            Button ClickedButton = sender as Button;
            if (ClickedButton != null)
            {
                int ButtonCount = 0;
                foreach (FrameworkElement CurrentElement in navbar_buttons.Children)
                {
                    if (CurrentElement is Button)
                    {
                        ButtonCount++;
                        Button CurrentButton = CurrentElement as Button;
                        CurrentButton.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF1B1E1E");

                        if (CurrentButton == ClickedButton)
                        {
                            switch (ButtonCount)
                            {
                                case 1:
                                    break;
                                case 2:
                                    break;
                            }
                        }
                    }
                }

                ClickedButton.Background = (SolidColorBrush)new BrushConverter().ConvertFrom("#FF333838");
            }
        }
    }
}

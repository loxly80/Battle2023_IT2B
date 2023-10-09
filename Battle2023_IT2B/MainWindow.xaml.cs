using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Battle2023_IT2B
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    Unit hrac1;

    public MainWindow()
    {
      hrac1 = new Unit(500, 10);

      InitializeComponent();
      this.Loaded += MainWindow_Loaded;
      this.SizeChanged += MainWindow_SizeChanged;
    }

    private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
    {
      DrawGame();
    }

    private void MainWindow_Loaded(object sender, RoutedEventArgs e)
    {
      DrawGame();
    }

    private void DrawGame()
    {
      canvas.Children.Clear();
      DrawGround();
      DrawUnit(hrac1);
    }

    private void DrawGround()
    {
      Rectangle rectangle = new Rectangle();
      rectangle.Width = canvas.ActualWidth;
      rectangle.Height = 60;
      rectangle.Fill = Brushes.Green;
      Canvas.SetLeft(rectangle, 0);
      Canvas.SetBottom(rectangle, 0);
      canvas.Children.Add(rectangle);
    }

    private void DrawUnit(Unit unit)
    {
      Image image = new Image();
      image.Height = 100;
      image.Width = 100; 
      image.Source = new BitmapImage(new Uri("Img/archer.png",UriKind.Relative));
      Canvas.SetLeft(image, 20);
      Canvas.SetBottom(image, 25);
      canvas.Children.Add(image);
    }    
  }
}

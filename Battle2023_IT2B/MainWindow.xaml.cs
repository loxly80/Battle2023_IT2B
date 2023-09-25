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
    public MainWindow()
    {
      Unit hrac1 = new Unit(500, 10);

      InitializeComponent();

      DrawUnit(hrac1);
    }

    private void DrawUnit(Unit unit)
    {
      Image image = new Image();
      image.HorizontalAlignment = HorizontalAlignment.Stretch;
      image.VerticalAlignment = VerticalAlignment.Stretch;
      image.Source = GetImage("Img/archer.png");
      Canvas.SetLeft(image, 20);
      Canvas.SetTop(image, 150 );
      canvas.Children.Add(image);
    }

    private BitmapFrame GetImage(string imagePath)
    {
      BitmapFrame bitmap;
      using(FileStream fs = new FileStream(imagePath,FileMode.Open, FileAccess.Read, FileShare.Read))
      {
        bitmap = BitmapFrame.Create(fs);
      }
      return bitmap;
    }
  }
}

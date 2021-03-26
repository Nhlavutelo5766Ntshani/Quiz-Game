using System;
using System.Collections.Generic;
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

namespace quizzGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<int> questionsNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int qNum = 0;
        int i;
        int score;

        public MainWindow()
        {
            InitializeComponent();
            //StartGame();
            //NextQuestion();
        }
        private void StartGame()
        {
            score = 0;
            qNum = -1;
           
        }


        private void RestartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;
            StartGame();
        }

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }
            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }
            scoreText.Content = "Answered Correctly " + score + "/" + questionsNumbers.Count;
            NextQuestion();
        }
        private void NextQuestion()
        {
            if (qNum < questionsNumbers.Count)
            {
                i = questionsNumbers[qNum];
            }
            else
            {
                RestartGame();
            }
            foreach (var x in myCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
                x.Background = Brushes.DarkSalmon;
            }
           switch (i)
            {

                case 1:
                    txtQuestion.Text = "What is the Name of this Mineral?";
                    ans1.Content = "Gypsum";
                    ans2.Content = "Quartz";
                    ans3.Content = "Calcite";
                    ans4.Content = "Sodalite";

                    ans2.Tag = "1";
                   qimage.Source = new BitmapImage(new Uri(@"./images/images1.jpg", UriKind.RelativeOrAbsolute));



                    break;

                case 2:
                    txtQuestion.Text = "What is the Name of this Mineral?";
                    ans1.Content = "Mica";
                    ans2.Content = "Labradorite";
                    ans3.Content = "Magnetite";
                    ans4.Content = "Zincite";

                    ans1.Tag = "1";
                    qimage.Source = new BitmapImage(new Uri(@"./images/images2.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case 3:
                    txtQuestion.Text = "What is the Name of this Mineral?";
                    ans1.Content = "Arsenopyrite";
                    ans2.Content = "Baryte";
                    ans3.Content = "Brookite";
                    ans4.Content = "Emerald";

                    ans3.Tag = "1";
                    qimage.Source = new BitmapImage(new Uri(@"./images/images3.jpg", UriKind.RelativeOrAbsolute));

                    break;

                case 4:
                    txtQuestion.Text = "What is the Name of this Mineral?";
                    ans1.Content = "Emerald";
                    ans2.Content = "Heulandite";
                    ans3.Content = "Inyoite ";
                    ans4.Content = "Kröhnkite";

                    ans4.Tag = "1";
                    qimage.Source = new BitmapImage(new Uri(@"./images/images4.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case 5:
                    txtQuestion.Text = "What is the Name of this Mineral?";
                    ans1.Content = "Langite";
                    ans2.Content = "Legrandite";
                    ans3.Content = "Liddicoatite";
                    ans4.Content = "Magnetite";

                    ans1.Tag = "1";
                    qimage.Source = new BitmapImage(new Uri(@"./images/images5.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case 6:
                    txtQuestion.Text = "What is the Name of this Mineral?";
                    ans1.Content = "Manganite";
                    ans2.Content = "Mimetite";
                    ans3.Content = "Neptunite";
                    ans4.Content = "Pectolite";

                    ans3.Tag = "1";
                    qimage.Source = new BitmapImage(new Uri(@"./images/images6.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case 7:
                    txtQuestion.Text = "What is the Name of this Mineral?";
                    ans1.Content = "Pyrrhotite";
                    ans2.Content = "Quartz ";
                    ans3.Content = "Spinel";
                    ans4.Content = "Tantalite";

                    ans2.Tag = "1";
                    qimage.Source = new BitmapImage(new Uri(@"./images/images7.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case 8:
                    txtQuestion.Text = "What is the Name of this Mineral?";
                    ans1.Content = "Uricite";
                    ans2.Content = "Vaesite";
                    ans3.Content = "Vauquelinite";
                    ans4.Content = "AKeyite";

                    ans4.Tag = "1";
                    qimage.Source = new BitmapImage(new Uri(@"./images/images8.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case 9:
                    txtQuestion.Text = "What is the Name of this Mineral?";
                    ans1.Content = "Amblygonite";
                    ans2.Content = "Bentorite";
                    ans3.Content = "Cleusonite";
                    ans4.Content = "Omphacite";

                    ans3.Tag = "1";
                    qimage.Source = new BitmapImage(new Uri(@"./images/images9.jpg", UriKind.RelativeOrAbsolute));

                    break;
                case 10:
                    txtQuestion.Text = "What is the Name of this Mineral?";
                    ans1.Content = "Orthoclase";
                    ans2.Content = "Pollucite";
                    ans3.Content = "Ultramarine";
                    ans4.Content = "Zoisite";

                    ans1.Tag = "1";
                    qimage.Source = new BitmapImage(new Uri(@"./images/images10.jpg", UriKind.RelativeOrAbsolute));

                    break;
            

            }

        }
    }
}

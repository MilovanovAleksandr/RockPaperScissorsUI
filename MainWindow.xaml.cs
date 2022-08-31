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

namespace RockPaperScissorsUI {
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
        }

        private int victory = 0;
        private int defeat = 0;
        private int draw = 0;

        private int numberFigure;
        private string figure;

        private void GuessingFigure() {
            rockCompLbl.Visibility = Visibility.Hidden;
            scissorsCompLbl.Visibility = Visibility.Hidden;
            paperCompLbl.Visibility = Visibility.Hidden;
            Random rand = new Random(DateTime.Now.Millisecond);
            numberFigure = rand.Next(0, 3);
            switch (numberFigure) {
                case 0:
                figure = "Камень";
                break;

                case 1:
                figure = "Ножницы";
                break;

                case 2:
                figure = "Бумага";
                break;

                default:
                break;
            }
        }

        private void HidingConten() {
            rockUserLbl.Visibility = Visibility.Hidden;
            scissorsUserLbl.Visibility = Visibility.Hidden;
            paperUserLbl.Visibility = Visibility.Hidden;
        }

        private void rockBtn_Click(object sender, RoutedEventArgs e) {
            HidingConten();

            rockUserLbl.Visibility = Visibility.Visible;
            GuessingFigure();
            switch(figure) {
                case "Камень":
                rockCompLbl.Visibility = Visibility.Visible;
                resultTextBlock.Text = "Результат раунда: НИЧЬЯ";
                draw++;
                drawLbl.Content = $"Кол-во ничьих: {draw}";
                break;

                case "Ножницы":
                scissorsCompLbl.Visibility = Visibility.Visible;
                resultTextBlock.Text = "Результат раунда: ВЫ ПОБЕДИЛИ";
                victory++;
                victoryUserLbl.Content = $"Кол-во ваших побед: {victory}";
                break;

                case "Бумага":
                paperCompLbl.Visibility = Visibility.Visible;
                resultTextBlock.Text = "Результат раунда: КОМПЬЮТЕР ПОБЕДИЛ";
                defeat++;
                victoryCompLbl.Content = $"Кол-во побед компьютера: {defeat}";
                break;

                default:
                break;
            }
        }

        private void scissorsBtn_Click(object sender, RoutedEventArgs e) {
            HidingConten();

            scissorsUserLbl.Visibility = Visibility.Visible;
            GuessingFigure();
            switch (figure) {
                case "Камень":
                rockCompLbl.Visibility = Visibility.Visible;
                resultTextBlock.Text = "Результат раунда: КОМПЬЮТЕР ПОБЕДИЛ";
                defeat++;
                victoryCompLbl.Content = $"Кол-во побед компьютера: {defeat}";
                break;

                case "Ножницы":
                scissorsCompLbl.Visibility = Visibility.Visible;
                resultTextBlock.Text = "Результат раунда: НИЧЬЯ";
                draw++;
                drawLbl.Content = $"Кол-во ничьих: {draw}";
                break;

                case "Бумага":
                paperCompLbl.Visibility = Visibility.Visible;
                resultTextBlock.Text = "Результат раунда: ВЫ ПОБЕДИЛИ";
                victory++;
                victoryUserLbl.Content = $"Кол-во ваших побед: {victory}";
                break;

                default:
                break;
            }
        }
    }
}
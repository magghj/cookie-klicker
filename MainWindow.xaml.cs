using System.Windows;

namespace cookie_klicker
{
    public partial class MainWindow : Window
    {
        private Game game = new Game();

        private void add_Click(object sender, RoutedEventArgs e)
        {
            game.click();
            ckResult.Text = game.cookieCount().ToString();
            add.Content = game.cookieAdder().ToString();
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            game.plusClickUpgrade();
            ckResult.Text = game.cookieCount().ToString();
            plus.Content = game.plusAmound().ToString();
            add.Content = game.cookieAdder().ToString();
            plusUpgradeC.Text = game.costOfPlus().ToString();
        }

        private void times_Click(object sender, RoutedEventArgs e)
        {
            game.timesClickUpgrade();
            ckResult.Text = game.cookieCount().ToString();
            times.Content = game.timesAmound().ToString();
            add.Content = game.cookieAdder().ToString();
            timesUpgradeC.Text = game.costOfTimes().ToString();
        }
    }
}
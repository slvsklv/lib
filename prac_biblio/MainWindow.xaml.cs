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
using libex;

namespace prac_biblio
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void WriteToFileButton_Click(object sender, RoutedEventArgs e)
        {
            string text = textInput.Text;
            string filePath = filePathInput.Text;

            try
            {
                sede.Serialize(text, filePath);
                MessageBox.Show("Текст успешно записан в файл.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при записи в файл: {ex.Message}");
            }
        }

        private void ReadFromFileButton_Click(object sender, RoutedEventArgs e)
        {
            string filePath = filePathInput.Text;

            try
            {
                string fileContent = sede.Deserialize<string>(filePath);
                fileContentOutput.Text = fileContent;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при чтении файла: {ex.Message}");
            }
        }
    }
}

using Microsoft.Win32;
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

namespace TextEditor
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _currentFile; private readonly RichTextBox _textBox;
        public MainWindow()
        {
            InitializeComponent(); _textBox = this.body;
        }
        private void New_Click(object sender, RoutedEventArgs e)
        {
            _currentFile = null; _textBox.Document = new FlowDocument();
        }
        private void Open_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog(); dlg.InitialDirectory = @"c:\C#\test\";
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.FilterIndex = 1; dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == true)
            {
                _currentFile = dlg.FileName;
                using (Stream stream = dlg.OpenFile())
                {
                    TextRange range = new
                     TextRange(_textBox.Document.ContentStart, _textBox.Document.ContentEnd);
                    range.Load(stream, DataFormats.Rtf);
                }
            }
        }
        private void Save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(_currentFile))
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.InitialDirectory = @"c:\C#\test\";
                dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                dlg.FilterIndex = 1; dlg.RestoreDirectory = true;
                if (dlg.ShowDialog() == true) _currentFile = dlg.FileName;
            }
            if (!string.IsNullOrEmpty(_currentFile))
            {
                using (Stream stream = new FileStream(_currentFile, FileMode.Create))
                {
                    TextRange range = new
TextRange(_textBox.Document.ContentStart,
_textBox.Document.ContentEnd);
                    range.Save(stream, DataFormats.Rtf);
                }
            }
        }
        private void SaveAs_Click(object sender, RoutedEventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.InitialDirectory = @"c:\C#\test\";
            dlg.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            dlg.FilterIndex = 1; dlg.RestoreDirectory = true;
            if (dlg.ShowDialog() == true)
            {
                _currentFile = dlg.FileName;
                using (Stream stream = new FileStream(_currentFile, FileMode.Create))
                {
                    TextRange range = new
TextRange(_textBox.Document.ContentStart,
           _textBox.Document.ContentEnd);
                    range.Save(stream, DataFormats.Rtf);
                }
            }
        }
        private void Print_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog pd = new PrintDialog();
            if ((pd.ShowDialog() == true))
            {  //可使用以下两个命令中任意一个
                pd.PrintVisual(_textBox as Visual, "printing as visual");
                pd.PrintDocument((((IDocumentPaginatorSource)_textBox.Document).
                         DocumentPaginator), "printing as paginator");
            }
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void About_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("简单的文本编辑器 Version 1.0.0。CopyRight 江红、余青松");
        }

    }
}

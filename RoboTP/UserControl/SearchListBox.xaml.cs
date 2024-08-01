using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media;
using MahApps.Metro.Controls;
using static System.Net.Mime.MediaTypeNames;

namespace RobotTeachPendant.UserControl
{
    /// <summary>
    /// SearchListBox.xaml 的交互逻辑
    /// </summary>
    public partial class SearchListBox : System.Windows.Controls.UserControl
    {
        public SearchListBox()
        {
            InitializeComponent();
        }

        public static readonly DependencyProperty ItemsProperty = DependencyProperty.Register(
            nameof(Items), typeof(IEnumerable<IBaseSearchModel>), typeof(SearchListBox), new PropertyMetadata(default(IEnumerable<IBaseSearchModel>)));

        public IEnumerable<IBaseSearchModel> Items
        {
            get { return (IEnumerable<IBaseSearchModel>) GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }


        public static readonly DependencyProperty SelectedItemProperty = DependencyProperty.Register(
            nameof(SelectedItem), typeof(object), typeof(SearchListBox), new PropertyMetadata(default(object)));

        public object SelectedItem
        {
            get { return (object) GetValue(SelectedItemProperty); }
            set { SetValue(SelectedItemProperty, value); }
        }

        private void TextBoxBase_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            var strings = SearchTextBox.Text.Split(' ');
            foreach (var baseSearchModel in Items)
            {
                baseSearchModel.Visibility= strings.All(s => baseSearchModel.Name.Contains(s)) ? Visibility.Visible : Visibility.Collapsed;
            }
        }
    }


    public interface IBaseSearchModel
    {
        public string Name { get; set; }

        public Visibility Visibility { get; set; }
    }

    public class HighlightService
    {
        const string EndMaker = "$End";

        public static readonly DependencyProperty HighLightTextProperty = DependencyProperty.RegisterAttached(
            "HighLightText", typeof(string), typeof(HighlightService), new PropertyMetadata(default(string), PropertyChangedCallback));

        private static void PropertyChangedCallback(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            if (d is not TextBlock textBlock)
            {
                return;
            }

            if (textBlock == null)
            {
                return;
            }

            if  ( string.IsNullOrWhiteSpace(e.NewValue?.ToString()))
            {
                var textBlockText = textBlock.Text;
                textBlock.Inlines.Clear();
                textBlock.Inlines.Add(new Run(textBlockText));
                return;
            }
            if (textBlock.TryFindParent<ListBoxItem>()?.Visibility!=Visibility.Visible)
            {
                return;
            }
            
             
            MarkHighlight(textBlock, e.NewValue.ToString());
        }

        public static void SetHighLightText(DependencyObject element, string value)
        {
            element.SetValue(HighLightTextProperty, value);
        }

        public static string GetHighLightText(DependencyObject element)
        {
            return (string) element.GetValue(HighLightTextProperty);
        }

        private static void MarkHighlight(TextBlock target, string highlightText)
        {
            if (string.IsNullOrWhiteSpace(highlightText))
            {
                return;
            }

            var text = target.Text;
            if (string.IsNullOrWhiteSpace(text))
            {
                return;
            }

            var strings = highlightText.Split(' ');
            var infos = strings.Select(s => (text.IndexOf(s, StringComparison.Ordinal), s)).OrderBy(tuple => tuple.Item1).Where(tuple => !string.IsNullOrWhiteSpace(tuple.s))
                .ToList();
            var any = infos.Any(tuple => tuple.Item1 == -1);
            if (any)
            {
                return;
            }

            target.Inlines.Clear();
            int lastIndex = 0;
            infos.Add((text.Length, EndMaker));

            foreach (var valueTuple in infos)
            {
                if (lastIndex >= text.Length)
                {
                    break;
                }

                var index = valueTuple.Item1;
                var runText = valueTuple.s;
                if (index == -1)
                {
                    break;
                }

                target.Inlines.Add(new Run(text.Substring(lastIndex, index - lastIndex)));
                if (valueTuple.s != EndMaker)
                {
                    target.Inlines.Add(new Run() {Text = runText, Foreground = Brushes.Red});
                }

                lastIndex = index + runText.Length;
            }
        }
    }
}

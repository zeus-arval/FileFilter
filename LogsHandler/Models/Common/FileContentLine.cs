using System.Windows.Media;

namespace LogsHandler.MVVM
{
    public class FileContentFilteredLine
    {
        public Color ForegroundColor { get; private set; }
        public Color BackgroundColor { get; private set; }
        public string Line { get; }

        public FileContentFilteredLine(string line)
        {
            Line = line;
        }

        public void SetColors(Color foregroundColor, Color backgroundColor)
        {
            ForegroundColor = foregroundColor;
            BackgroundColor = backgroundColor;
        }
    }
}

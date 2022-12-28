namespace FileFilter.Highlights
{
    internal class HighlightModel
    {
        public string Word { get; set; }
        public Color HighlightColor { get; set; }

        public HighlightModel(string word, Color highlightColor)
        {
            Word = word;
            HighlightColor = highlightColor;
        }
    }
}

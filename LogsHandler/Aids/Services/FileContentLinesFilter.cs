using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text.RegularExpressions;
using LogsHandler.Common;
using LogsHandler.MVVM;

namespace LogsHandler.Aids.Services
{
    public class FileContentLinesFilter
    {
        public FileContentLinesFilter(AppOptions options) 
        {
            
        }

        public List<FileContentFilteredLine> Filter(ImmutableArray<string> fileContent, string pattern)
        {
            if (fileContent.Length == 0) return new List<FileContentFilteredLine>();
            if (pattern == string.Empty) return fileContent.Select(x => new FileContentFilteredLine(x)).ToList();

            List<FileContentFilteredLine> filteredLines = new List<FileContentFilteredLine>();
            Regex regex = new Regex(pattern);

            foreach (string line in fileContent)
            {
                if (regex.IsMatch(line))
                {
                    filteredLines.Add(new(line));
                }
            }

            return filteredLines;
        }
    }
}

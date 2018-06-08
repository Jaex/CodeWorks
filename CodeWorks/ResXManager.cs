#region License Information (GPL v3)

/*
    Copyright (C) Jaex

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace CodeWorks
{
    public class ResXManager
    {
        public string OriginalText { get; private set; }
        public string ModifiedText { get; private set; }
        public long OriginalTextLineCount { get; private set; }
        public long ModifiedTextLineCount { get; private set; }
        public long LineCountDifference => ModifiedTextLineCount - OriginalTextLineCount;
        public List<string> OriginalDuplicates { get; private set; }
        public List<string> ModifiedDuplicates { get; private set; }
        public List<string> AddedEntries { get; private set; }
        public List<(string, string, string)> ChangedEntries { get; private set; }
        public List<string> RemovedEntries { get; private set; }

        public bool Compare(string originalText, string modifiedText)
        {
            if (string.IsNullOrWhiteSpace(originalText) || string.IsNullOrWhiteSpace(modifiedText))
            {
                return false;
            }

            OriginalText = originalText.Trim();
            ModifiedText = modifiedText.Trim();
            OriginalTextLineCount = originalText.Lines().Length;
            ModifiedTextLineCount = modifiedText.Lines().Length;

            XDocument original = XDocument.Parse(originalText);
            Dictionary<string, string> originalKeys = new Dictionary<string, string>();
            OriginalDuplicates = new List<string>();

            foreach (XElement element in original.Descendants("data"))
            {
                string name = element.Attribute("name").Value;

                if (!originalKeys.ContainsKey(name))
                {
                    originalKeys.Add(name, element.Descendants().First().Value);
                }
                else
                {
                    OriginalDuplicates.Add(name);
                }
            }

            XDocument modified = XDocument.Parse(modifiedText);
            Dictionary<string, string> modifiedKeys = new Dictionary<string, string>();
            ModifiedDuplicates = new List<string>();

            foreach (XElement element in modified.Descendants("data"))
            {
                string name = element.Attribute("name").Value;

                if (!modifiedKeys.ContainsKey(name))
                {
                    modifiedKeys.Add(name, element.Descendants().First().Value);
                }
                else
                {
                    ModifiedDuplicates.Add(name);
                }
            }

            AddedEntries = new List<string>();
            ChangedEntries = new List<(string, string, string)>();
            RemovedEntries = new List<string>();

            foreach (KeyValuePair<string, string> resource in originalKeys)
            {
                if (modifiedKeys.ContainsKey(resource.Key))
                {
                    string modifiedValue = modifiedKeys[resource.Key];

                    if (modifiedValue != resource.Value)
                    {
                        ChangedEntries.Add((resource.Key, resource.Value, modifiedValue));
                        
                    }

                    modifiedKeys.Remove(resource.Key);
                }
                else
                {
                    RemovedEntries.Add(resource.Key);
                }
            }

            foreach (KeyValuePair<string, string> resource in modifiedKeys)
            {
                AddedEntries.Add(resource.Key);
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Original text line count: " + OriginalTextLineCount);
            sb.AppendLine("Modified text line count: " + ModifiedTextLineCount);
            sb.Append("Line count difference: ");
            if (LineCountDifference > 0) sb.Append("+");
            sb.AppendLine(LineCountDifference.ToString());

            foreach (string originalDuplicate in OriginalDuplicates)
            {
                sb.AppendLine($"Duplicate (Original): {originalDuplicate}");
            }

            foreach (string modifiedDuplicate in ModifiedDuplicates)
            {
                sb.AppendLine($"Duplicate (Modified): {modifiedDuplicate}");
            }

            foreach (string addedEntry in AddedEntries)
            {
                sb.AppendLine($"Added: {addedEntry}");
            }

            foreach ((string, string, string) changedEntry in ChangedEntries)
            {
                sb.AppendLine($"Changed ({changedEntry.Item1}): \"{changedEntry.Item2}\" -> \"{changedEntry.Item3}\"");
            }

            foreach (string removedEntry in RemovedEntries)
            {
                sb.AppendLine($"Removed: {removedEntry}");
            }

            return sb.ToString().Trim();
        }
    }
}
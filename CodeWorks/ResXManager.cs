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
    public static class ResXManager
    {
        public static string Compare(string originalText, string modifiedText)
        {
            if (string.IsNullOrEmpty(originalText) || string.IsNullOrEmpty(modifiedText))
            {
                return "";
            }

            StringBuilder sb = new StringBuilder();

            long originalTextLineCount = originalText.Lines().Length;
            long modifiedTextLineCount = modifiedText.Lines().Length;
            long lineCountDifference = modifiedTextLineCount - originalTextLineCount;
            sb.AppendLine("Original text line count: " + originalTextLineCount);
            sb.AppendLine("Modified text line count: " + modifiedTextLineCount);
            sb.Append("Line count difference: ");

            if (lineCountDifference > 0)
            {
                sb.Append("+");
            }

            sb.AppendLine(lineCountDifference.ToString());

            XDocument original = XDocument.Parse(originalText.Trim());
            XDocument modified = XDocument.Parse(modifiedText.Trim());

            Dictionary<string, string> originalDict = new Dictionary<string, string>();

            foreach (XElement element in original.Descendants("data"))
            {
                string name = element.Attribute("name").Value;

                if (!originalDict.ContainsKey(name))
                {
                    originalDict.Add(name, element.Descendants().First().Value);
                }
                else
                {
                    sb.AppendLine($"Duplicate (Original): {name}");
                }
            }

            Dictionary<string, string> modifiedDict = new Dictionary<string, string>();

            foreach (XElement element in modified.Descendants("data"))
            {
                string name = element.Attribute("name").Value;

                if (!modifiedDict.ContainsKey(name))
                {
                    modifiedDict.Add(name, element.Descendants().First().Value);
                }
                else
                {
                    Console.WriteLine($"Duplicate (Modified): {name}");
                }
            }

            foreach (KeyValuePair<string, string> resource in originalDict)
            {
                if (modifiedDict.ContainsKey(resource.Key))
                {
                    string modifiedValue = modifiedDict[resource.Key];

                    if (modifiedValue != resource.Value)
                    {
                        sb.AppendLine($"Changed ({resource.Key}): \"{resource.Value}\" -> \"{modifiedValue}\"");
                    }

                    modifiedDict.Remove(resource.Key);
                }
                else
                {
                    sb.AppendLine($"Removed: {resource.Key}");
                }
            }

            foreach (KeyValuePair<string, string> resource in modifiedDict)
            {
                sb.AppendLine($"Added: {resource.Key}");
            }

            return sb.ToString().Trim();
        }
    }
}
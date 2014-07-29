﻿#region License Information (GPL v3)

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

using System.IO;
using System.Text;

namespace CodeWorks
{
    public class TextInfo
    {
        public string FilePath { get; set; }
        public string DefaultText { get; set; }
        public string NewText { get; set; }

        public bool IsDifferent
        {
            get { return !string.IsNullOrEmpty(NewText) && DefaultText != NewText; }
        }

        public TextInfo()
        {
        }

        public TextInfo(string filePath)
        {
            FilePath = filePath;
            DefaultText = File.ReadAllText(FilePath, Encoding.UTF8);
        }

        public void WriteNewText()
        {
            if (!string.IsNullOrEmpty(FilePath) && !string.IsNullOrEmpty(NewText) && File.Exists(FilePath))
            {
                File.WriteAllText(FilePath, NewText, Encoding.UTF8);
            }
        }
    }
}
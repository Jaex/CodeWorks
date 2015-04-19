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

using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Text;
using System.Windows.Forms.Design;

namespace CodeWorks
{
    public class WorkInfo
    {
        public bool Enabled { get; set; }

        [Editor("System.Windows.Forms.Design.StringCollectionEditor,System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public List<string> FolderPaths { get; set; }

        [Editor("System.Windows.Forms.Design.StringCollectionEditor,System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public List<string> IgnoreFolders { get; set; }

        [Editor("System.Windows.Forms.Design.StringCollectionEditor,System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public List<string> IgnoreFiles { get; set; }

        [Editor("System.Windows.Forms.Design.StringCollectionEditor,System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public List<string> AllowFilenamesEndsWith { get; set; }

        [Editor("System.Windows.Forms.Design.StringCollectionEditor,System.Design, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public List<string> IgnoreFilenamesEndsWith { get; set; }

        [Editor(typeof(FileNameEditor), typeof(UITypeEditor))]
        public string LicenseTextPath { get; set; }

        private string licenseText;

        [Browsable(false), JsonIgnore]
        public string LicenseText
        {
            get
            {
                if (string.IsNullOrEmpty(licenseText) && !string.IsNullOrEmpty(LicenseTextPath) && File.Exists(LicenseTextPath))
                {
                    licenseText = File.ReadAllText(LicenseTextPath, Encoding.UTF8);
                }

                return licenseText;
            }
            set
            {
                licenseText = value;
            }
        }

        public string LicenseRegionText { get; set; }

        public WorkInfo()
        {
            Enabled = true;
            FolderPaths = new List<string>();
            IgnoreFolders = new List<string>() { "bin", "obj", "Properties", "packages" };
            IgnoreFiles = new List<string>();
            AllowFilenamesEndsWith = new List<string>() { ".cs" };
            IgnoreFilenamesEndsWith = new List<string>() { ".designer.cs" };
            LicenseRegionText = "License Information (GPL v3)";
        }

        public override string ToString()
        {
            if (!string.IsNullOrEmpty(LicenseTextPath))
            {
                return Path.GetFileName(LicenseTextPath);
            }

            return base.ToString();
        }
    }
}
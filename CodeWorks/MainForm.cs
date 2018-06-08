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

using CodeWorks.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace CodeWorks
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Icon = Resources.Icon;

            tbDefaultText.SupportSelectAll();
            tbNewText.SupportSelectAll();
            txtResXOriginal.SupportSelectAll();
            txtResXModified.SupportSelectAll();
            txtResXResult.SupportSelectAll();
        }

        private void btnFindRegionAreas_Click(object sender, EventArgs e)
        {
            SearchRegionAreas();
        }

        private void SearchRegionAreas()
        {
            lvResults.Items.Clear();

            foreach (WorkInfo info in Program.Settings.Works)
            {
                if (info.Enabled)
                {
                    foreach (string folderPath in info.FolderPaths)
                    {
                        SearchFolderRegionAreas(info, folderPath);
                    }
                }
            }

            int count = lvResults.Items.Count;
            lblFileCount.Text = $"Status: Found {count} files.";
            btnAddLicense.Enabled = btnAddLicenseAll.Enabled = count > 0;

            SystemSounds.Exclamation.Play();
        }

        private void SearchFolderRegionAreas(WorkInfo info, string folderPath)
        {
            if (IsValidFolder(info, folderPath))
            {
                foreach (string folder in Directory.GetDirectories(folderPath))
                {
                    SearchFolderRegionAreas(info, folder);
                }

                foreach (string file in Directory.GetFiles(folderPath))
                {
                    CleanRegionAreas(info, file, info.LicenseRegionText);
                }
            }
        }

        private bool CleanRegionAreas(WorkInfo info, string path, string searchRegionName)
        {
            if (IsValidFile(info, path))
            {
                TextInfo textInfo = new TextInfo(path);
                RegionAreaManager regionAreaManager = new RegionAreaManager(textInfo.DefaultText);
                List<RegionArea> regionAreas = regionAreaManager.GetRegionAreas();
                int offset = 0;

                foreach (RegionArea regionArea in regionAreas)
                {
                    if (regionArea.RegionName.IndexOf(searchRegionName, StringComparison.InvariantCultureIgnoreCase) >= 0)
                    {
                        regionArea.RegionIndexOffset = offset;
                        string regionAreaTextRemoved = regionArea.RemoveRegionText();
                        offset += -regionArea.RegionLength;
                        regionAreaManager.Text = regionAreaTextRemoved;
                    }
                }

                textInfo.NewText = info.LicenseText + "\r\n\r\n" + regionAreaManager.Text.Trim();

                if (textInfo.IsDifferent)
                {
                    lvResults.Items.Add(path).Tag = textInfo;
                    return true;
                }
            }

            return false;
        }

        private bool IsValidFolder(WorkInfo info, string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                string foldername = Path.GetFileName(path).ToLowerInvariant();
                return info.IgnoreFolders.All(x => !foldername.Equals(x, StringComparison.InvariantCultureIgnoreCase)) && Directory.Exists(path);
            }

            return false;
        }

        private bool IsValidFile(WorkInfo info, string path)
        {
            if (!string.IsNullOrEmpty(path))
            {
                string filename = Path.GetFileName(path).ToLowerInvariant();
                return Path.HasExtension(filename) && info.AllowFilenamesEndsWith.Any(x => filename.EndsWith(x)) &&
                    info.IgnoreFiles.All(x => !filename.Equals(x, StringComparison.InvariantCultureIgnoreCase)) &&
                    info.IgnoreFilenamesEndsWith.All(x => !filename.EndsWith(x)) && File.Exists(path);
            }

            return false;
        }

        private void lvResults_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvResults.SelectedItems.Count > 0)
            {
                TextInfo info = lvResults.SelectedItems[0].Tag as TextInfo;

                if (info != null)
                {
                    tbDefaultText.Text = info.DefaultText;
                    tbNewText.Text = info.NewText;
                }
            }
        }

        private void btnAddLicense_Click(object sender, EventArgs e)
        {
            if (lvResults.SelectedItems.Count > 0)
            {
                TextInfo info = lvResults.SelectedItems[0].Tag as TextInfo;

                if (info != null)
                {
                    info.WriteNewText();
                    lvResults.Items.Remove(lvResults.SelectedItems[0]);
                }
            }
        }

        private void btnAddLicenseAll_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in lvResults.Items)
            {
                TextInfo info = lvi.Tag as TextInfo;

                if (info != null)
                {
                    info.WriteNewText();
                }
            }

            SearchRegionAreas();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }

        private void btnOrderLines_Click(object sender, EventArgs e)
        {
            string clipboard = Clipboard.GetText();
            clipboard = clipboard.Trim();
            string[] lines = new StringLineReader(clipboard).ReadAllLines();
            Array.Sort(lines);
            string result = string.Join("\r\n", lines);

            if (!clipboard.Equals(result, StringComparison.InvariantCulture))
            {
                tbDefaultText.Text = clipboard;
                tbNewText.Text = result;
            }
            else
            {
                tbDefaultText.Clear();
                tbNewText.Clear();
            }

            SystemSounds.Exclamation.Play();
        }

        private void btnCopyToClipboard_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNewText.Text))
            {
                Clipboard.SetText(tbNewText.Text);
            }
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            PropertyDescriptor pd = TypeDescriptor.GetProperties(Program.Settings)["Works"];
            UITypeEditor editor = (UITypeEditor)pd.GetEditor(typeof(UITypeEditor));
            RuntimeServiceProvider serviceProvider = new RuntimeServiceProvider();
            editor.EditValue(serviceProvider, serviceProvider, Program.Settings.Works);
        }

        private void btnResXCompare_Click(object sender, EventArgs e)
        {
            ResXManager resxManager = new ResXManager();

            if (resxManager.Compare(txtResXOriginal.Text, txtResXModified.Text))
            {
                txtResXResult.Text = resxManager.ToString();
            }
            else
            {
                txtResXResult.Clear();
            }
        }
    }
}
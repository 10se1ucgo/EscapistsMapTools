// my first C# program please be gentle :^^^)))
using EscapistsMapTools.Encryption;
using EscapistsMapTools.Properties;
using IniParser;
using Microsoft.Win32;
using System;
using System.IO;
using System.Windows.Forms;

namespace EscapistsMapTools {
    public enum EMTAction {
        Decompile,
        Decrypt,
        Encrypt
    }

    public partial class MainFrame : Form {
        private static string GamePath {
            get {
                using (RegistryKey steamReg = Registry.CurrentUser.OpenSubKey(@"Software\Valve\Steam")) {
                    if (steamReg != null)
                        return Path.Combine((string) steamReg.GetValue("SteamPath"),
                            @"/steamapps/common/The Escapists/Data/Maps");
                }
                return null;
            }
        }

        public MainFrame() {
            InitializeComponent();
            inputFileDialog.InitialDirectory = GamePath;
        }

        private void ProcessMap(string inputFile, string outputFile, string key, EMTAction action) {
            if (string.IsNullOrEmpty(inputFile) || string.IsNullOrEmpty(outputFile) || string.IsNullOrEmpty(key)) {
                MessageBox.Show(Resources.ProcessMap_invalidArguments, Resources.ProcessMap_error, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            BlowfishCompat blowfishCompat = new BlowfishCompat(key);
            byte[] bytes = File.ReadAllBytes(inputFile);
            byte[] result;
            switch (action) {
                case EMTAction.Decompile:
                    ProcessMap(inputFile, outputFile, key, EMTAction.Decrypt);
                    DecompileMap(outputFile);
                    ProcessMap(outputFile, outputFile, key, EMTAction.Encrypt);
                    return;
                case EMTAction.Decrypt:
                    result = blowfishCompat.Decrypt(bytes);
                    break;
                case EMTAction.Encrypt:
                    result = blowfishCompat.Encrypt(bytes);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(action), action, null);
            }
            File.WriteAllBytes(outputFile, result);
        }

        private static void DecompileMap(string file) {
            FileIniDataParser parser = new FileIniDataParser();
            IniParser.Model.IniData data = parser.ReadFile(file);
            data.Configuration.AssigmentSpacer = "";
            data["Info"]["Rdy"] = "0";
            data["Info"]["Custom"] = "-1";
            parser.WriteFile(file, data);
        }

        private void inputFileButton_Click(object sender, EventArgs e) {
            if (inputFileDialog.ShowDialog() != DialogResult.OK) return;
            inputFileText.Text = inputFileDialog.FileName;
        }

        private void outputFileButton_Click(object sender, EventArgs e) {
            if (outputFileDialog.ShowDialog() != DialogResult.OK) return;
            outputFileText.Text = outputFileDialog.FileName;
        }

        private void decompileButton_Click(object sender, EventArgs e) {
            ProcessMap(inputFileDialog.FileName, outputFileDialog.FileName, encryptionKey.Text, EMTAction.Decompile);
            MessageBox.Show(Resources.mapSuccesfullyDecompiled, Resources.messageComplete, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void decryptButton_Click(object sender, EventArgs e) {
            ProcessMap(inputFileDialog.FileName, outputFileDialog.FileName, encryptionKey.Text, EMTAction.Decrypt);
            MessageBox.Show(Resources.mapSuccesfullyDecrypted, Resources.messageComplete, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void encryptButton_Click(object sender, EventArgs e) {
            ProcessMap(inputFileDialog.FileName, outputFileDialog.FileName, encryptionKey.Text, EMTAction.Encrypt);
            MessageBox.Show(Resources.mapSuccesfullyEncrypted, Resources.messageComplete, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

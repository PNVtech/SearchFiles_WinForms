using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace SearchFiles
{
    public partial class Form1 : Form
    {
        private CancellationTokenSource cancellationTokenSource;
        private CancellationToken cancellationToken;

        public Form1()
        {
            InitializeComponent();

            FolderAddress.Text = Properties.Settings.Default.FolderAddress;
            TemplateName.Text = Properties.Settings.Default.TemplateName;
            Content.Text = Properties.Settings.Default.Content;
        }

        private void buttonSelect_MouseClick(object sender, MouseEventArgs e)
        {
            FolderBrowserDialog folderDialog = new FolderBrowserDialog();

            DialogResult dialogResult = folderDialog.ShowDialog();

            if (dialogResult == DialogResult.OK)
            {
                FolderAddress.Text = folderDialog.SelectedPath;
            }

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            cancellationTokenSource = new CancellationTokenSource();
            cancellationToken = cancellationTokenSource.Token;

            SearchFiles(cancellationToken);
        }

        /// <summary>
        /// Поиск файлов
        /// </summary>
        /// <param name="token"></param>
        private async void SearchFiles(CancellationToken token)
        {
            treeViewFiles.Nodes.Clear();
            
            if (FolderAddress.Text != string.Empty)
            {
                int count = 0;
                DateTime startTime = DateTime.Now;

                DirectoryInfo selectedDirectory = new DirectoryInfo(FolderAddress.Text);
                var files = selectedDirectory.GetFiles(TemplateName.Text == string.Empty ? "*" : TemplateName.Text, SearchOption.AllDirectories);
                
                foreach (var file in files)
                {
                    if (!token.IsCancellationRequested)
                    {
                        count += 1;
                        var path = file.FullName;
                        labelStatus.Text = $"Прошло {DateTime.Now - startTime}. Обработано файлов: {count}. Обработка файла {path}.";

                        if (await EqualityContent(path, Content.Text))
                        {
                            var childs = treeViewFiles.Nodes;
                            foreach (var part in path.Split('\\'))
                            {
                                childs = FindOrCreateNode(childs, part).Nodes;
                            }
                        }
                    }
                }

                labelStatus.Text = $"Готово. Прошло {DateTime.Now - startTime}. Обработано файлов: {count}.";
            }

            // Сохранение настроек
            Properties.Settings.Default.FolderAddress = FolderAddress.Text;
            Properties.Settings.Default.TemplateName = TemplateName.Text;
            Properties.Settings.Default.Content = Content.Text;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Наполнение TreeView
        /// </summary>
        /// <param name="coll"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        private static TreeNode FindOrCreateNode(TreeNodeCollection coll, string name)
        {
            var found = coll.Find(name.ToLower(), false);
            if (found.Length > 0) return found[0];
            return coll.Add(name.ToLower(), name);
        }

        /// <summary>
        /// Проверка содержимого
        /// </summary>
        /// <param name="path"></param>
        /// <param name="text"></param>
        /// <returns></returns>
        private static Task<bool> EqualityContent(string path, string text)
        {
            return Task.Run(() =>
            {
                using (var st = File.OpenText(path))
                {
                    if (st.ReadToEndAsync().Result.Contains(text))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            });

        }

        /// <summary>
        /// Остановка поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
    }
}

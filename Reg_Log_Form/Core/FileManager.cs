﻿using Reg_Log_Form.Roles;
using Reg_Log_Form.Visulizers;
using System;
using System.Drawing;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace Reg_Log_Form
{
    public static class FileManager
    {
        private static Bitmap MyImage;

        public static void ShowMyImage(string fileToDisplay, PictureBox pictureBox,int xSize, int ySize)
        {
            if (MyImage != null)
            {
                MyImage.Dispose();
            }

            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            MyImage = new Bitmap(fileToDisplay);
            pictureBox.ClientSize = new Size(xSize, ySize);
            pictureBox.Image = (Image)MyImage;
        }
        public static void WriteLog(string path, string content)
        {
            if (!File.Exists(path))
            {
                File.WriteAllText(path, content);
            }
            else
            {
                File.AppendAllText(path, $"\n[{content}");

            }
        }
        public static string ReadLogs(string path)
        {
            string logs_info = default;
            if (File.Exists(path))
            {
                logs_info = File.ReadAllText(path);
            }
            return logs_info;
        }
        public static string GetPath(string folder = "", string file = "")
        {
            string directory = Directory.GetCurrentDirectory();
            DirectoryInfo directoryInfo = Directory.GetParent(directory);
            string path = $"{directoryInfo}/{folder}/{file}";
            return path;
        }
        public static string CopyPicture(string sourceFileName)
        {
            Random random = new Random();
            string copiedFileName = $"user_pic_{random.Next()}{sourceFileName.Substring(sourceFileName.LastIndexOf("."))}";
            string newFileNamePath = GetPath("pics", copiedFileName);
            File.Copy(sourceFileName, newFileNamePath);
            return newFileNamePath;
        }
        public static string GetLogMessage(IVisualizer visualizer)
        {
            return visualizer.Visualize();
        }
    }
}

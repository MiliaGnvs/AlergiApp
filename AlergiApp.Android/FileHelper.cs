using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AlergiApp.DataBase;
using AlergiApp.Droid;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace AlergiApp.Droid
{
    class FileHelper : IFileHelper
    {
        public string GetFilePath(string file)
        {
            return Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), file);
        }
    }
}
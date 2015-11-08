using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.UI.Xaml.Controls;

namespace App1.Components
{

    class FileManage
    {
        /*未完待续*/
        public static async Task<List<StorageFile>> ScannFolder()
        {
            List<StorageFile> list = new List<StorageFile>();
            FolderPicker pc = new FolderPicker();
            pc.FileTypeFilter.Add(@"*");
            pc.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            var s = await pc.PickSingleFolderAsync();
            var t = await s.GetFilesAsync();
            list.AddRange(t);

            return list;
        }
        /// <summary>
        /// 打开文件选择器，任意文件类型，要播放文件可能需要处理异常
        /// </summary>
        /// <returns>
        /// </returns>
        public static async Task<StorageFile> SelectSingleFile()
        {
            FileOpenPicker pc = new FileOpenPicker();
            pc.FileTypeFilter.Add(@"*");
            var file = await pc.PickSingleFileAsync();
            return file;
        }

    }
}

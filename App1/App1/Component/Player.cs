using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Windows.Storage;
using Windows.UI.Xaml.Controls;

namespace App1.Components
{
    class Player
    {
        private static bool playing = false;
        private static MediaElement nowMedia = new MediaElement();
        public static async void Play(StorageFile file = null)
        {
            if(file == null && playing == false)
            {
                try
                {
                    nowMedia.Play();
                    playing = true;
                }
                catch { }
            }
            if (file != null /*&& playing == false*/)
            {
                var open = await file.OpenAsync(FileAccessMode.Read);
                try
                {
                    nowMedia.SetSource(open, "mp3");
                    nowMedia.Play();
                    playing = true;
                }
                catch { }
                
            }
        }
        public static void Pause()
        {
            if (playing && nowMedia.CanPause)
            {
                nowMedia.Pause();
                playing = false;
            }
        }
        public static void Stop()
        {
            if (playing)
            {
                nowMedia.Stop();
                playing = false;
            }
        }
    }
}

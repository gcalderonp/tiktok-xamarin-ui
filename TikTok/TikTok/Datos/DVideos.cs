using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TikTok.Modelo;

namespace TikTok.Datos
{
    public class DVideos
    {

        public ObservableCollection<MVideos> MostrarVideos()
        {
            return new ObservableCollection<MVideos>()
            {
                new MVideos()
                {
                    video="https://firebasestorage.googleapis.com/v0/b/tiktok-254ff.appspot.com/o/v1.mp4?alt=media&token=8d810170-0708-41bc-82b5-f464e6d58549"
                },
                new MVideos()
                {
                    video = "https://firebasestorage.googleapis.com/v0/b/tiktok-254ff.appspot.com/o/v2.mp4?alt=media&token=8370714f-75c2-4f8e-85c0-36025cf63853"
                }

            };
        }
    }

}


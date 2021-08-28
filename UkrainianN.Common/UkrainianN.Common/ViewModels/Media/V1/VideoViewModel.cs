using System;
using System.Collections.Generic;

namespace UkrainianN.Common.ViewModels.Media.V1
{
    public class VideoViewModel : FileViewModel
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public TimeSpan Duration { get; set; }
        public VideoResolution Resolution { get; set; }
        public List<VideoFragment> Fragments { get; set; }
    }

    public class VideoFragment
    {
        public TimeSpan From { get; set; }
        public TimeSpan To { get; set; }
        public string Title { get; set; }
    }
}
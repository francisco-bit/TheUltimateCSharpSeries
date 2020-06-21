using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ProjectPart3
{

    public class VideoEncoderEventArgs: EventArgs
    {
        public Video Video { get; set; }
    }

    public class VideoEncoder
    {
        //1 - Define an event based on the eventHandler delegate
        //2- Raise the event

        public event EventHandler<VideoEncoderEventArgs> videoEnconde;

        public void Encode (Video video)
        {
            Console.WriteLine("Encoding the video ...");
            Thread.Sleep(3000);

            OnVideoEncode(video);
        }


        //firing the event
        protected virtual void OnVideoEncode(Video video)
        {
            if (videoEnconde != null)
                videoEnconde(this, new VideoEncoderEventArgs() { Video=video});
        }

    }
}

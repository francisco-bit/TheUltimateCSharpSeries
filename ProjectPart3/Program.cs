using System;

namespace ProjectPart3
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { title = "video 1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subscriber 1
            var messageService = new MessageService(); //subscriber 2

            //adding the events
            videoEncoder.videoEnconde += mailService.OnVideoEncoded;
            videoEncoder.videoEnconde += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}

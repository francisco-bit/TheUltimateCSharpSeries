using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPart3
{
    public class MessageService
    {
        public void OnVideoEncoded(object source, VideoEncoderEventArgs args)
        {
            Console.WriteLine("MEssageService: Sending a text message ...");
        }
    }
}

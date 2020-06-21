using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectPart3
{
    public class MailService
    {
        public void OnVideoEncoded(object source, VideoEncoderEventArgs e)
        {
            Console.WriteLine("MailService: Sending an email...");
        }
    }
}

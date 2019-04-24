using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndDelgate
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder();  // publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); // subscriber

            // Who's the publisher?  videoEncoder
            // Event we are interested in VideoEncoded
            // How to subscribe +=

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(video);
        }
    }
}

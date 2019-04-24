using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace EventsAndDelgate
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {

        // To define an event 
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args); ---Outdated with the EventHandler<TeventArgs>
        // Delcaring delegate to declare function like above 2.  
        // Naming convention append EventHandler to name

            //EventHandler
            //EventHandler<TeventArgs>

        public event EventHandler<VideoEventArgs> VideoEncoded;
        // defined event based on the delegate


        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);

            OnVideoEncoded(video);
        }

        // .NET best practice should be protected virtual and start with On
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
                VideoEncoded(this, new VideoEventArgs() { Video = video });
            
        }
    }
}

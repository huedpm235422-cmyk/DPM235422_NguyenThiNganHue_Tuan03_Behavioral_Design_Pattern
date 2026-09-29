using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPM235422_Observer_Real_ThongBao_DP
{
    public class YoutubeChannel : IYoutubeChannel
    {
        private List<ISubscriber> _subscribers = new List<ISubscriber>();
        private string _latestVideo;

        public void Subscribe(ISubscriber subscriber)
        {
            _subscribers.Add(subscriber);
        }

        public void Unsubscribe(ISubscriber subscriber)
        {
            _subscribers.Remove(subscriber);
        }

        public void NotifySubscribers()
        {
            foreach (var sub in _subscribers)
            {
                sub.Update(_latestVideo);
            }
        }

        public void UploadVideo(string title)
        {
            _latestVideo = title;
            Console.WriteLine($"\n[Kênh Youtube] Đã tải lên video mới: {_latestVideo}");
            NotifySubscribers();
        }
    }
}

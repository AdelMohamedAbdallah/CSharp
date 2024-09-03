namespace C__Course.LinkedList
{
    internal class YTVideo
    {
        public YTVideo(string title, string id, TimeSpan time)
        {
            this.id = id;
            this.title = title;
            this.time = time;
        }

        private string id { get; set; }
        private string title { get; set; }
        private TimeSpan time { get; set; }

        public override string ToString()
        {
            return $"|--{title} ({time})\n|\t https://youtu.be/8aWHZncV95Q?si={id}";
        }
    }
}

using Humanizer;

namespace C__Course.NugetPackages
{
    internal class FBComment
    {


        public FBComment(string writercomment, string comment, DateTime durationcomment)
        {
#if DEBUG
            Console.WriteLine("Invalid input");
#endif
            this.writercomment = writercomment;
            this.comment = comment;
            this.durationcomment = durationcomment;
        }

        private string writercomment { get; set; }
        private string comment { get; set; }
        private DateTime durationcomment { get; set; }

        public override string ToString() => $"{writercomment}\n\t{comment}\n\t\t\t\t{durationcomment.Humanize()}";

    }
}

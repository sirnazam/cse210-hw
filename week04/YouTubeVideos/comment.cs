namespace Sirnazam
{
    public class Comment
    {
        public string _commenterName {get; set;}
        public string _commenterText {get; set;}

        public Comment (string commenterName, string commenterText)
        {
            _commenterName = commenterName;
            _commenterText = commenterText;

        }

        public void DisplayComment()
        {
            Console.WriteLine($"{_commenterName}, {_commenterText}");
        }
    }
}
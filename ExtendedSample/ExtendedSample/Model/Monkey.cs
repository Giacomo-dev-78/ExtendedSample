using Xamarin.Forms;

namespace ExtendedSample.Model
{
    public class Monkey
    {
        public string Id { get; set; }
        public ImageSource Image { get; set; }
        public string Name { get; set; }

        public bool IsSelected { get; set; }
    }
}
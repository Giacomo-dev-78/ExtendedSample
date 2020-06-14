using System.Collections.ObjectModel;
using ExtendedSample.Model;
using Xamarin.Forms;

namespace ExtendedSample.ViewModel
{
    public class MonkeysViewModel
    {
        public ObservableCollection<Monkey> Monkeys { get; set; }

        public Monkey CurrentMonkey
        {
            get;
            set;
        }

        public Monkey SelectedMonkey
        {
            get;
            set;
        }

        public MonkeysViewModel()
        {
            Monkeys = new ObservableCollection<Monkey>
            {
                new Monkey {Name = "Macaque", Image = Device.RuntimePlatform == Device.Android
                        ? ImageSource.FromFile("Macaque.jpg")
                        : ImageSource.FromFile("Images/Macaque.jpg")
                },
                new Monkey {Name = "Baboon", Image = Device.RuntimePlatform == Device.Android
                    ? ImageSource.FromFile("Baboon.jpg")
                    : ImageSource.FromFile("Images/Baboon.jpg")
                },
                new Monkey {Name = "Chimpanzee", Image = Device.RuntimePlatform == Device.Android
                    ? ImageSource.FromFile("Chimpanzee.jpg")
                    : ImageSource.FromFile("Images/Chimpanzee.jpg")
                },
                new Monkey {Name = "Gorilla", Image = Device.RuntimePlatform == Device.Android
                    ? ImageSource.FromFile("Gorilla.jpg")
                    : ImageSource.FromFile("Images/Gorilla.jpg")
                },
                new Monkey {Name = "Orangutan", Image = Device.RuntimePlatform == Device.Android
                    ? ImageSource.FromFile("Orangutan.jpg")
                    : ImageSource.FromFile("Images/Orangutan.jpg")
                },

                //new Monkey {Name = "Baboon", Image = ImageSource.FromFile("Images/Baboon.jpg")},
                //new Monkey {Name = "Chimpanzee", Image = ImageSource.FromFile("Images/Chimpanzee.jpg")},
                //new Monkey {Name = "Gorilla", Image = ImageSource.FromFile("Images/Gorilla.jpg")},
                //new Monkey {Name = "Orangutan", Image = ImageSource.FromFile("Images/Orangutan.jpg")}
            };
        }
    }
}
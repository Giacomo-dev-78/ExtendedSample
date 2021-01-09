using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using ExtendedControls.ExtCollectionView.XForms.Control;
using ExtendedSample.Model;
using Xamarin.Forms;

namespace ExtendedSample.ViewModel
{
    public class MonkeysViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ICommand AddMonkeyCommand { get; set; }
        public ICommand RemoveMonkeyCommand { get; set; }
        public ICommand RefreshCommand { get; set; }

        public ICommand TapCommand { get; set; }
        public ICommand DoubleTapCommand { get; set; }
        public ICommand SelectionChangedCommand { get; set; }

        private ObservableCollection<Monkey> _selectedMonkeys;
        public ObservableCollection<Monkey> SelectedMonkeys
        {
            get => _selectedMonkeys;
            set
            {
                _selectedMonkeys = value;
                OnPropertyChanged();
            }
        }

        //public ICommand ItemSwipedCommand { get; set; }

        private ObservableCollection<Monkey> _monkeys;
        public ObservableCollection<Monkey> Monkeys
        {
            get => _monkeys;
            set
            {
                _monkeys = value;
                OnPropertyChanged();
            }
        }

        private Monkey _currentMonkey;
        public Monkey CurrentMonkey
        {
            get => _currentMonkey;
            set
            {
                if (_currentMonkey == value) return;
                _currentMonkey = value;
                OnPropertyChanged();
            }
        }

        private Monkey _selectedMonkey;
        public Monkey SelectedMonkey
        {
            get => _selectedMonkey;
            set
            {
                if (_selectedMonkey == value) return;
                //_selectedMonkey = ((BindableObject)value).BindingContext;
                _selectedMonkey = value;
                SelectedMonkeys.Add(new Monkey { Name = _selectedMonkey?.Name, Image = _selectedMonkey?.Image });
                OnPropertyChanged();
            }
        }

        public MonkeysViewModel()
        {
            this.AddMonkeyCommand = new Command(AddMonkey);
            this.RemoveMonkeyCommand = new Command(RemoveMonkey);
            this.RefreshCommand = new Command(RefreshList);

            this.TapCommand = new Command(Tapped);
            this.DoubleTapCommand = new Command(DoubleTapped);
            this.SelectionChangedCommand = new Command(SelectionChanged);
            //this.ItemSwipedCommand = new Command(ItemSwiped);

            SelectedMonkeys = new ObservableCollection<Monkey>();

            Monkeys = new ObservableCollection<Monkey>
            {
                new Monkey { Id = Guid.NewGuid().ToString(), Name = "Macaque", Image =  ImageSource.FromFile("Images/Macaque.jpg")},
                new Monkey { Id = Guid.NewGuid().ToString(), Name = "Baboon", Image = ImageSource.FromFile("Images/Baboon.jpg") },
                new Monkey { Id = Guid.NewGuid().ToString(), Name = "Chimpanzee", Image = ImageSource.FromFile("Images/Chimpanzee.jpg") },
                new Monkey { Id = Guid.NewGuid().ToString(), Name = "Gorilla", Image = ImageSource.FromFile("Images/Gorilla.jpg") },
                new Monkey { Id = Guid.NewGuid().ToString(), Name = "Orangutan", Image = ImageSource.FromFile("Images/Orangutan.jpg") },
                new Monkey { Id = Guid.NewGuid().ToString(), Name = "Macaque", Image = ImageSource.FromFile("Images/Macaque.jpg")},
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Baboon", Image = ImageSource.FromFile("Images/Baboon.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Macaque", Image = ImageSource.FromFile("Images/Macaque.jpg")},
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Baboon", Image = ImageSource.FromFile("Images/Baboon.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Chimpanzee", Image = ImageSource.FromFile("Images/Chimpanzee.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Gorilla", Image = ImageSource.FromFile("Images/Gorilla.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Orangutan", Image = ImageSource.FromFile("Images/Orangutan.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Macaque", Image = ImageSource.FromFile("Images/Macaque.jpg")},
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Baboon", Image = ImageSource.FromFile("Images/Baboon.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Chimpanzee", Image = ImageSource.FromFile("Images/Chimpanzee.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Gorilla", Image = ImageSource.FromFile("Images/Gorilla.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Orangutan", Image = ImageSource.FromFile("Images/Orangutan.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Gorilla", Image = ImageSource.FromFile("Images/Gorilla.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Orangutan", Image = ImageSource.FromFile("Images/Orangutan.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Orangutan", Image = ImageSource.FromFile("Images/Orangutan.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Gorilla", Image = ImageSource.FromFile("Images/Gorilla.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Orangutan", Image = ImageSource.FromFile("Images/Orangutan.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Macaque", Image = ImageSource.FromFile("Images/Macaque.jpg")},
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Baboon", Image = ImageSource.FromFile("Images/Baboon.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Macaque", Image = ImageSource.FromFile("Images/Macaque.jpg")},
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Orangutan", Image = ImageSource.FromFile("Images/Orangutan.jpg") },
                //new Monkey { Id = Guid.NewGuid().ToString(), Name = "Gorilla", Image = ImageSource.FromFile("Images/Gorilla.jpg") },

            };

            //ExtendedCollectionView ecv = new ExtendedCollectionView();
            //ecv.ItemDragStarted += Ecv_ItemDragStarted;
            //Device.RuntimePlatform == Device.Android ? ImageSource.FromFile("Macaque.jpg") : ImageSource.FromFile("Images/Macaque.jpg")},//


        }

        private void ItemSwiped(object obj)
        {

        }

        private void SelectionChanged(object obj)
        {

        }

        private void DoubleTapped(object obj)
        {

        }

        private void Tapped(object obj)
        {

        }

        private void RefreshList(object obj)
        {
            if (obj is ExtendedCollectionView ext)
                ext.Refresh();
        }

        //private void Ecv_OnItemIntersecting(object sender, IntersectionEventArgs args)
        //{
        //    var sc = args.StartColumn;
        //    var x = args.X;
        //    var y = args.Y;
        //    var sr = args.StartRow;
        //}

        private void RemoveMonkey(object obj)
        {
            Monkeys.Remove(CurrentMonkey);
        }

        private void AddMonkey(object obj)
        {
            Monkeys.Add(new Monkey { Name = "Gorilla", Image = ImageSource.FromFile("Images/Gorilla.jpg") });
        }

        private void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
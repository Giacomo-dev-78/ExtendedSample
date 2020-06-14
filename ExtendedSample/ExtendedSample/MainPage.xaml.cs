using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendedControls.ExtCollectionView.XForms.EventArgs;
using Xamarin.Forms;

namespace ExtendedSample
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ExtendedCollectionView_OnSelectionChanging(object sender, SelectedItemsChangingEventArgs args)
        {
            
        }

        private void ExtendedCollectionView_OnSelectionChanged(object sender, SelectedItemsChangedEventArgs args)
        {
            
        }

        private void ExtendedCollectionView_OnItemDragStarted(object sender, DragStartedEventArgs args)
        {
            
        }

        private void ExtendedCollectionView_OnItemIntersecting(object sender, IntersectionEventArgs args)
        {
            
        }

        private void ExtendedCollectionView_OnItemDropped(object sender, DropEventArgs args)
        {
           
        }
    }
}

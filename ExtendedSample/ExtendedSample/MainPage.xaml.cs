using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtendedControls.ExtCollectionView.XForms.EventArgs;
//using ExtendedControls.ExtCollectionView.XForms.EventArgs;
using Xamarin.Forms;
using DropEventArgs = ExtendedControls.ExtCollectionView.XForms.EventArgs.DropEventArgs;

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
        private void Ecv_OnItemDragStarted(object sender, DragStartedEventArgs args)
        {
            
        }

        private void Ecv_OnSelectionChanging(object sender, SelectedItemsChangingEventArgs args)
        {
           
        }

        private void Ecv_OnSelectionChanged(object sender, SelectedItemsChangedEventArgs args)
        {
            
        }

        private void Ecv_OnChildrenReordered(object sender, EventArgs e)
        {
            
        }

        private void Ecv_OnItemIntersecting(object sender, IntersectionEventArgs args)
        {
            
        }

        private void Ecv_OnItemDropped(object sender, DropEventArgs args)
        {
            
        }

        private void Ecv_OnItemSourceChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            
        }
    }
}

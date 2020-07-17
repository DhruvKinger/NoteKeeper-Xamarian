using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NoteKeeper.Models;
using NoteKeeper.ViewModels;
using System.Collections.Generic;
using NoteKeeper.Services;

namespace NoteKeeper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

       

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            this.viewModel = viewModel;
            BindingContext = this.viewModel;
            
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            viewModel = new ItemDetailViewModel();
            BindingContext = viewModel;

        }

        

        public void Cancel_Clicked(Object Sender,EventArgs eventArgs)
        {
            viewModel.NoteHeading = "XXXXX";
            DisplayAlert("Cancel Option", "Cancel was selected", "Button 2", "Button 1");
        }

        public void Save_Clicked(Object Sender, EventArgs eventArgs)
        {
            DisplayAlert("Save Option", "Save was selected", "Button 2", "Button 1");
        }
    }
}


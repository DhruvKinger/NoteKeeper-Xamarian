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
            Navigation.PopModalAsync();
        }

        public void Save_Clicked(Object Sender, EventArgs eventArgs)
        {
            MessagingCenter.Send(this,"SaveNote",viewModel.Note);
            Navigation.PopModalAsync();
        }
    }
}


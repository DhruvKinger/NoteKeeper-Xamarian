using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using NoteKeeper.Models;
using NoteKeeper.ViewModels;

namespace NoteKeeper.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;
        public Note Note { get; set; }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();

            BindingContext = Note;
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            InitializeData();

            BindingContext = Note;
        }

        void InitializeData()
        {
            Note = new Note
            {
                Heading = "Text Note",
                Text = "It's text !"
            };

        }

        public void Cancel_Clicked(Object Sender,EventArgs eventArgs)
        {
            DisplayAlert("Cancel Option", "Cancel was selected", "Button 2", "Button 1");
        }

        public void Save_Clicked(Object Sender, EventArgs eventArgs)
        {
            DisplayAlert("Save Option", "Save was selected", "Button 2", "Button 1");
        }
    }
}


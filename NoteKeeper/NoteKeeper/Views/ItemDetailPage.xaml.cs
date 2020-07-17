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

        public IList<String> CourseList
        {
            get;set;
        }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();
            InitializeData();

            this.viewModel = viewModel;
            BindingContext = this.viewModel;
            NoteCourse.BindingContext = this;
        }

        public ItemDetailPage()
        {
            InitializeComponent();
            InitializeData();
            viewModel = new ItemDetailViewModel();

            BindingContext = viewModel;
            NoteCourse.BindingContext = this;
        }

        async void InitializeData()
        {
            var datastore = new MockPluralsightDataStore();
            CourseList = await datastore.GetCoursesAsync();
            

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


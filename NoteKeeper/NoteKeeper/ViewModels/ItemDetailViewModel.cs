using System;

using NoteKeeper.Models;

namespace NoteKeeper.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Note Note { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Note = new Note
            {
                Heading="Test Note",
                Text="Text of note !"
            };
        }
    }
}

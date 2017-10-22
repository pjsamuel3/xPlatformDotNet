using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Miles.People
{
    public partial class PeoplePage : ContentPage
    {
        PeopleViewModel viewModel;

        public PeoplePage()
        {
            InitializeComponent();

            BindingContext = viewModel = new PeopleViewModel();
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs args)
        {
            var item = args.SelectedItem as Item;
            if (item == null)
                return;

            await Navigation.PushAsync(new ItemDetailPage(new ItemDetailViewModel(item)));

            // Manually deselect item
            PeopleListView.SelectedItem = null;
        }

        async void AddItem_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new NewItemPage());
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            if (viewModel.People.Count == 0)
                viewModel.LoadPeopleCommand.Execute(null);
        }
    }
}
using Miles.People.List;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace Miles.People
{
    public class PeopleViewModel : BaseViewModel
    {
        public ObservableCollection<Employee> People { get; set; }
        public Command LoadPeopleCommand { get; set; }

        public PeopleViewModel()
        {
            Title = "Browse";
            People = new ObservableCollection<Employee>();
            LoadPeopleCommand = new Command(async () => await ExecuteLoadPeopleCommand());

            //MessagingCenter.Subscribe<NewItemPage, Item>(this, "AddItem", async (obj, item) =>
            //{
            //    var _item = item as Item;
            //    Items.Add(_item);
            //    await DataStore.AddItemAsync(_item);
            //});
        }

        async Task ExecuteLoadPeopleCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                People.Clear();
                var company = new Company();
                var people = company.GetEmployees();
                foreach (var person in people)
                {
                    People.Add(person);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
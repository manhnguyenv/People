using System.Collections.Generic;
using System.Threading.Tasks;
using MvvmCross.Core.ViewModels;
using People.Core.Models;
using People.Core.Services;

namespace People.Core.ViewModels
{
    public class PeopleListViewModel : MvxViewModel
    {
        
        private readonly IPeopleService _peopleService;

        public PeopleListViewModel(IPeopleService peopleService)
        {
            _peopleService = peopleService;
        }


        private List<Contact> _contacts;

        public List<Contact> Contacts
        {
            get { return _contacts; }
            set { SetProperty(ref _contacts, value); }
        }

        public async void Init()
        {
           //Contacts = await _peopleService.GetContacts();
        }
    }
}

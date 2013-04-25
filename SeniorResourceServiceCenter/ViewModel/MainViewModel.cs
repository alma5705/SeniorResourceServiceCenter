using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.ObjectModel;
using SeniorResourceServiceCenter.Model;

namespace SeniorResourceServiceCenter.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Senior> Seniors;
        private ObservableCollection<Volunteer> Volunteers;
        private ObservableCollection<Requirement> Requirements;
        private IMobileServiceTable<Senior> seniorsTable = App.MobileService.GetTable<Senior>();
        private IMobileServiceTable<Volunteer> volunteerTable = App.MobileService.GetTable<Volunteer>();
        private IMobileServiceTable<Requirement> requirementTable = App.MobileService.GetTable<Requirement>();
        private IMobileServiceTable<SeniorRequirements> _seniorRequirements = App.MobileService.GetTable<SeniorRequirements>(); //for many to many relationship
        private IMobileServiceTable<VolunteerRequirements> _volunteerRequirements = App.MobileService.GetTable<VolunteerRequirements>(); //likewise

        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _welcomeTitle = "Empty";

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }

            set
            {
                if (_welcomeTitle == value)
                {
                    return;
                }

                _welcomeTitle = value;
                RaisePropertyChanged(WelcomeTitlePropertyName);
            }
        }

        
        public RelayCommand RefreshCommand
        {
            get
            {
                return new RelayCommand(Refresh);
            }
        }
        

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            /*SeniorService = dataService;
            SeniorService.GetSeniors(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }

                    WelcomeTitle = item.Title;
                });
             */
            Refresh();
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}

        
        private async void Refresh()
        {
            var seniorResults = await seniorsTable.ToListAsync();
            var volunteerResults = await volunteerTable.ToListAsync();
            var requirementResults = await requirementTable.ToListAsync();

            Seniors = new ObservableCollection<Senior>(seniorResults);
            Volunteers = new ObservableCollection<Volunteer>(volunteerResults);
            Requirements = new ObservableCollection<Requirement>(requirementResults);
            
            WelcomeTitle = string.Format("{0} {1}", Seniors[1].FirstName, Seniors[1].LastName);

            //FindMatches(Seniors[0]);
        }

        /*
        private async void FindMatches(Senior selectedSenior)
        {
            var results = await seniorsTable.Where(Senior => Senior.IsSenior == false).
                Where(Senior => Senior.Requirement == selectedSenior.Requirement).ToListAsync();

            Volunteers = new ObservableCollection<Senior>(results);
            //int finished;
        }
         */

        private async void AddSenior(Senior newSenior)
        {
            await seniorsTable.InsertAsync(newSenior);
            //items.add(newSenior); for adding to the observablecollection, so we don't have to pull from azure
        }

        private async void AddVolunteer(Volunteer newVolunteer)
        {
            await volunteerTable.InsertAsync(newVolunteer);
        }

        private async void AddRequirement(Requirement newRequirement)
        {
            await requirementTable.InsertAsync(newRequirement);
        }

        private async void AttachRequirement(Requirement theRequirement, Senior theSenior = null, Volunteer theVolunteer = null, string additionalInformation = null)
        {
            //first we check to see who is getting the requirement
            bool isSenior;

            if (theSenior == null)
                isSenior = true;
            else if (theVolunteer == null)
                isSenior = false;
            else
                return;

            if (isSenior)
            {
                SeniorRequirements req = new SeniorRequirements();
                req.RequirementID = theRequirement.ID;
                req.SeniorID = theSenior.ID;
                req.AdditionalInformation = additionalInformation;

                await _seniorRequirements.InsertAsync(req);
            }
            else
            {
                VolunteerRequirements req = new VolunteerRequirements();
                req.RequirementID = theRequirement.ID;
                req.VolunteerID = theVolunteer.ID;

                await _volunteerRequirements.InsertAsync(req);
            }
        }
    }

}
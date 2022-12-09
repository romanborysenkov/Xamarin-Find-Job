using System;
using System.Collections.Generic;
using FindJob.ViewModels;
using Xamarin.Essentials;
using Xamarin.Forms;
using FindJob.Services;
using FindJob.Models;

namespace FindJob.Views
{
   
    public partial class VacanciesPage : ContentPage
    {
        public VacanciesViewModel _viewModel;
        List<Vacancy> vacancies = new List<Vacancy>();
        VacanciesService service = new VacanciesService();

       

        public VacanciesPage()
        {
             InitializeComponent();

             if (Preferences.Get("isLogined", false))
            {

            }
            BindingContext = _viewModel = new VacanciesViewModel();
            ListVac.ItemsSource = vacancies;
        }
     
        protected override  async void OnAppearing()
        {
            if (!string.IsNullOrEmpty(_viewModel.SearchString))
            {
                ListVac.ItemsSource = await _viewModel.ExecuteSearchCommand(); 
            }
            else
            {
                try
                {
                    ListVac.ItemsSource = await service.GetVacanciesAsync();
                      
                    //    downloadIndicator.IsRunning = true;
                    
                    
                }
                catch (Exception ex)
                {
                    downloadIndicator.IsRunning = true;
                   await DisplayAlert("Error!", ex.Message, "Ok");
                    ListVac.ItemsSource = vacancies;
                }
               
            }

           
            base.OnAppearing();
        }

       async void Entry_TextChanged(System.Object sender, Xamarin.Forms.TextChangedEventArgs e)
        {
            if(!string.IsNullOrEmpty(_viewModel.SearchString))
            {
                vacancies =await _viewModel.ExecuteSearchCommand();
              ListVac.ItemsSource = vacancies;
            }
            else { OnAppearing(); }
        }
    }
}


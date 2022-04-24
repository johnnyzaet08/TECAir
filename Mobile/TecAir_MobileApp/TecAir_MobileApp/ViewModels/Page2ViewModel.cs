﻿using System;
using System.Collections.Generic;
using System.Text;
using TecAir_MobileApp.Validators;
using Xamarin.Forms;

namespace TecAir_MobileApp.ViewModels
{
    public class Page2ViewModel : BaseViewModel
    {
        public Page2ViewModel()
    {
        this.InitializeProperties();
        //this.PromotionsCommand = new Command(this.PromotionsClicked);
        this.SubmitCommand = new Command(this.SubmitClicked);

    }



    #region Properties

    /// <summary>
    /// Gets or sets the property that bounds with an entry that gets the Full Name from user.
    /// </summary>
    public ValidatableObject<string> FullName { get; set; }

    /// <summary>
    /// Gets or sets the property that bounds with an entry that gets the Business Name from user.
    /// </summary>
    public string BusinessName { get; set; }

    /// <summary>
    /// Gets or sets the property that bounds with a ComboBox that gets the Business from user.
    /// </summary>
    public string Business { get; set; }

    /// <summary>
    /// Gets or sets the property that bounds with an entry that gets the Phone Number from user.
    /// </summary>
    public string PhoneNumber { get; set; }

    /// <summary>
    /// Gets or sets the property that bounds with an entry that gets the Street Address from user.
    /// </summary>
    public string StreetAddress { get; set; }

    /// <summary>
    /// Gets or sets the property that bounds with an entry that gets the City from user.
    /// </summary>
    public string City { get; set; }
    public Command PromotionsCommand { get; }

    #endregion

    #region Comments

    /// <summary>
    /// Gets or sets the command is executed when the Submit button is clicked.
    /// </summary>
    public Command SubmitCommand { get; set; }

    #endregion

    #region Methods

    /// <summary>
    /// Initializzing the properties.
    /// </summary>
    private void InitializeProperties()
    {
        this.FullName = new ValidatableObject<string>();
    }


    /// <summary>
    /// Invoked when the Submit button clicked
    /// </summary>
    /// <param name="obj">The object</param>
    private async void SubmitClicked(object obj)
    {

        await NavigationService.NavigateToAsync<AddCardPageViewModel>();

    }
   

    #endregion
}
}
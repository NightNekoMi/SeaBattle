﻿using GalaSoft.MvvmLight;
using SeaBattle.Model;
using SeaBattle.Model.ForField;
using SeaBattle.Model.ForShips;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SeaBattle.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        IMyField _myField;
        IForeignField _foreignField;
        public ObservableCollection<Cell> MyField
        {
            
            get
            {
                List<Cell> result = new List<Cell>();
                foreach (Cell varCell in _myField.Field)
                    result.Add(varCell);
                return new ObservableCollection<Cell>(result);
            }
        }
        //private readonly IDataService _dataService;

        /// <summary>
        /// The <see cref="WelcomeTitle" /> property's name.
        /// </summary>
        public const string WelcomeTitlePropertyName = "WelcomeTitle";

        private string _welcomeTitle = string.Empty;

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
                Set(ref _welcomeTitle, value);
            }
        }

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            _myField = new BattleField();
            _foreignField = new BattleField();
        }
        //public MainViewModel(IDataService dataService)
        //{
        //    _dataService = dataService;
        //    _dataService.GetData(
        //        (item, error) =>
        //        {
        //            if (error != null)
        //            {
        //                // Report error here
        //                return;
        //            }

        //            WelcomeTitle = item.Title;
        //        });
        //}
        
        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}
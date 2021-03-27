﻿using System;
using AnimalPark.Common;
using AnimalPark.Model.Concretes;
using AnimalPark.Model.Interfaces;

namespace AnimalPark.ViewModel.SpeciesViewModels
{
    /// <summary>
    /// DataContext for the control with data specific for JellyFish
    /// </summary>
    public class JellyFishViewModel : BindableBase, IFish
    {
        private JellyFishTYpe _type;

        public JellyFishTYpe Type
        {
            get => _type;
            set
            {
                _type = value;
            }
        }

        public JellyFishViewModel()
        {
            ChildDataErrorDelegate?.Invoke(true);
        }

        public event Action<bool> ChildDataErrorDelegate; 
    }
}

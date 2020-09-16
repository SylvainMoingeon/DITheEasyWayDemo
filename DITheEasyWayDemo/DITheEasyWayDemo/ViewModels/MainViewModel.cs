using DITheEasyWayDemo.models;
using DITheEasyWayDemo.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace DITheEasyWayDemo.ViewModels
{
    public class MainViewModel
    {
        #region Properties
        public ObservableCollection<ICharacter> Characters { get; set; }

        public string Category { get; set; }
        #endregion

        #region Constructors
        public MainViewModel(ICharacterService characterService)
        {
            if (characterService is null)
            {
                throw new ArgumentNullException(nameof(characterService));
            }

            Characters = new ObservableCollection<ICharacter>(characterService.GetCharacters());
            Category = characterService.Category;
        }

        public MainViewModel() : this(DependencyService.Resolve<ICharacterService>())
        {
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Setoryz_Card
{
    [Serializable]
    /// <summary>
    /// GameOptions
    /// </summary>
    /// <param type="class"/>
    public class GameOptions : INotifyPropertyChanged
    {
        private bool playAgainstComputer = true;
        private int numberOfPlayers = 2;
        private ComputerSkillLevel computerSkill = ComputerSkillLevel.Dumb;
        /// <summary>
        ///  NumberOfPlayers
        /// </summary>
        public int NumberOfPlayers
        {
            get { return numberOfPlayers; }
            set
            {
                numberOfPlayers = value;
                OnPropertyChanged(nameof (NumberOfPlayers));
            }
        }
        /// <summary>
        /// Play Against Computer chkbox
        /// </summary>
        public bool PlayAgainstComputer
        {
            get { return playAgainstComputer; }
            set
            {
                playAgainstComputer = value;
                OnPropertyChanged(nameof(PlayAgainstComputer));
            }
        }
        /// <summary>
        /// Computer Skill Level
        /// </summary>
        public ComputerSkillLevel ComputerSkill
        {
            get { return ComputerSkill; }
            set
            {
                computerSkill = value;
                OnPropertyChanged(nameof(ComputerSkill));
            }
        }
        /// <summary>
        /// Property Changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// On Property Changed
        /// </summary>
        /// <param name="propertyName"></param>
        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    [Serializable]
    /// <summary>
    /// Computer Skill Level
    /// </summary>
    public enum ComputerSkillLevel
    {
        Dumb,
        Good,
        Cheats
    }
}

using Engine.Factories;
using Engine.Models;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Engine.ViewModels
{
    public class GameSession : INotifyPropertyChanged
    {
        private Location _currentLocation;
        public Player CurrentPlayer { get; set; }
        public Location CurrentLocation 
        {
            get { return _currentLocation; }
            set
            {
                _currentLocation = value;
                OnPropertyChanged("CurrentLocation");
                OnPropertyChanged("HasLocationToNorth");
                OnPropertyChanged("HasLocationToSouth");
                OnPropertyChanged("HasLocationToWest");
                OnPropertyChanged("HasLocationToEast");

            }
        }
           public bool HasLocationToNorth
        {
            get
            {
                return CurrentLocation.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1) != null;
            }
        }
        public bool HasLocationToSouth
        {
            get
            {
                return CurrentLocation.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate - 1) != null;
            }
        }
        public bool HasLocationToWest
        {
            get
            {
                return CurrentLocation.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate ) != null;
            }
        }
        public bool HasLocationToEast
        {
            get
            {
                return CurrentLocation.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate ) != null;
            }
        }
        public World CurrentWorld { get; set; }
        
        public GameSession()
        {
        
            CurrentPlayer = new Player();
            CurrentPlayer.Name = "Nolan";
            CurrentPlayer.CharacterClass = "Fighter";
            CurrentPlayer.HitPoints = 10;
            CurrentPlayer.Gold = 1000000;
            CurrentPlayer.ExperiencePoints = 0;
            CurrentPlayer.Level = 1;

            WorldFactory worldFactory = new WorldFactory();
            CurretWorld = worldFactory.CreateWorld();
            CurrentLocation = CurrentWorld.LocationAt(0, 0)
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
        public void MoveNorth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate + 1);
        }
        public void MoveSouth()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate, CurrentLocation.YCoordinate- 1);
        }
        public void MoveWest()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate - 1, CurrentLocation.YCoordinate);
        }
        public void MoveEast()
        {
            CurrentLocation = CurrentWorld.LocationAt(CurrentLocation.XCoordinate + 1, CurrentLocation.YCoordinate);
        }

    }
}

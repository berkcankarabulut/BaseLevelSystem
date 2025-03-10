using System;
using UnityEngine; 

namespace Project.LevelSystem.Runtime
{
    public abstract class BaseLevel : ILevel
    {
        private int _currentLevel;
        private int _maxLevel;
        private int _experience;
        private LevelData _levelData; 
        private Action _onLevelUp;
        private Action<int, int> _onExperienceChanged; 

        public int MinLevel { get; protected set; } = 1;
        public int MaxLevel => _maxLevel;
        public LevelData LevelData => _levelData;

        public BaseLevel(LevelData levelData) { 
            this._levelData = levelData;
            this._maxLevel = levelData.experienceRequired.Length; 
            this._currentLevel = MinLevel; 
            this._experience = 0;
        }

        public void GainExperience(int amount) {
            int oldExperience = _experience;
            _experience += amount;
            CheckLevelUp();
            _onExperienceChanged?.Invoke(oldExperience, _experience);
        }

        private void CheckLevelUp() { 
            while (_currentLevel < _maxLevel && _experience >= _levelData.experienceRequired[_currentLevel - 1]) 
            {
                _experience -= _levelData.experienceRequired[_currentLevel - 1];
                _currentLevel++;
                _onLevelUp?.Invoke();
            }                 
        } 

        public int GetCurrentLevel() {
            return _currentLevel;
        }

        public int GetExperience() {
            return _experience;
        }

        public void AddLevelUpListener(Action listener)
        {
            _onLevelUp += listener;
        }

        public void RemoveLevelUpListener(Action listener)
        {
            _onLevelUp -= listener;
        }

        public void AddExperienceChangedListener(Action<int, int> listener)
        {
            _onExperienceChanged += listener;
        }

        public void RemoveExperienceChangedListener(Action<int, int> listener)
        {
            _onExperienceChanged -= listener;
        }
    }
}

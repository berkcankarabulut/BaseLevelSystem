using UnityEngine;

namespace Project.LevelSystem.Runtime
{
    [CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/LevelData", order = 1)]
    public abstract class LevelData : ScriptableObject {
        public int[] experienceRequired;  
    } 
} 
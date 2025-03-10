using UnityEngine;

namespace Project.LevelSystem.Runtime
{
    [CreateAssetMenu(fileName = "LevelData", menuName = "ScriptableObjects/LevelData", order = 1)]
    public class LevelData : ScriptableObject {
        public int[] experienceRequired;  
    } 
} 
namespace Project.LevelSystem.Runtime
{
    public interface ILevel 
    {
        void GainExperience(int amount);
        int GetCurrentLevel();
        int GetExperience();
    } 
} 
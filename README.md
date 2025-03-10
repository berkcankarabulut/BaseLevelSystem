  <div class="container">
        <h1>🎮 Level System</h1>
         <p><strong>Base is a flexible and extensible level system.</strong></p>
        
  <h2>✨ Features</h2>
        <ul>
            <li>Abstract base implementation for creating various level systems</li>
            <li>Experience-based progression</li>
            <li>Customizable level requirements via ScriptableObjects</li>
            <li>Event-driven architecture for easy integration with UI and other systems</li>
        </ul>
        
  <h2>📂 Structure</h2>
        <p>The system consists of three main components:</p>
        <ul>
            <li><strong>ILevel</strong>: Interface that defines the basic functionality for any level system</li>
            <li><strong>BaseLevel</strong>: Abstract implementation of the <code>ILevel</code> interface that handles the core leveling mechanics</li>
            <li><strong>LevelData</strong>: ScriptableObject for configuring experience requirements for each level</li>
        </ul>
        
  <h2>🚀 Usage</h2>
        <h3>Basic Setup</h3>
        <p>Create a <code>LevelData</code> ScriptableObject with your level progression requirements:</p>
        <pre>// In the Unity editor
// Right-click in the Project window > Create > ScriptableObjects > LevelData
// Then set the experience requirements for each level in the inspector</pre>
        
  <h3>Create a Concrete Implementation of <code>BaseLevel</code></h3>
        <pre><code>public class CharacterLevel : BaseLevel 
{
    public CharacterLevel(LevelData levelData) : base(levelData) 
    {
        // Additional initialization
    } 
    // Additional methods specific to character leveling
}</code></pre>
        
  <h3>Subscribe to Events</h3>
        <pre><code>characterLevel.AddLevelUpListener(() => {
        Debug.Log("Level up! Current level: " + characterLevel.GetCurrentLevel());
});

characterLevel.AddExperienceChangedListener((oldExp, newExp) => {
    Debug.Log($"Experience changed from {oldExp} to {newExp}");
});</code></pre>
        
  <h3>Award Experience</h3>
        <pre><code>characterLevel.GainExperience(50);</code></pre>
        
  <h3>Getting Level Information</h3>
        <pre><code>// Get current level
int level = characterLevel.GetCurrentLevel();

// Get current experience in this level
int exp = characterLevel.GetExperience();

// Get minimum level
int minLevel = characterLevel.MinLevel;

// Get maximum level
int maxLevel = characterLevel.MaxLevel;</code></pre>
        
  <h2>🔧 Extending the System</h2>
        <p>The system is designed to be extended for various game elements. Create custom level systems by extending <code>BaseLevel</code> for different game objects like characters, weapons, skills, etc.</p>
        
  <h2>⚙️ Implementation Details</h2>
        <p>The <code>BaseLevel</code> class provides:</p>
        <ul>
            <li>Experience tracking and level progression</li>
            <li>Event callbacks for level-up and experience changes</li>
            <li>Min/Max level constraints</li>
            <li>Core leveling mechanics that can be reused across different game elements</li>
        </ul>
        
  <h2>📜 License</h2>
        <p>This project is licensed under the <strong>MIT License</strong> - see the LICENSE file for details.</p>
  

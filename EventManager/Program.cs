using System;

// README.md를 읽고 코드를 작성하세요.
ScoreSystem scoreSystem = new ScoreSystem();
AchievementSystem achievementSystem = new AchievementSystem();
SoundSystem soundSystem = new SoundSystem();

EventManager.OnGameEvent += soundSystem.SoundEvent;
EventManager.OnGameEvent += scoreSystem.ChangeScore;
EventManager.OnGameEvent += achievementSystem.Achievement;

EventManager.TriggerEvent("ScoreChanged", 100);
EventManager.TriggerEvent("Achievement", "첫 번째 적 처치");
EventManager.TriggerEvent("GameOver", null);
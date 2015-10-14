using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

    public EnemyPool enemyPool;
    public PusherHandler pusher;
    private Levels.Level CurrentLevel;

    // Use this for initialization
    void Start () {
        NextLevel();
    }

	// Update is called once per frame
	void Update () {
        CurrentLevel.Update(Time.deltaTime);
	}

    public void NextLevel()
    {
        if (CurrentLevel == null){
            CurrentLevel = new Levels.Level1(this);

        }else if(CurrentLevel is Levels.Level1){
            CurrentLevel.Exit();
            CurrentLevel = new Levels.Level2(this);

        }else if (CurrentLevel is Levels.Level2){
            CurrentLevel.Exit();
            CurrentLevel = new Levels.Level3(this);
        }
        CurrentLevel.CurrentLevelState = Levels.Level.LEVEL_STATE.RUNNING;
    }

    public void GameOver()
    {
        CurrentLevel.Exit();
        CurrentLevel = null;
        NextLevel();

        pusher.Reset();

    }
}

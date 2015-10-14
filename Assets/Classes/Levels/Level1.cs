using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Levels
{
    class Level1 : Level
    {
        public const float TIME2SPAWN = 2.0f;
        private float time2SpawnDelta;
        private float completeTime;

        public Level1(GameManager gameMgr)
        {
            time2SpawnDelta = TIME2SPAWN;
            this.gameManager = gameMgr;
        }

        public override void Exit()
        {
        }

        public override void Update(float deltaTime)
        {
            switch (CurrentLevelState)
            {
                case LEVEL_STATE.INIT:
                    break;
                case LEVEL_STATE.RUNNING:
                    time2SpawnDelta -= deltaTime;
                    completeTime += time2SpawnDelta;
                    if (time2SpawnDelta <= 0.0f)
                    {
                        UnityEngine.GameObject ballz = gameManager.enemyPool.GetEnemyInstanceByName("Ballz");
                        Bounds bounds = Utils.OrthographicBounds(Camera.main);
                        ballz.transform.position = new Vector3(bounds.extents.x, UnityEngine.Random.Range(0.0f, bounds.extents.y), 0.0f);
                        ballz.transform.parent = gameManager.transform;
                        ballz.GetComponent<Rigidbody2D>().AddForce(new Vector2(-100.0f, 0.0f));
                        time2SpawnDelta = TIME2SPAWN;
                    }
                    break;
            }
        }
    }
}

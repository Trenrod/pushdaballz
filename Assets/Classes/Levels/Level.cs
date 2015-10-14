using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Levels
{
    public abstract class Level
    {
        public GameManager gameManager;

        public enum LEVEL_STATE
        {
            INIT, RUNNING
        }
        public LEVEL_STATE CurrentLevelState;

        public abstract void Exit();
        public abstract void Update(float deltaTime);
    }
}

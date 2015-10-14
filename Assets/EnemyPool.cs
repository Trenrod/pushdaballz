using UnityEngine;
using System.Collections.Generic;

public class EnemyPool : MonoBehaviour {

    public List<GameObject> Enemies;
    private Dictionary<string, GameObject> enemyMap = new Dictionary<string, GameObject>();

	// Use this for initialization
	void Start () {
	    foreach(GameObject go in Enemies)
        {
            enemyMap.Add(go.name, go);
        }
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public GameObject GetEnemyInstanceByName(string name)
    {
        GameObject goPrefab;
        enemyMap.TryGetValue(name, out goPrefab);
        return GameObject.Instantiate(goPrefab);
    }
}

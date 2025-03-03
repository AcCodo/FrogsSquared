using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/SpawnManagerScriptableObject", order = 1)]
public class TestSO : ScriptableObject
{
    public string prefabName;
    public int iHoldStuff;

    public int numberOfPrefabsToCreate;
    public Vector3[] spawnPoints;
}

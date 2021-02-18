using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New AppleShow", menuName = "AppleShow", order = 51)]
public class AppleShow : ScriptableObject
{
    public SpawnPointData[] spawnPoints = new SpawnPointData[2];
    public SpawnPointData2[] spawnPoints2 = new SpawnPointData2[2];
    public float showApple;
    public float occurenseOneApple;
    public float occurenseTwoApple;
 
    [System.Serializable]
    public class SpawnPointData
    {
        public Vector3 position;
        public Vector3 angle;
    }

    [System.Serializable]
    public class SpawnPointData2
    {
        public Vector3 position2;
        public Vector3 angle2;
    }
}

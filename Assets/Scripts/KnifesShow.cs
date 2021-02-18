using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifesShow : MonoBehaviour
{
    [SerializeField] private GameObject _knife;
    [SerializeField] private GameObject _knife1;
    [SerializeField] private GameObject _knife2;
    [SerializeField] private Transform _parent;

    public SpawnPointData[] spawnPoints = new SpawnPointData[2];
    public SpawnPointData2[] spawnPoints2 = new SpawnPointData2[2];
    public SpawnPointData3[] spawnPoints3 = new SpawnPointData3[2];
    public float showKnife;

    [System.Obsolete]
    private void Awake()
    {
        showKnife = Random.Range(0, 100);

        if (showKnife <= 60)
        {
            var index = Random.Range(0, spawnPoints.Length);
            var spawnPoint = spawnPoints[index];

            GameObject newKnife = Instantiate<GameObject>(_knife, spawnPoint.position, Quaternion.EulerAngles(spawnPoint.angle));
            newKnife.transform.SetParent(_parent);
        }
        if (showKnife <= 40)
        {
            var index = Random.Range(0, spawnPoints2.Length);
            var spawnPoint2 = spawnPoints2[index];

            GameObject newKnife1 = Instantiate<GameObject>(_knife1, spawnPoint2.position2, Quaternion.EulerAngles(spawnPoint2.angle2));
            newKnife1.transform.SetParent(_parent);
        }
        if (showKnife <= 20)
        {
            var index = Random.Range(0, spawnPoints3.Length);
            var spawnPoint2 = spawnPoints3[index];

            GameObject newKnife2 = Instantiate<GameObject>(_knife2, spawnPoint2.position3, Quaternion.EulerAngles(spawnPoint2.angle3));
            newKnife2.transform.SetParent(_parent);
        }
    }

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

    [System.Serializable]
    public class SpawnPointData3
    {
        public Vector3 position3;
        public Vector3 angle3;
    }
}

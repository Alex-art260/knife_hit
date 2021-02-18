using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleShow2 : MonoBehaviour
{
   [SerializeField] private AppleShow _appleShowMain;
   [SerializeField] private GameObject _apple;
   [SerializeField] private GameObject _apple1;
   [SerializeField] private Transform _parent;

    [System.Obsolete]
    private void Awake()
    {
        _appleShowMain.showApple = Random.Range(0, 100);

        if (_appleShowMain.showApple <= _appleShowMain.occurenseOneApple)
        {
            var index = Random.Range(0, _appleShowMain.spawnPoints.Length);
            var spawnPoint = _appleShowMain.spawnPoints[index];

            GameObject newApple = Instantiate<GameObject>(_apple, spawnPoint.position, Quaternion.EulerAngles(spawnPoint.angle));
            newApple.transform.parent = _parent;
        }
        if (_appleShowMain.showApple <= _appleShowMain.occurenseTwoApple)
        {
            var index = Random.Range(0, _appleShowMain.spawnPoints2.Length);
            var spawnPoint2 = _appleShowMain.spawnPoints2[index];

            GameObject newApple1 = Instantiate<GameObject>(_apple1, spawnPoint2.position2, Quaternion.EulerAngles(spawnPoint2.angle2));
            newApple1.transform.parent = _parent;
        }
    }
}

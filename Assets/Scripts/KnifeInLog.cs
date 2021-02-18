using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnifeInLog : MonoBehaviour
{
    [SerializeField] private GameObject _knife1;
    [SerializeField] private GameObject _knife2;
    [SerializeField] private GameObject _knife3;
    [SerializeField] private Transform _parent;

    public Vector3 positionKnife1;
    public Vector3 positionKnife2;
    public Vector3 positionKnife3;

    private void Awake()
    {
        GameObject newKnife1 = Instantiate<GameObject>(_knife1, positionKnife1, Quaternion.identity);
        newKnife1.transform.SetParent(_parent);

        GameObject newKnife2 = Instantiate<GameObject>(_knife2, positionKnife2, Quaternion.identity);
        newKnife1.transform.SetParent(_parent);

        GameObject newKnife3 = Instantiate<GameObject>(_knife3, positionKnife3, Quaternion.identity);
        newKnife1.transform.SetParent(_parent);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountHitKnife : MonoBehaviour
{
    [SerializeField] private Text _countText;

    public static int scoreValue = 0;

    void Update()
    {
        _countText.text = " " + scoreValue;
    }

}

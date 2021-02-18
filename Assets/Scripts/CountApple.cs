using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountApple : MonoBehaviour
{
    [SerializeField] private Text _countApple;

    public static int appleValue = 0;

    private void Update()
    {
        _countApple.text = " " + appleValue;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountLevel : MonoBehaviour
{
    [SerializeField] private Text _countLevelText;

    public static int countLevelValue = 1;

    private void Update()
    {
        _countLevelText.text = "LEVEL " + countLevelValue;
    }
}

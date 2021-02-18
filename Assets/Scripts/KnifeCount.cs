using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KnifeCount : MonoBehaviour
{
    [NonSerialized] public int hit = 1; // текущее количество ножей в инвентаре от максимального
    [NonSerialized] public int numberOfKnifes = 1; // общее количество ножей в инвентаре

    public Image[] knifes;

    private void Awake()
    {
      numberOfKnifes = UnityEngine.Random.Range(8, 15);
      hit = numberOfKnifes;

      for (var i = numberOfKnifes - 1; i < knifes.Length; i++)
      {
        knifes[i].enabled = false;
      }
    }

    private void Update()
    {
      for (int i = 0; i < knifes.Length; i++)
      {
          if( i < hit)
          {
            knifes[i].enabled = true;
          }
          else
          {
            knifes[i].color = Color.black;
          }

          if (i < numberOfKnifes)
          {
            knifes[i].enabled = true;
          }
          else
          {
            knifes[i].enabled = false;
          }
      }
    }
}

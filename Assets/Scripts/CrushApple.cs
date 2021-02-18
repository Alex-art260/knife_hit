using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrushApple : MonoBehaviour
{
    [SerializeField] private GameObject _apple;
    [SerializeField] private GameObject _partApple1;
    [SerializeField] private GameObject _partApple2;
 
    [SerializeField] private HighScoreApple _highScoreAppleCount;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Knife")
        {
            InitPartApple();
            HighScoreApple.highScoreAppleValue += 2;
            _highScoreAppleCount.HighScoreAppleCount();
        }
    }

    private void InitPartApple()
    {
        Destroy(_apple);

        GameObject crashApple = Instantiate(_partApple1, transform.position, transform.rotation);
        GameObject crashApple1 = Instantiate(_partApple2, transform.position, transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLog : MonoBehaviour
{
    [SerializeField] private KnifeCount _knfCount;

    [SerializeField] private GameObject _log;
    [SerializeField] private GameObject _partLog;
    [SerializeField] private GameObject _partLog1;
    [SerializeField] private GameObject _partLog2;

    public float leftSidePowerMin;
    public float leftSidePowerMax;
    public float rightSidePowerMin;
    public float rightSidePowerMax;
    public int minPause;
    public int maxPause;
    public float changePower;

    private float _power;
    private float _leftPower;
    private float _rightPower;
    private float _pauseRotation;

    private bool _rotationOn = true;

    private void Start()
    {
        changePower = Random.Range(0, 100);
        _pauseRotation = Random.Range(minPause, maxPause);

        CrashLog();
        StartCoroutine(PauseRotation());

        _leftPower = Random.Range(leftSidePowerMin, leftSidePowerMax);
        _rightPower = Random.Range(rightSidePowerMin, rightSidePowerMin);

        if (changePower > 50)
        {
            _power = _leftPower;
        }

        if(changePower < 50)
        {
            _power = _rightPower;
        }
    }

    IEnumerator PauseRotation()
    {
        yield return new WaitForSeconds(_pauseRotation);

        _rotationOn = false;

        StartCoroutine(TurnOnRotation());
    }

    IEnumerator TurnOnRotation()
    {
        yield return new WaitForSeconds(1f);

        _rotationOn = true;

        StartCoroutine(PauseRotation());
    }

    private void Update()
    {
        if (_rotationOn)
            UpdateRotation();
    }

    private void UpdateRotation()
    {
        transform.Rotate(0, 0, _power * Time.deltaTime);
    }
    public void CrashLog()
    {
        if(_knfCount.hit == 0)
        {
            Destroy(_log);

            GameObject crashLog = Instantiate(_partLog, transform.position, transform.rotation);
            GameObject crashLog1 = Instantiate(_partLog1, transform.position, transform.rotation);
            GameObject crashLog2 = Instantiate(_partLog2, transform.position, transform.rotation);
        }
    }
}

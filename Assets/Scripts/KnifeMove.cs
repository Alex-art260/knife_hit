using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class KnifeMove : MonoBehaviour
{
    [SerializeField] private GameObject _knifePrefab;
    [SerializeField] private Rigidbody2D _rb;
    [SerializeField] private Rigidbody2D _rbReflect;
    [SerializeField] private Collider2D _colliderKnife;
    [SerializeField] private Transform _knife;
    [SerializeField] private Transform _parent;
    [SerializeField] private AudioSource _hitWood;
    [SerializeField] private AudioSource _hitMetal;
 
    [SerializeField] private KnifeCount _knfCount;
    [SerializeField] private RotationLog _rotLog;
    [SerializeField] private HighScore _highScore;
    [SerializeField] private LevelManager _levelManager;
    [SerializeField] private Button _button;
    public float speed;
    public bool isShoot = false;
    public int speedReflect;
    public bool knifeInLog = false;

    

    private UnityEngine.Object explosion;
    private Vector2  _whereToSpawn; 
    private void Start()
    {
        Vibration.Init();
        explosion = Resources.Load("Explosion");
    }
    void FixedUpdate()
    {
        if(Input.GetMouseButtonDown(0))
        {
            MoveKnife();
        }
    }

    public void MoveKnife()
    {
        if (knifeInLog == false)
        {
            _rb.velocity = transform.up * speed;
        }
    }

    private void SpawnKnife()
    {
        _whereToSpawn = new Vector3(0.1f, -3, 1);
        GameObject newKnife =  Instantiate(_knifePrefab, _whereToSpawn, Quaternion.identity);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Log")
        {


            GameObject explosionRef = (GameObject)Instantiate(explosion);
            explosionRef.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);

            _knfCount.hit--;

            isShoot = true;

            SpawnKnife();
            
            _knifePrefab.transform.SetParent(_parent);
            _rb.constraints = RigidbodyConstraints2D.FreezeAll;
            
            _button.enabled = false;
            Destroy(this);

            WinLevel();

            CountHitKnife.scoreValue += 1;
            _highScore.HighScoreCount();

            _hitWood.Play();

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Knife")
        {
            knifeInLog = true;

            Vector3 newDirection = Vector3.Reflect(transform.forward, collision.contacts[0].normal);
            transform.rotation = Quaternion.LookRotation(newDirection);
            _rbReflect.velocity = transform.position * speedReflect;
           _levelManager.Invoke("GameOver", 1f);
            _hitMetal.Play();
            Vibration.Vibrate(250);
        }
    }




    private void WinLevel()
    {
        if (_knfCount.hit == 0)
        {
            _rotLog.CrashLog();
            _levelManager.Invoke("LoadLevel", 2f);
        }
    }
  
}

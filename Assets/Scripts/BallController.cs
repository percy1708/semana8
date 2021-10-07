using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallController : MonoBehaviour
{
    public float velocityX = 10f;

    private const string ENEMY_TAG = "Enemy"; 
    private const string fin_f= "fin"; 

    private Rigidbody2D rb;
    private GameController _game;
    private SoundEfectsController _Sounds;
 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        _game = FindObjectOfType<GameController>();
        _Sounds = FindObjectOfType<SoundEfectsController>();
        Destroy(this.gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(velocityX, rb.velocity.y);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag != "Player")
        {
            // Destroy(this.gameObject);

            if (other.gameObject.CompareTag(ENEMY_TAG))
            {

                Destroy(other.gameObject);
                _game.PlusScore(1);
                Debug.Log(_game.GetScore());

            }
        }
    }
  
}

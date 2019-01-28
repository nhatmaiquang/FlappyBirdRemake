using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Bird : MonoBehaviour
{
    public float upForce = 200f;

    private bool isDead = false;
    private Rigidbody2D rb2d;

    void Start()
    {
      rb2d = GetComponent<Rigidbody2D> ();
    }

    void Update()
    {
      if (isDead == false)
      {
        if (Input.GetMouseButtonDown (0))
        {
          rb2d.velocity = Vector2.zero;
          rb2d.AddForce (new Vector2 (0, upForce));
        }
      }
    }

    void OnCollisionEnter2D()
    {
      isDead = true;
    }
}

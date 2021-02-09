using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rigidbody;
    public float forse;
    public int score;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rigidbody.AddForce(Vector2.up * forse, ForceMode2D.Impulse);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("LOOOSER");
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        score++;
        Debug.Log(score);
    }
}

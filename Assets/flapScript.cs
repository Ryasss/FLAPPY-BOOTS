using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flapScript : MonoBehaviour
{

    public Rigidbody2D myRigidbody;
    public float flapStrength;
    public logicScript logic;
    public bool isAlive = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<logicScript>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) == true && isAlive == true)
        {
            myRigidbody.linearVelocity = Vector2.up * flapStrength;
        }

        if (transform.position.y > 15 || transform.position.y < -15)
        {
            logic.gameOver();
            isAlive = false;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.gameOver();
        isAlive = false;
    }
}

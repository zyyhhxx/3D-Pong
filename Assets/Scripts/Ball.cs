using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public ScoreManager sm;
    public float speed = 1;

    private Rigidbody r;
    private float xSpeed;
    private float ySpeed;
    private float zSpeed;

    // Start is called before the first frame update
    void Start()
    {
        r = this.GetComponent<Rigidbody>();
        sm = GameObject.Find("Canvas").GetComponent<ScoreManager>();

        //Set up the initial speed
        float[] signs = { Random.Range(-1, 1) , Random.Range(-1, 1) , Random.Range(-1, 1) };
        xSpeed = signs[0] >= 0 ? speed : -speed;
        ySpeed = signs[1] >= 0 ? speed : -speed;
        zSpeed = signs[2] >= 0 ? speed : -speed;
        r.velocity = new Vector3(xSpeed, ySpeed, zSpeed);
    }

    // Update is called once per frame
    void Update()
    {
        r.velocity = new Vector3(xSpeed, ySpeed, zSpeed);
    }

    void OnCollisionEnter(Collision collision)
    {
        GameObject go = collision.gameObject;

        if (go == sm.player1Zone)
        {
            sm.IncreasePlayer2Score();
            Destroy(gameObject);
        }
        else if(go == sm.player2Zone)
        {
            sm.IncreasePlayer1Score();
            Destroy(gameObject);
        }
        else if(go.tag == "XPlane")
        {
            r.velocity = new Vector3(-xSpeed, ySpeed, zSpeed);
            xSpeed = -xSpeed;
        }
        else if (go.tag == "YPlane")
        {
            r.velocity = new Vector3(xSpeed, -ySpeed, zSpeed);
            ySpeed = -ySpeed;
        }
        else if (go.tag == "ZPlane")
        {
            r.velocity = new Vector3(xSpeed, ySpeed, -zSpeed);
            zSpeed = -zSpeed;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    public KeyCode left = KeyCode.A;
    public KeyCode right = KeyCode.D;
    public float verticalSpeed = 1.0f;
    public float horizontalSpeed = 1.0f;

    private Rigidbody r;

    // Start is called before the first frame update
    void Start()
    {
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 velocityTemp = new Vector3(0, 0, 0);

        //Vertical movement
        if (Input.GetKey(up))
        {
            velocityTemp.y = 1;
        }
        else if (Input.GetKey(down))
        {
            velocityTemp.y = -1;
        }

        //Horizontal movement
        if (Input.GetKey(left))
        {
            velocityTemp.z = -1;
        }
        else if (Input.GetKey(right))
        {
            velocityTemp.z = 1;
        }

        r.velocity = velocityTemp;
    }
}

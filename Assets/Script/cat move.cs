using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catmove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
            if(transform.position.x>8f)
            {
                transform.position = new Vector3(8f ,transform.position.y,transform.position.z);
            }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
            if (transform.position.x < -8f)
            {
                transform.position = new Vector3(-8f, transform.position.y, transform.position.z);
            }
        }

    }
    public void rightbutton()
    {
        transform.Translate(1, 0, 0);
    }
    public void leftbutton()
    {
        transform.Translate(-1, 0, 0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class genlife : MonoBehaviour
{
    public GameObject life;
    float span = 5.0f;
    float delta = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        delta += Time.deltaTime;
        if (delta > span)
        {
            delta = 0;
            GameObject go = Instantiate(life);
            float px = Random.Range(-8.6f, 8.6f);
            go.transform.position = new Vector3(px, 5.8f, 0);
        }
    }
}

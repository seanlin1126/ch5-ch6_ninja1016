using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;

public class arrowgener : MonoBehaviour
{
    public GameObject arrow;
    float span = 0.5f;
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
            GameObject go = Instantiate(arrow);
            float px = Random.Range(-8.6f, 8.6f);
            go.transform.position = new Vector3(px, 5.8f, 0);
        }
    }
}

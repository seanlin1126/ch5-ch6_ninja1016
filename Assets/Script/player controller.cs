using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.PlayerLoop;
using UnityEngine.SceneManagement;


public class playercontroller : MonoBehaviour
{
    
    Rigidbody2D move;
    Animator Animator;
    public float jumpforce = 680.0f;
    float walkforce = 30;
    float walkmaxforce = 2;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 60;
        move = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        Time.timeScale = 1;
    }

    // Update is called once per frame
    async Task Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            move.AddForce(transform.up * jumpforce);
        }
        int key = 0;
        if (Input.GetKey(KeyCode.RightArrow)) key = 1;
        if (Input.GetKey(KeyCode.LeftArrow)) key = -1;
        float speedx = Mathf.Abs(move.velocity.x);
        if (speedx < walkmaxforce)
            move.AddForce(transform.right *key* walkforce);
        if (key != 0)
        {
            transform.localScale = new Vector3(key*1.5f, 1.5f, 1.5f);
        }
        Animator.speed = speedx/2.0f;
        if (transform.position.y<-8.0f)
        {
            SceneManager.LoadScene("ch6_gamescene");
        }
        if (transform.position.y > 8.0f)
        {
            SceneManager.LoadScene("ch6_gamescene");
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
        if (transform.position.x<5.87&& transform.position.x>4.67 && transform.position.y<1.47)
        {
            SceneManager.LoadScene("ch6_gamescene");
        }

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        SceneManager.LoadScene("End Scene"); 
    }
}

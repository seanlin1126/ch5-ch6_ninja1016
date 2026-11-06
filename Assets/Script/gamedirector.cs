using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamedirector : MonoBehaviour
{
    GameObject hp;
    float counttime = 0;
    public TextMeshProUGUI show;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        hp = GameObject.Find("hp");
    }

    // Update is called once per frame
    public void Decreasehp()
    {
        hp.GetComponent<Image>().fillAmount -= 0.1f;
    }
    public void increasehp()
    {
        hp.GetComponent<Image>().fillAmount += 0.3f;
    }
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("menu");
        }
        counttime += Time.deltaTime;
        show.text=(15-counttime).ToString("f1");
        if(counttime>15)
        {
            Time.timeScale = 0;
            if(hp.GetComponent<Image>().fillAmount>=0.6)
            {
                SceneManager.LoadScene("ch6_gamescene");
            }
            else
            {
                SceneManager.LoadScene("ch5");
            }
        }
    }
}

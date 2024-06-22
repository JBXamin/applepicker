using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    // Start is called before the first frame update
    public static float score = 0f;
    public static float live = 3f;
    public TMP_Text scoreT;
    public TMP_Text liveT;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(live == 0f)
        {
            live = 3f;
            score = 0f;
            SceneManager.LoadScene(0);
        }
        liveT.text = live.ToString();
        scoreT.text = score.ToString();
    }
}

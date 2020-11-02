using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public player player;
    public float resetTimer = 2f;

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if(player.HoldingBall == false)
        {
            resetTimer -= Time.deltaTime;
            if(resetTimer <=0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);

            }
        }
    }
}

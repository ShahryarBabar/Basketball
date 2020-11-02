using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreArea : MonoBehaviour
{
    public GameObject effectObject;
    void Start()
    {
        effectObject.SetActive(false);
    }
    void OnTriggerEnter(Collider otherCollider)
    {
        
        if(otherCollider.GetComponent<Ball> () != null)
        {
            effectObject.SetActive(true);
            StartCoroutine(Next());
           
        }

    }

    IEnumerator Next()
    {
       
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
}

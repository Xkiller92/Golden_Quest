using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartTab : MonoBehaviour
{
    public GameObject enemy;
    public GameObject player; 

    // Update is called once per frame
    void Update()
    {
        if (enemy.GetComponent<EnemyMovement>().health == 0 || player.GetComponent<PlayerMovement>().health == 0)
        {
            SceneManager.LoadScene("finish");
        }   
    }
}

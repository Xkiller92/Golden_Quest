using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    public Image healthBar;
    public GameObject combat;
    public GameObject enemy;
    float xScale;

    public void DisplayBar()
    {
       xScale = healthBar.rectTransform.localScale.x;
        xScale -= combat.GetComponent<Combat>().damage  / enemy.GetComponent<EnemyMovement>().maxHealth;
        healthBar.rectTransform.localScale = new Vector3(xScale, 1, 1); 

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public GameObject GameOverText, restartButton, blood;
    // Start is called before the first frame update
    void Start()
    {
        GameOverText.SetActive(false);
        restartButton.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag.Equals("Enemy"))
        {
            Instantiate(blood, transform.position, Quaternion.identity);
            GameOverText.SetActive(true);
            restartButton.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}

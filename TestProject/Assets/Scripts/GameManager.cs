using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    private GameObject sphere;
    private GameObject enemySphere;
    public GameObject endScreen;
    public Text resultText;
    public float endHeight = 40f;

    private void Start()
    {
        sphere = GameObject.FindWithTag("Player");
        enemySphere = GameObject.FindWithTag("Enemy");
    }

    private void FixedUpdate()
    {
        if (sphere != null && enemySphere != null)
        {
            if (sphere.transform.position.y < endHeight)
            {
                EndGame("YOU LOST");
            }
            if (enemySphere.transform.position.y < endHeight)
            {
                EndGame("YOU WON");
            }
        }
    }

    private void EndGame(string ressultMessage)
    {
        Time.timeScale = 0;
        resultText.text = ressultMessage;
        endScreen.SetActive(true);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbCollect : MonoBehaviour
{
    private GameObject gameManager;
    private ScoreBoard scoreBoard;

    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        scoreBoard = gameManager.GetComponent<ScoreBoard>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            scoreBoard.ScoreCount();
            collision.gameObject.SetActive(false);
        }
    }
}

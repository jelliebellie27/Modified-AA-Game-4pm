using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pin : MonoBehaviour
{
    private bool isPinned = false;
    public float speed = 5f;
    public Rigidbody2D rb;

    void Update()
    {
        if (!isPinned)
            rb.MovePosition(rb.position + Vector2.up * speed * Time.deltaTime);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Rotator")
        {
           transform.SetParent(col.transform);
            //go faster: col.GetComponent<Rotator>().speed + 50f;  faster on medium??
            //reverse direction col.GetCompononet<Rotator>().speed * -1, can make it reverse directions on hard
            //f after the number means the number is a float
            Score.PinCount++;
            isPinned = true;
        }
        else if (col.tag == "Pin")
        {
            Debug.Log("rounds: " + keepData.RoundsPlayed.ToString());
            if (keepData.HighScore < keepData.PlayerScore)
            {
                keepData.HighScore = keepData.PlayerScore;
            }
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
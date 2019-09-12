using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    GameObject ball;
    SpriteRenderer spriteRender;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject == ball)
        {
            spriteRender.color = new Color32((byte)Random.Range(0, 255), (byte)Random.Range(0, 255), (byte)Random.Range(0, 255), 255);
            LevelManager.AddScore(1);
        }
    }

    private void Start()
    {
        spriteRender = GetComponent<SpriteRenderer>();
        ball = FindObjectOfType<Ball>().gameObject;
    }
}

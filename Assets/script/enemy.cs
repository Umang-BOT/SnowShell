using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    // Start is called before the first frame update

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "snowman")
        {
            Destroy(collision.gameObject);
            GameManager.instance.GameOver();
        }
        else if (collision.gameObject.tag == "ground")
        {
            Destroy(gameObject);
            GameManager.instance.increment();
        }
    }
}

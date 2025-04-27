using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Candy : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Star"))
        {
            UIManager.Instance.addStar();
            Destroy(collision.gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collect : MonoBehaviour
{

    private void Start()
    {
        GameManager.Instance.TotalCollectable++;
        GameManager.Instance.ShowInfo();
    }


    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            GameManager.Instance.Score++;
            GameManager.Instance.TotalCollectable--;
            GameManager.Instance.ShowInfo();
            Destroy(gameObject);
        }
    }
}

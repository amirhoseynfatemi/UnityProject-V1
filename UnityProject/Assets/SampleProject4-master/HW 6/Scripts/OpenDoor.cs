using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OpenDoor : MonoBehaviour
{
    public Animator Anim;
    public int SceneIndexForLoad;
    public GameManager GameManager;
    public int Level;
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(GameManager.TotalCollectable < 1 && GameManager.TotalEnemy < 1)
            {
                Debug.Log("Open Door");
                Anim.Play("Open");

                if(Level != 2)
                    SceneManager.LoadScene(SceneIndexForLoad);
            }
               
        }
      
    }

}

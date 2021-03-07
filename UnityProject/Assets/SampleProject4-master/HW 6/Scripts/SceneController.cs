
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
    public bool MouseShow;


    public void LoadScene(int Index) => SceneManager.LoadScene(Index);
    
    private void Start()
    {
        if(MouseShow)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
           
    }
}

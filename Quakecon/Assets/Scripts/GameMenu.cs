using Photon.Pun;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Realtime;

public class GameMenu : MonoBehaviour
{
    public GameObject MenuGame;
/*   public GameObject MenuGame;

    public void Update()
    {
       // if (PV.IsMine) { 
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MenuGame.SetActive(true);
            Cursor.visible = true;
        }
        else
        {
            MenuGame.SetActive(false);
        }
        //}
    }
*/
    public void Initialize(Player player)
    {

    }
    
    public void ResumeGame()
    {
        MenuGame.SetActive(false);
    }
    public void LeaveRoom()
    {
        MenuGame.SetActive(false);
        MenuManager.Instance.OpenMenu("loading");
    }
}

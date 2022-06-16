using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    
    void LateUpdate()
    {
      if (GameObject.Find ("EnemyBoss") != null)
      {
 
      } 
      else
      {
        {
      SceneManager.LoadScene(EndGame);
        }
      }
    }
}

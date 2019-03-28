using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //доступ к компонентам юай
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
   public void Restart()
    {
        SceneManager.LoadScene("Arcada", LoadSceneMode.Single); //будем загружена сцена Аркада ((если у вас несколько сцен, то используйте LoadSceneMode.Additive)), для одной сцены Single
    }

   public void ExitGame()
    {
        Application.Quit();//выход из игры
    }
}

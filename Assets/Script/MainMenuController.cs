using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame(){
        Debug.Log("Created by [Nizam Aditya Zuhayr] - [149251970101-148]");
        SceneManager.LoadScene("Game");
    }
}

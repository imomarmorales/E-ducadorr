﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Cambiar : MonoBehaviour
{
    // Start is called before the first frame update
   public void PlayGame()
    {   
        Debug.Log("click");
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
 
    }

}

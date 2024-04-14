using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager.UI;
using UnityEngine;
using UnityEngine.SceneManagement;


public class NewBehaviourScript : MonoBehaviour
{
    
    void Start()
    {
        
    }

    
    void Update()
    {
        SceneManager.LoadScene(1);
    }
}

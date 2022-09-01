using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GAMEOVERSCREEN : MonoBehaviour
{
    public void restart()
    {
        SceneManager.LoadScene("scene01");
    }
    
}

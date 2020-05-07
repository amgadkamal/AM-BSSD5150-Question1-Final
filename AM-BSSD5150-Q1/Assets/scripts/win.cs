using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class win : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindWithTag("restart").GetComponent<Button>().onClick.AddListener(restart);
        
    }

    // Update is called once per frame
    void restart()
    {
        SceneManager.LoadScene("main");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject Cred;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneChange(){
        SceneManager.LoadScene("Level1");
    }
    public void Credit(){
        Cred.gameObject.SetActive(true);
    }
    public void Close(){
        Cred.gameObject.SetActive(false);
    }
    public void exit(){
        Application.Quit();
    }
}

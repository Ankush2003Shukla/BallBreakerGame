using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ball2 : MonoBehaviour
{
    public UIManager ui;
    public Rigidbody2D rb;
    public float ballForce;
    bool gameStarted = false;
    int i = 3;
    int s = 1;
    int p = 0;
    public Image live1;
    public Image live2;
    public Image live3;
    public GameObject Close;
    public GameObject Brick;
    void Start()
    {
        ui = GameObject.FindWithTag("ui").GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        LetsGO();
    }
    void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.tag == "last") {
            if(p==40){
                SceneManager.LoadScene("Level3");
            }
            if(i==0){
                Destroy (gameObject);
                Close.gameObject.SetActive(true);
                Brick.gameObject.SetActive(false);
                ui.ScoreShow();
            }
            if (i==3){
                live1.gameObject.SetActive(false);
            }
            if(i==2){
                live2.gameObject.SetActive(false);
            }
            if(i==1){
                live3.gameObject.SetActive(false);
            }
            p++;
            i--;
            gameStarted=false;
            rb.simulated = false;
            GameObject parentO = GameObject.FindWithTag("paddle");
            GameObject ChildO = GameObject.FindWithTag("ball");
            if(parentO != null && ChildO != null){
                ChildO.transform.SetParent(parentO.transform);
                parentO.transform.localPosition =new Vector2(-0.12f,-4.65f);
                ChildO.transform.localPosition = new Vector2(0,1.33f);
            }
            
        }
    }
    void LetsGO(){
        if (Input.GetKeyUp(KeyCode.Space) && (gameStarted==false)){
            transform.SetParent(null);
            rb.simulated = true;
            if (s == 1){
                rb.AddForce(new Vector2(ballForce,ballForce));
            }
            gameStarted=true;
            s--;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HUD_canvas : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]float timeLeft;
    public Text gameOverText;
    public Text player1_win;
    public Text player2_win;
    public int player1_sayi;
    public int player2_sayi;
    
    public Text player1_score;
    public Text player2_score;
    public GameObject WallLeft;
    public GameObject WallRight;
    public GameObject Ball;

  
 
    public Text time_text;

    
    // Update is called once per frame
    void Update()
    {
        time_text.text=timeLeft.ToString();
        
        zaman();
       // Winner();
        
        
       
    }

    
    /*public void Winner(){
        if (timeLeft == 0f && player1_sayi >= player2_sayi || player2_sayi >= player1_sayi)
        {
            if (player1_sayi >= player2_sayi && player2_sayi < player1_sayi -1)
            {
                player1_win.gameObject.SetActive(true);
                Debug.Log("player1 kazandı");
            }
            
        }else if (player2_sayi >= player1_sayi && player1_sayi < player2_sayi -1)
        
        {
            player2_win.gameObject.SetActive(true);
            Debug.Log("player2 kazandı");
        }
        else if (timeLeft==0f && player1_sayi == player2_sayi)
        {
            player1_win.gameObject.SetActive(true);
            player2_win.gameObject.SetActive(true);
            Debug.Log("Berabere");
        }
    }*/

    public void zaman(){
        timeLeft -=Time.deltaTime;
        if (timeLeft < 0 || timeLeft == 0)
        {
            GameOver();
            

        }
    }
    public void GameOver(){
        gameOverText.gameObject.SetActive(true);
        Ball.gameObject.SetActive(false);
        timeLeft = 0f;
    }
    void OnCollisionEnter2D(Collision2D col){

        if (col.gameObject.tag=="duvar_right")
        {
            player1_score.text = player1_sayi.ToString();
            player1_sayi++;
            Debug.Log("player_1 sayı");
        }
        else if (col.gameObject.tag=="duvar_left")
        {
            player2_score.text = player2_sayi.ToString();
            player2_sayi++;
            Debug.Log("player_2 sayı");
        }
    }
    

}

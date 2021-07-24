using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public GameObject TierPanel,categoryPanel;
    public GameObject gamePanel1, gamePanel2, gamePanel3, gamePanel4;

    private void Start()
    {
        TierPanel.SetActive(true);
        categoryPanel.SetActive(false);
        gamePanel1.SetActive(false);
        gamePanel2.SetActive(false);
        gamePanel3.SetActive(false);
        gamePanel4.SetActive(false);
    }

    /* PANEL OPTIONS */
    public void onClickTier()
    {
        TierPanel.SetActive(false);
        categoryPanel.SetActive(true);
    }


    public void onClick_Category1()
    {
        categoryPanel.SetActive(false);
        gamePanel1.SetActive(true);
    }

    public void onClick_Category2()
    {
        categoryPanel.SetActive(false);
        gamePanel2.SetActive(true);
    }
    public void onClick_Category3()
    {
        categoryPanel.SetActive(false);
        gamePanel3.SetActive(true);
    }
    public void onClick_Category4()
    {
        categoryPanel.SetActive(false);
        gamePanel4.SetActive(true);
    }




    /* CATEGORY 1 GAMES */
    public void onClick_Game1()
    {
        SceneManager.LoadScene(9);
    }

    public void onClick_Game2()
    {
        SceneManager.LoadScene(10);
    }

    public void onClick_Game3()
    {
        SceneManager.LoadScene(11);
    }

    public void onClick_Game4()
    {
        SceneManager.LoadScene(12);
    }


    /* CATEGORY 2 GAMES */
    public void onClick_Game5()
    {
        SceneManager.LoadScene(5);
    }

    public void onClick_Game6()
    {
        SceneManager.LoadScene(6);
    }

    public void onClick_Game7()
    {
        SceneManager.LoadScene(7);
    }

    public void onClick_Game8()
    {
        SceneManager.LoadScene(8);
    }



    /* CATEGORY 3 GAMES */
    public void onClick_Game9()
    {
        SceneManager.LoadScene(1);
    }

    public void onClick_Game10()
    {
        SceneManager.LoadScene(2);
    }

    public void onClick_Game11()
    {
        SceneManager.LoadScene(3);
    }

    public void onClick_Game12()
    {
        SceneManager.LoadScene(4);
    }


    /* CATEGORY 4 GAMES */
    public void onClick_Game13()
    {
        SceneManager.LoadScene(13);
    }

    public void onClick_Game14()
    {
        SceneManager.LoadScene(14);
    }

    public void onClick_Game15()
    {
        SceneManager.LoadScene(15);
    }

    public void onClick_Game16()
    {
        SceneManager.LoadScene(16);
    }

    /* BACK OPTION IN GAME PANEL */
    public void onClick_Back()
    {
        gamePanel1.SetActive(false);
        gamePanel2.SetActive(false);
        gamePanel3.SetActive(false);
        gamePanel4.SetActive(false);
        categoryPanel.SetActive(true);
    }

    /* QUIT GAME*/
    public void onClick_Quit()
    {
        Application.Quit();
    }
}
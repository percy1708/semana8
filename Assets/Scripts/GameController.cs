using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public Text scoreText;
    public Text lifesText;
    public Text lifesEnemy;
    
    private int _score = 0;
    private int _lifes = 3;
    private int _lifesenemy = 3;


    private void Start()
    {
        scoreText.text = "KILLS: " + _score;
        PrintLifes();
        //PrintLifesEnemy();
    }
   /* private void StartEnemy()
    {
      
        PrintLifesEnemy();
    }*/


    public int GetScore()
    {
        return _score;
    }

    public void PlusScore(int score)
    {
        _score += score;
        scoreText.text = "KILLS: " + _score;
    }
   

    public void LoseLife()
    {
        _lifes -= 1;
        PrintLifes();
    }
    public void LoseLifeEnemy()
    {
        _lifesenemy -= 1;
        PrintLifesEnemy();
    }

    public int GetLifes()
    {
        return _lifes;
    }
    
    public int GetLifesEnemy()
    {
        return _lifesenemy;
    }


    private void PrintLifes()
    {
        
        var text = "Lives: ";
        for (var i = 0; i < _lifes; i++)
        {
            text += "I ";
           
        }
        
        lifesText.text = text;
    }
    
    
    
    private void PrintLifesEnemy()
    {
        
        var texte = "L.Enemy: ";
        for (var a = 0; a < _lifesenemy; a++)
        {
            texte += "I ";
            
        }
        
        lifesEnemy.text = texte;
    }
}

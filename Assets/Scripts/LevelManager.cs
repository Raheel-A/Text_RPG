using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public ItemDatabase itemDatabase;

    public int maxChance;

    // Use this for initialization
    void Start()
    {

    }

    public void LoadLevel(string name)
    {
		Debug.Log ("New Level load: " + name);
		SceneManager.LoadScene(name);
	}

	public void QuitRequest()
    {
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

    public void attemptHoney()
    {
        int chance = Random.Range(1, 100);

        Debug.Log("Rolled a " + chance);

        if (chance >= maxChance)
        {
            SceneManager.LoadScene("Honey_Success");

            itemDatabase.hasHoney = true;
        }
        else
        {
            SceneManager.LoadScene("Honey_Fail");
        }
    }

    public void swordCheck()
    {
        if (itemDatabase.hasSword)
        {

        }
    }

    public void equationbookCheck()
    {
        if (itemDatabase.hasequationBook)
        {

        }
    }

    public void wandCheck()
    {
        if (itemDatabase.hasWand)
        {

        }
    }

    public void keyCheck()
    {
        if (itemDatabase.hasKey)
        {

        }
    }

    public void honeyCheck()
    {
        if (itemDatabase.hasHoney)
        {

        }
    }

    public void changeMoney(int Money)
    {
        itemDatabase.moneyAmount += Money;

        if (itemDatabase.moneyAmount < 0)
            {
                itemDatabase.moneyAmount = 0;
            }
    }

    public void moneyCheck(int itemValue)
    {
        if (itemDatabase.moneyAmount < itemValue)
            {
                // Scene "Not enough money"
            }
    }

    public void takeDamage(int damageTaken)
    {
        itemDatabase.charaHealth -= damageTaken;

        if (itemDatabase.charaHealth <= 0)
        {
            //Game Over
        }
    }

}

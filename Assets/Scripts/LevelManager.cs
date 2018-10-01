using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class LevelManager : MonoBehaviour {

    public ItemDatabase itemDatabase;

	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		SceneManager.LoadScene(name);
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

    public void attemptHoney()
    {
        int chance = Random.Range(1, 100);

        Debug.Log("Rolled a " + chance);

        if (chance >= 70)
        {
            SceneManager.LoadScene("Honey_Success");

            Debug.Log("Honey Get attempt");
        }
        else
        {
            SceneManager.LoadScene("Honey_Fail");
        }
    }

    public void attemptdrunkHoney()
    {
        int chance = Random.Range(1, 100);

        Debug.Log("Rolled a " + chance);

        if (chance >= 30)
        {
            SceneManager.LoadScene("Honey_Success");

            Debug.Log("Honey Get attempt");
        }
        else
        {
            SceneManager.LoadScene("Honey_Fail");
        }
    }

}

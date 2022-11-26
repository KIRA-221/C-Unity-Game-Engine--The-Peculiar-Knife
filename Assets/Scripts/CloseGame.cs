using UnityEngine;

public class CloseGame : MonoBehaviour {
    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}

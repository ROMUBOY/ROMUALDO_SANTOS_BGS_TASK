using UnityEngine;

public class MenuClose : MonoBehaviour
{
    public GameObject Menu;    

    public void CloseMenu()
    {
        Menu.SetActive(false);        
    }
}

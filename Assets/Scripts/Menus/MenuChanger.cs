using UnityEngine;

public class MenuChanger : MonoBehaviour
{
    public GameObject sourceMenu;
    public GameObject destinyMenu;

    public void ChangeMenu()
    {
        sourceMenu.SetActive(false);
        destinyMenu.SetActive(true);
    }
}

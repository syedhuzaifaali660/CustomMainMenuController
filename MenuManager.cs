using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField] Menu[] menus;
    public static MenuManager Instance;

    private void Awake()
    {
        Instance = this;
    }
    private void Start()
    {
        ResetMenu();
    }

    public void OpenMenu(menuName name)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            if(menus[i].selectMenuName == name)
            {
                menus[i].Open();
            }
            else if (menus[i].open)
            {
                CloseMenu(menus[i]);
            }
        }
    }

    public void OpenMenu(Menu menu)
    {
        for (int i = 0; i < menus.Length; i++)
        {
            if (menus[i].open)
            {
                CloseMenu(menus[i]);
            }
        }
        menu.Open();
    }

    void ResetMenu()
    {
        for (int i = 0; i < menus.Length; i++)
        {
            if (menus[i].open)
            {
                menus[i].Open();
            }
            else if (!menus[i].open)
            {
                menus[i].Close();
            }
        }
    }

    public void CloseMenu(Menu menu)
    {
        menu.Close();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helper_SetMenuOnButton : MonoBehaviour
{
    public menuName MenuToOpen;
    Button btn;

    // Start is called before the first frame update
    void Start()
    {
        btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OpenSelectedMenuOnClick);
    }

    public void OpenSelectedMenuOnClick()
    {
        MenuManager.Instance.OpenMenu(MenuToOpen);
    }
}

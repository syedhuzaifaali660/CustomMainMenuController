using UnityEngine;


public enum menuName
{
    loading,
    title,
    roomMenu,
    room,
    errorMessage,
    findRoom,
}
public class Menu : MonoBehaviour
{

    public menuName selectMenuName;
    public bool open;
    public void Open()
    {
        open = true;
        gameObject.SetActive(true);
    }

    public void Close()
    {
        open = false;
        gameObject.SetActive(false);
    }
}

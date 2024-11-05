using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PopupType
{
    SIGNINFAILURE,
    SIGNUPFAILURE,
    SIGNUP,
    PAUSE
}

public class PopUpManager : MonoBehaviour
{
    private static PopUpManager instance;

    [SerializeField] Transform parentTransform;

    private Dictionary<PopupType, GameObject> dictionary = new Dictionary<PopupType, GameObject>();
     
    public static PopUpManager Instance { get { return instance; } }

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);
    }

    public void Show(PopupType popupType, string content)
    {
        GameObject popup = null;

        if(dictionary.TryGetValue(popupType, out popup))
        {
            popup.gameObject.SetActive(true);
        }
        else
        {
            popup = Instantiate(Resources.Load<GameObject>("Sign In Failure PopUp"));

            popup.transform.SetParent(parentTransform);

            popup.GetComponent<PopUp>().SetData(content);

            dictionary.Add(popupType, popup);
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using System;
using TMPro.EditorUtilities;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject mainMenuCanvas;
    [SerializeField] private GameObject itemsMenuCanvas;
    [SerializeField] private GameObject ARPositionCanvas;
    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.OnMainMenu += ActivateMainMenu;
        GameManager.instance.OnItemsMenu += ActivateItemMenu;
        GameManager.instance.OnARPosition += ActivateARPosition;

    }

    private void ActivateMainMenu()
    {
        //el getchid(0) es el bot�n de closeAPP, el (1) de showitem y (2) de screenshot
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(1, 1, 1), 0.3f);

        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
    }
    private void ActivateItemMenu()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(300, 0.3f);
    }
    private void ActivateARPosition()
    {
        mainMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        mainMenuCanvas.transform.GetChild(2).transform.DOScale(new Vector3(0, 0, 0), 0.3f);

        itemsMenuCanvas.transform.GetChild(0).transform.DOScale(new Vector3(0, 0, 0), 0.5f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOScale(new Vector3(0, 0, 0), 0.3f);
        itemsMenuCanvas.transform.GetChild(1).transform.DOMoveY(180, 0.3f);

        ARPositionCanvas.transform.GetChild(0).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
        ARPositionCanvas.transform.GetChild(1).transform.DOScale(new Vector3(1, 1, 1), 0.3f);
    }



 


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    [SerializeField]
    private GameObject _manifestoPanel;

    [SerializeField]
    private GameObject _newsPanel;

    [SerializeField]
    private GameObject _statusPanel;

    private List<GameObject> _panels;

    // Start is called before the first frame update
    private void Start()
    {
        _panels = new List<GameObject>{
            _manifestoPanel, _newsPanel, _statusPanel
        };
    }

    // Update is called once per frame
    private void Update()
    {

    }

    public void ActivatePanel(string panelName)
    {
        switch (panelName)
        {
            case "status":
                _manifestoPanel.SetActive(false);
                _newsPanel.SetActive(false);
                _statusPanel.SetActive(true);
                break;
            case "news":
                _manifestoPanel.SetActive(false);
                _newsPanel.SetActive(true);
                _statusPanel.SetActive(false);
                break;
            case "manifesto":
                _manifestoPanel.SetActive(true);
                _newsPanel.SetActive(false);
                _statusPanel.SetActive(false);
                break;

            default:
                break;
        }
    }

    private void ActivatePanel(GameObject panel)
    {
        panel.SetActive(true);

        foreach (var p in _panels)
        {
            Debug.Log(p == panel);
            panel.SetActive(p == panel);
        }
    }
}

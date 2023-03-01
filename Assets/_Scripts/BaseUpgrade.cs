using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseUpgrade : MonoBehaviour
{
    public Farts Farts;
    public Text upgradeTitleText;
    public Text upgradeCostText;
    public Button upgradeButton;

    protected float upgradeCost;

    public virtual void Start()
    {
        upgradeButton.onClick.AddListener(OnUpgradeButtonPressed);
    }
    
    public void OnUpgradeButtonPressed()
    {
        if (Farts.getFartCount() >= upgradeCost)
        {
            Farts.addFartCount(-upgradeCost);
            Upgrade();
        }
    }
    
    protected virtual void Upgrade()
    {
        // Override this method in child classes
    }
}

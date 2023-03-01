using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpgradeEatHotCheeto : BaseUpgrade
{
    // Start is called before the first frame update
    private float upgradeCost = GameParameters.upgradeHotCheetoStartingCost;
    protected void Start()
    {
        upgradeTitleText.text = "Eat a Hot Cheeto";
        upgradeCostText.text = "$" + upgradeCost.ToString();
    }
    
    protected override void Upgrade()
    {
        if (Farts.getFartCount() >= upgradeCost)
        {
            Farts.setFartCount(Mathf.Round(Farts.getFartCount() - upgradeCost));
            Farts.setFartsPerClick(Farts.getFartsPerClick() + GameParameters.upgradeHotCheetoFartsPerClick);
            upgradeCost = Mathf.Round(upgradeCost * GameParameters.upgradeHotCheetoCostMultiplier);
            upgradeCostText.text = "$" + upgradeCost.ToString();   
        }
    }
}

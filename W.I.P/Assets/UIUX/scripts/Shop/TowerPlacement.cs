using UnityEngine;

public class TowerPlacement : MonoBehaviour
{

    public bool opDuracell = false, opMouseTrap = false, opSpray = false;

    private void Update()
    {
        Placement();
    }

    public void DuracellButton()
    {
        opDuracell = !opDuracell;   
    }

    public void MouseTrapButton()
    {
        opMouseTrap = !opMouseTrap;
    }

    public void SprayButton()
    {
        opSpray = !opSpray;
    }

    private void SelectionVisual()
    {

    }
    
    private void Placement()
    {
        if (opDuracell)
        {
            Debug.Log("summin happen");
        }

        if (opMouseTrap)
        {
            Debug.Log("summin happen");
        }

        if (opSpray)
        {
            Debug.Log("summin happen");
        }
    }
}

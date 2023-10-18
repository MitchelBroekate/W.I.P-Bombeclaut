using UnityEngine;
using UnityEngine.Rendering;

public class TowerPlacement : MonoBehaviour
{

    public bool opDuracell, opMouseTrap, opSpray, opHenry;

    InputMaster controls;

    private Vector3 mousePos;

    private void Awake()
    {
        controls = new InputMaster();
    }

    private void Update()
    {
        Placement();
    }

    public void DuracellButton()
    {
        opDuracell = !opDuracell;
        opMouseTrap = false;
        opSpray = false;
        opHenry = false;
    }

    public void MouseTrapButton()
    {
        opMouseTrap = !opMouseTrap;
        opSpray = false;
        opHenry = false;
        opDuracell = false;
    }

    public void SprayButton()
    {
        opSpray = !opSpray;
        opHenry = false;
        opDuracell = false;
        opMouseTrap = false;
    }
    public void HenryButton()
    {
        opHenry = !opHenry;
        opDuracell = false;
        opMouseTrap = false;
        opSpray = false;
    }

    private void SelectionVisual()
    {

    }
    
    private void Placement()
    {
        if (opDuracell)
        {
            Debug.Log("summin happen");
            mousePos = controls.Player.Cam.ReadValue<Vector2>();
        }

        if (opMouseTrap)
        {
            Debug.Log("summin happen");
            mousePos = controls.Player.Cam.ReadValue<Vector2>();

        }

        if (opSpray)
        {
            Debug.Log("summin happen");
            mousePos = controls.Player.Cam.ReadValue<Vector2>();

        }

        if (opHenry)
        {
            Debug.Log("summin happen");
            mousePos = controls.Player.Cam.ReadValue<Vector2>();

        }
    }
}

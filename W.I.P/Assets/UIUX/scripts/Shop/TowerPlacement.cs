using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    #region Links
    [SerializeField]
    private GameObject duracellO, MouseTrapO, SprayO, HenryO;

    private GameObject followMouse;
    private GameObject mousePlacement;

    [SerializeField]
    private Camera cam;

    public bool opDuracell, opMouseTrap, opSpray, opHenry;

    private PlacementSwitch place;

    InputMaster controls;

    Ray ray;
    RaycastHit hit;
    enum PlacementSwitch
    {
        duracell,
        mouseTrap,
        spray,
        henry
    }
    #endregion

    private void Awake()
    {
        controls = new InputMaster();
    }

    //Update to check when the state for the switch changes
    private void Update()
    {
        SwitchPlacement();
    }

    //Switch for placement checks for when you press one of the item buttons
    private void SwitchPlacement()
    {
        switch (place)
        {
            case PlacementSwitch.duracell:

                if (opDuracell)
                {
                    Debug.Log("Battery");

                    followMouse = duracellO;
                    mousePlacement = duracellO;

                    MouseCorrection();

                    controls.Player.Interact.performed += x => Placement();
                }

                break;

            case PlacementSwitch.mouseTrap:

                if (opMouseTrap)
                {
                    Debug.Log("Trap");

                    followMouse = MouseTrapO;
                    mousePlacement = MouseTrapO;

                    MouseCorrection();
                }

                break;

            case PlacementSwitch.spray:

                if (opSpray)
                {
                    Debug.Log("Spray");

                    followMouse = SprayO;
                    mousePlacement = SprayO;

                    MouseCorrection();
                }

                break;

            case PlacementSwitch.henry:

                if (opHenry)
                {
                    Debug.Log("Henry");

                    followMouse = HenryO;
                    mousePlacement = HenryO;

                    MouseCorrection();
                }

                break;
        }
    }

    #region Voids that link to buttons and enable/disable functions
    public void DuracellButton()
    {
        opDuracell = !opDuracell;
        opMouseTrap = false;
        opSpray = false;
        opHenry = false;
        place = PlacementSwitch.duracell;
    }

    public void MouseTrapButton()
    {
        opMouseTrap = !opMouseTrap;
        opSpray = false;
        opHenry = false;
        opDuracell = false;
        place = PlacementSwitch.mouseTrap;
    }

    public void SprayButton()
    {
        opSpray = !opSpray;
        opHenry = false;
        opDuracell = false;
        opMouseTrap = false;
        place = PlacementSwitch.spray;
    }
    public void HenryButton()
    {
        opHenry = !opHenry;
        opDuracell = false;
        opMouseTrap = false;
        opSpray = false;
        place = PlacementSwitch.henry;
    }
    #endregion

    //A void for the raycast so that you see where/what you place
    private void MouseCorrection()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            followMouse.transform.position = hit.point;
        }
    }

    private void Placement()
    {

        Destroy(followMouse);
        Instantiate(mousePlacement);

    }
}

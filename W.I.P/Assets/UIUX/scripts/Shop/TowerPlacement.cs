using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    #region Links
    [SerializeField]
    private GameObject duracellO, mouseTrapO, sprayO, henryO;

    [SerializeField]
    private GameObject duracellP, mouseTrapP, sprayP, henryP;

    [SerializeField]
    private GameObject placementPos;

    private GameObject followMouse;
    private GameObject mousePlacement;

    [SerializeField]
    private Camera cam;

    [SerializeField]
    private bool opDuracell, opMouseTrap, opSpray, opHenry;

    private bool placeSwitchCheck;

    Vector3 startOpPos;

    private PlacementSwitch place;

    InputMaster controls;

    Ray ray;
    RaycastHit hit;
    enum PlacementSwitch
    {
        duracell,
        mouseTrap,
        spray,
        henry,
        placed
    }
    #endregion

    //Awake for linking the player input
    private void Awake()
    {
        controls = new InputMaster();
    }

    //start for start possition for towerselections to return to
    private void Start()
    {
        startOpPos = duracellO.transform.position;
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
                    mousePlacement = duracellP;

                    MouseCorrection();
                }

                break;

            case PlacementSwitch.mouseTrap:

                if (opMouseTrap)
                {
                    Debug.Log("Trap");

                    followMouse = mouseTrapO;
                    mousePlacement = mouseTrapP;

                    MouseCorrection();
                }

                break;

            case PlacementSwitch.spray:

                if (opSpray)
                {
                    Debug.Log("Spray");

                    followMouse = sprayO;
                    mousePlacement = sprayP;

                    MouseCorrection();
                }

                break;

            case PlacementSwitch.henry:

                if (opHenry)
                {
                    Debug.Log("Henry");

                    followMouse = henryO;
                    mousePlacement = henryP;

                    MouseCorrection();
                }

                break;

            case PlacementSwitch.placed:

                if (placeSwitchCheck)
                {
                    followMouse.transform.position = startOpPos;

                    Instantiate(mousePlacement, placementPos.transform);

                    placeSwitchCheck = false;
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

    //A void for when you click to place a tower on that current possition
    public void Placement()
    {
        if(opDuracell || opHenry || opMouseTrap || opSpray)
        {
            opDuracell = false;
            opHenry = false;
            opMouseTrap = false;
            opSpray = false;

            placeSwitchCheck = true;

            placementPos.transform.position = followMouse.transform.position;

            place = PlacementSwitch.placed;
        }

    }
}

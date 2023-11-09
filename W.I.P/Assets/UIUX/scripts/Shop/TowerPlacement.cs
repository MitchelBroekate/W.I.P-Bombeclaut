using Unity.VisualScripting;
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
    private GameObject shop;

    [SerializeField]
    private bool opDuracell, opMouseTrap, opSpray, opHenry;

    private bool placeSwitchCheck;

    private bool hitCheck;

    Vector3 startOpPos;

    Ray ray;
    RaycastHit hit;

    public Material greenMat;
    public Material redMat;

    public ShopOpen shopScript;
    public PauseScript pauseScript;
    #endregion

    //start for start possition for towerselections to return to
    private void Start()
    {
        startOpPos = duracellO.transform.position;
    }

    //Update to check when the state for the switch changes
    private void Update()
    {
        PlaceTower();
    }


    #region Voids that link to buttons and enable/disable functions
    public void DuracellButton()
    {
        opDuracell = !opDuracell;

        followMouse = duracellO;
        mousePlacement = duracellP;

    }

    public void MouseTrapButton()
    {
        opMouseTrap = !opMouseTrap;

        followMouse = mouseTrapO;
        mousePlacement = mouseTrapP;
    }

    public void SprayButton()
    {
        opSpray = !opSpray;

        followMouse = sprayO;
        mousePlacement = sprayP;
    }
    public void HenryButton()
    {
        opHenry = !opHenry;

        followMouse = henryO;
        mousePlacement = henryP;

    }
    #endregion

    //A void for the raycast so that you see where/what you place
    private void MouseCorrection()
    {
        ray = cam.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out hit, 100))
        {
            followMouse.transform.position = hit.point;
            hitCheck = true;
        }
        else
        {
            hitCheck = false;
        }
    }

    //A void for when you click to place a tower on that current possition
    public void PlacementMouse()
    {
        if(opDuracell || opHenry || opMouseTrap || opSpray)
        {
            opDuracell = false;
            opHenry = false;
            opMouseTrap = false;
            opSpray = false;

            placeSwitchCheck = true;

            placementPos.transform.position = followMouse.transform.position;

        }

    }

    void PlaceTower()
    {
        if(hitCheck)
        {
            if (placeSwitchCheck && hit.transform.tag != "Path")
            {
                followMouse.transform.position = startOpPos;

                Instantiate(mousePlacement, hit.point, Quaternion.identity);

                placeSwitchCheck = false;

                shop.SetActive(true);
                shopScript.pauseMenuBlock = false;
                pauseScript.shopOpenBlock = false;
            }
            Debug.Log(hit);

            if (hit.transform.tag == "Path")
            {
                followMouse.transform.position = startOpPos;

                placeSwitchCheck = false;

                shop.SetActive(true);

                followMouse.GetComponentInChildren<MeshRenderer>().material = redMat;

                
            }
            //else
            //{
            //    followMouse.GetComponentInChildren<MeshRenderer>().material = greenMat;
            //}
        }

        if (opDuracell || opHenry || opMouseTrap || opSpray)
        {
            MouseCorrection();
            shop.SetActive(false);
            shopScript.pauseMenuBlock = true;
            pauseScript.shopOpenBlock = true;
        }

        if (opMouseTrap)
        {
            hit.point += new Vector3(0, 0.03f, 0);
        }

    }
}



using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class TowerPlacement : MonoBehaviour
{
    #region Variables
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
    private GameObject scriptLink;

    private GameObject tower;

    [SerializeField]
    private bool opDuracell, opMouseTrap, opSpray, opHenry;

    private bool placeSwitchCheck;

    private bool hitCheck;

    public bool pathPlacement;

    Vector3 startOpPos;

    Quaternion rotated;

    Ray ray;
    RaycastHit hit;

    int minMoney;

    public Material greenMat;
    public Material redMat;

    public ShopOpen shopScript;
    public PauseScript pauseScript;
    #endregion

    //start for start possition for towerselections to return to and perform rotation void
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

        minMoney = 100;

    }

    public void MouseTrapButton()
    {
        opMouseTrap = !opMouseTrap;

        pathPlacement = true;

        followMouse = mouseTrapO;
        mousePlacement = mouseTrapP;

        minMoney = 200;
    }

    public void SprayButton()
    {
        opSpray = !opSpray;

        followMouse = sprayO;
        mousePlacement = sprayP;

        minMoney = 350;
    }
    public void HenryButton()
    {
        opHenry = !opHenry;

        followMouse = henryO;
        mousePlacement = henryP;

        minMoney = 500;

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

    //void for placement of the towers, check if it can be placed on that position (if not, return) and reduction of money
    void PlaceTower()
    {
        if(hitCheck)
        {
            if (placeSwitchCheck)
            {
                if (hit.transform.tag != "NonPlace")
                {
                    if (hit.transform.tag == "Path")
                    {
                        if (hit.transform.tag != "Enemy")
                        {
                            if (pathPlacement)
                            {
                                BaseScript baseScript = scriptLink.GetComponent<BaseScript>();

                                if (baseScript.moneyAmount >= minMoney)
                                {
                                    baseScript.moneyAmount -= minMoney;

                                    followMouse.transform.position = startOpPos;

                                    tower = Instantiate(mousePlacement, hit.point, rotated);
                                    tower.tag = "NonPlace";
                                    pathPlacement = false;
                                    placeSwitchCheck = false;

                                    shop.SetActive(true);
                                    shopScript.pauseMenuBlock = false;
                                    pauseScript.shopOpenBlock = false;
                                    shopScript.shopIsOpen = true;
                                }
                                else
                                {
                                    followMouse.transform.position = startOpPos;
                                    pathPlacement = false;
                                    placeSwitchCheck = false;

                                    shop.SetActive(true);
                                    shopScript.pauseMenuBlock = false;
                                    pauseScript.shopOpenBlock = false;
                                    shopScript.shopIsOpen = true;
                                }
                            }
                            else
                            {
                                followMouse.transform.position = startOpPos;
                                pathPlacement = false;
                                placeSwitchCheck = false;

                                shop.SetActive(true);
                                shopScript.pauseMenuBlock = false;
                                pauseScript.shopOpenBlock = false;
                                shopScript.shopIsOpen = true;

                            }
                        }
                    }
                    else
                    {
                        if (pathPlacement)
                        {
                            pathPlacement = false;

                            followMouse.transform.position = startOpPos;

                            placeSwitchCheck = false;

                            shop.SetActive(true);
                            shopScript.pauseMenuBlock = false;
                            pauseScript.shopOpenBlock = false;
                        }
                        else
                        {
                            BaseScript baseScript = scriptLink.GetComponent<BaseScript>();

                            if (baseScript.moneyAmount >= minMoney)
                            {
                                baseScript.moneyAmount -= minMoney;

                                followMouse.transform.position = startOpPos;

                                tower = Instantiate(mousePlacement, hit.point, rotated);
                                tower.tag = "NonPlace";

                                placeSwitchCheck = false;

                                shop.SetActive(true);
                                shopScript.pauseMenuBlock = false;
                                pauseScript.shopOpenBlock = false;

                            }
                            else
                            {
                                followMouse.transform.position = startOpPos;

                                placeSwitchCheck = false;

                                shop.SetActive(true);
                                shopScript.pauseMenuBlock = false;
                                pauseScript.shopOpenBlock = false;
                            }
                        }
                    }
                }
                else
                {
                    followMouse.transform.position = startOpPos;

                    placeSwitchCheck = false;

                    shop.SetActive(true);
                    shopScript.pauseMenuBlock = false;
                    pauseScript.shopOpenBlock = false;
                }
            }

            if (hit.transform.tag == "Path")
            {
                followMouse.transform.position = startOpPos;

                placeSwitchCheck = false;

                shop.SetActive(true);
                shopScript.pauseMenuBlock = false;
                pauseScript.shopOpenBlock = false;
            }

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

        if (opHenry) 
        {
            hit.point += new Vector3(0, 0.135f, 0);
        }

    }

    //void for rotating buildings
    public void RotateTower()
    {
         followMouse.transform.Rotate(new Vector3(0, 45, 0));
        rotated = followMouse.transform.rotation;
    }

}
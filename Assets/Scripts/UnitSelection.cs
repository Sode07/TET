using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Photon.Pun;

public class UnitSelection : MonoBehaviour
{
    private Transform MovePos;

    public GameObject Selection;
    public GameObject UnitRekry;
    public GameObject EngineerUI;
    public GameObject Selected;

    private Vector3 center;

    private float radius;
    private float points;
    private float EHP;
    private float DMG;

    private Stats stats;
    public ActionPoints ap;

    public bool SelectingBuilding;
    private bool Check = false;
    public bool EngineerSelected;

    public LayerMask IgnoreMe;
    public LayerMask PlayerCheck;

    public int isWhiteTurn;

    private void Awake()
    {
        isWhiteTurn = 1;
        Application.targetFrameRate = 30;
    }

    private void Update()
    {
        //if (Selection = null)
        //{
        //    Selected.SetActive(false);
        //}
        //else Selected.SetActive(true);
        points = ap.actionPoints;
        if (Input.GetMouseButtonDown(0))
        {

            Debug.Log("hiiri alas");
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if(Physics.Raycast(ray, out hit, 1000, ~PlayerCheck))
            {
                Debug.Log("säde ulos");
                if (hit.transform.tag == "Unit")
                {
                    Selection = hit.transform.gameObject;
                    Check = true;
                    Debug.Log("Ei rikki");
                    if (Selection.GetComponent<Stats>().SightRange == 1)
                    {
                        Debug.Log("Beep Boop");
                        EngineerSelected = true;
                    }
                    else
                    {
                        EngineerSelected = false;
                    }
                    Debug.Log("Yksikkö valittu");
                }
                if (hit.transform.tag == "Base")
                {
                    Selection = null;
                    UnitRekry.SetActive(true);
                }
                else
                {
                    UnitRekry.SetActive(false);
                }
            }
        }
        if (EngineerSelected)
        {
            EngineerUI.SetActive(true);
        }
        else EngineerUI.SetActive(false);
        if(Selection == null)
        {
            Debug.Log("Unit not selected");
            Selected.SetActive(false);
            return;
        }
        if (Selection.GetComponent<Stats>().SightRange >= 0)
        {
            Selected.SetActive(true);
        }
        if (Input.GetMouseButtonDown(1))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 1000))
            {
                Debug.Log("säde 1 ulos");
                center = Selection.transform.position;
                stats = Selection.transform.gameObject.GetComponent<Stats>();
                Debug.Log(stats);
                Debug.DrawLine(Camera.main.transform.position, hit.point, Color.red, 2f);
                if (hit.transform.tag == "Tile")
                {
                    Debug.Log("Osui " + hit.collider.gameObject.transform.position);
                    if (points >= 1)
                    {
                        Collider[] hitColliders = Physics.OverlapSphere(center, stats.MoveRange * 2.7f);
                        
                        if (hitColliders.Contains(hit.transform.gameObject.GetComponent<MeshCollider>()))
                        {
                            Selection.transform.position = hit.transform.position;
                            Selection.transform.Translate(0, 0.7f, 0);
                            Debug.Log("Yksikkö liikkui");
                            Selection = null;
                            EngineerSelected = false;
                            ap.actionPoints -= 1;
                        }
                    }
                }
                if (hit.transform.tag == "Unit")
                {
                    Debug.Log("Osui");
                    if (points >= 1)
                    {
                        Collider[] hitColliders = Physics.OverlapSphere(center, stats.AttackRange * 2.7f);
                        if (hitColliders.Contains(hit.transform.gameObject.GetComponent<MeshCollider>()))
                        {
                            Debug.Log("Not Crashed!");
                            EHP = hit.transform.gameObject.GetComponent<Stats>().HP;
                            DMG = Selection.transform.gameObject.GetComponent<Stats>().AttackDmg;
                            Debug.LogError(EHP);
                            Debug.LogError(DMG);
                            EHP -= DMG;
                            hit.transform.gameObject.GetComponent<Stats>().HP = EHP;
                            Debug.Log("Yksikkö Haavoittui");
                            ap.actionPoints -= 1;
                        }
                    }
                }
                if (hit.transform.tag == "Base")
                {
                    Debug.Log("Osui");
                    if (points >= 1)
                    {
                        Collider[] hitColliders = Physics.OverlapSphere(center, stats.AttackRange * 2.7f);
                        if (hitColliders.Contains(hit.transform.gameObject.GetComponent<MeshCollider>()))
                        {
                            Debug.Log("Not Crashed!");
                            EHP = hit.transform.gameObject.GetComponent<Stats>().HP;
                            DMG = Selection.transform.gameObject.GetComponent<Stats>().AttackDmg;
                            Debug.LogError(EHP);
                            Debug.LogError(DMG);
                            EHP -= DMG;
                            hit.transform.gameObject.GetComponent<Stats>().HP = EHP;
                            Debug.Log("Yksikkö Haavoittui");
                            ap.actionPoints -= 1;
                        }
                    }
                }
                if (hit.transform.tag == "School")
                {
                    if (points >= 1)
                    {
                        Collider[] hitColliders = Physics.OverlapSphere(center, stats.MoveRange * 2.7f);
                        if (hitColliders.Contains(hit.transform.gameObject.GetComponent<MeshCollider>()))
                        {
                            Selection.transform.position = hit.transform.position;
                            Debug.Log("Yksikkö liikkui");
                            Selection.GetComponent<Stats>().AttackDmg += 1;
                            Selection.GetComponent<Stats>().HP += 1;
                            Selection.GetComponent<Stats>().AttackRange += 1;
                            Selection.GetComponent<Stats>().MoveRange += 1;
                            Selection = null;
                            EngineerSelected = false;
                            ap.actionPoints -= 1;
                        }
                    }
                }
            }
        }
    }
    //private void OnDrawGizmos()
    //{
    //    if(Selection != null)
    //    {
    //        Gizmos.color = new Color(0.75f, 0f, 0f, 0.25f);
    //        Gizmos.DrawSphere(center, stats.AttackRange * 2.7f);
    //    }
    //}
}
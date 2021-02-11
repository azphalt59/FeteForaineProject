using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class CardSelector : MonoBehaviour
{
    [System.Serializable]
    public struct CardID
    {
        public string id;
        public GameObject gameObject;
    }

    [SerializeField]
    private List<CardID> cards = new List<CardID>();

    private Dictionary<string,GameObject> cardDictionary = new Dictionary<string, GameObject>();
    private ARTrackedImage image;

    private void Start() {
        foreach(CardID id in cards){
            cardDictionary.Add(id.id,id.gameObject);
        }
        image = GetComponent<ARTrackedImage>();
        cardDictionary[image.referenceImage.name].gameObject.SetActive(true);
    }
}

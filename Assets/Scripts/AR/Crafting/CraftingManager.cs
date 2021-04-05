using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingManager : MonoBehaviour
{
    [SerializeField]
    private RecipeList recipeList;
    [SerializeField]
    private float MaxDistanceForCraft = 2f;
    [SerializeField]
    private float MaxAngleDifferenceForCraft = 0.5f;

    [SerializeField]
    private List<GameObject> reciperesults = new List<GameObject>();

    private void Start() {
        foreach(CraftRecipe recipe in recipeList.recipes){
            GameObject Result = Instantiate(recipe.Result,Vector3.zero,Quaternion.identity);
            Result.SetActive(false);
            reciperesults.Add(Result);
        }
    }

    private void Update() {
        foreach(CraftCard card in CraftCard.AllCards){
            card.ActivateModel(true);
        }
        foreach(CraftRecipe recipe in recipeList.recipes){
            CheckForCraft(recipe);
        }
    }

    private void CheckForCraft(CraftRecipe recipe){
        CraftCard Card1 = null;
        foreach(CraftCard card in CraftCard.AllCards){
            if (recipe.FirstItem == card.ID){
                Card1 = card;
            }
        }
        if (Card1 == null){
            DeactivateResult(recipe);
            return;
        }
        CraftCard Card2 = null;
        foreach(CraftCard card in CraftCard.AllCards){
            if (recipe.SecondItem == card.ID){
                Card2 = card;
            }
        }
        if (Card2 == null){
            DeactivateResult(recipe);
            return;
        }

        if (Vector3.Distance(Card1.transform.position,Card2.transform.position) > MaxDistanceForCraft){
            DeactivateResult(recipe);
            return;
        }

        if (Quaternion.Dot(Card1.transform.rotation,Card2.transform.rotation) < MaxAngleDifferenceForCraft){
            DeactivateResult(recipe);
            return;
        }

        Card1.ActivateModel(false);
        Card2.ActivateModel(false);
        UpdateResult(recipe,Card1,Card2);
    }

    private void DeactivateResult(CraftRecipe recipe){
        reciperesults[recipeList.recipes.IndexOf(recipe)].SetActive(false);
    }

    private void UpdateResult(CraftRecipe recipe, CraftCard Card1, CraftCard Card2){
        GameObject result = reciperesults[recipeList.recipes.IndexOf(recipe)];
        result.SetActive(true);
        result.transform.position = Vector3.Lerp(Card1.transform.position,Card2.transform.position,0.5f);
        result.transform.rotation = Quaternion.Lerp(Card1.transform.rotation, Card2.transform.rotation, 0.5f);
    }
}

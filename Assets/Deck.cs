using UnityEngine;
using System.Collections;
using System.Collections.Generic; 

public class Deck : MonoBehaviour {
	
	public GameObject cardExemple;
	public List<Card> cards = new List<Card>();

	public void addCard(Card card){
		if(!this.cards.Contains(card)){
			this.cards.Add(card);

			Card cardComponent = this.cardExemple.gameObject.AddComponent<Card>();
			cardComponent.name = card.name;
			cardComponent.cardClass = card.cardClass;
			cardComponent.manaCost = card.manaCost;
			cardComponent.attack = card.attack;
			cardComponent.health = card.health;
			cardComponent.codeDeathRattle = card.codeDeathRattle;
			cardComponent.codeBattleCry = card.codeBattleCry;
			cardComponent.taunt = card.taunt;
			cardComponent.charge = card.charge;
			cardComponent.stealth = card.stealth;
			cardComponent.legendary = card.legendary;

			GameObject newCard = Instantiate(cardExemple);
			newCard.transform.parent = this.gameObject.transform;

		}
	}
}
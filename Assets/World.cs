using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class World : MonoBehaviour {

	public Player player;
	public GameObject dictionaries;

	void Start(){
		CardsDictionary cardsDictionary = dictionaries.GetComponent<CardsDictionary> ();
		cardsDictionary.generateCards();

		Card card = cardsDictionary.GetCard ("glyci");
		this.player.deck.addCard (card);

	}

}

using UnityEngine;
using System.Collections;

public class Prospector : MonoBehaviour {

	static public Prospector S;
	public Deck deck;
	public TextAsset deckXML;

	void Awake()
	{
		S = this; // Set up a Singleton for Prospector
	}

	void Start()
	{
		deck = GetComponent<Deck>(); // Get the Deck
		deck.InitDeck(deckXML.text); // Pass DeckXML to it
		Deck.Shuffle(ref deck.cards);    // This shuffles the deck
		// The ref keyword passes a reference to deck.cards, which allows
		//   deck.cards to be modified by Deck.Shuffle()
	}
}

public class Solution {
    public int[] DeckRevealedIncreasing(int[] deck) {        
        Array.Sort(deck);

        LinkedList<int> buffer = new LinkedList<int>();
        for (int i = deck.Length - 1; i >= 0; --i) {
            if (buffer.Count > 0) {
                buffer.AddFirst(buffer.Last.Value);
                buffer.RemoveLast();              
            } 

            buffer.AddFirst(deck[i]);
        }

        List<int> result = new List<int>();
        LinkedListNode<int> current = buffer.First;
        while (current != null) {
            result.Add(current.Value);
            current = current.Next;
        }

        return result.ToArray();
    }
}